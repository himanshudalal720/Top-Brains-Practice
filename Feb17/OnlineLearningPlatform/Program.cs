using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLearningPlatform
{
    // Custom Exceptions

    class DuplicateEnrollmentException : Exception
    {
        public DuplicateEnrollmentException(string message) : base(message) { }
    }

    class CourseCapacityExceededException : Exception
    {
        public CourseCapacityExceededException(string message) : base(message) { }
    }

    class AssignmentDeadlineException : Exception
    {
        public AssignmentDeadlineException(string message) : base(message) { }
    }

    // Generic Repository Interface

    interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }

    // Generic Repository Implementation

    class Repository<T> : IRepository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }
    }

    // Course Class

    class Course : IComparable<Course>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MaxCapacity { get; set; }
        public double Rating { get; set; }

        // Custom Sorting by Rating Descending

        public int CompareTo(Course other)
        {
            return other.Rating.CompareTo(this.Rating);
        }
    }

    // Student Class

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Instructor Class

    class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Enrollment Class

    class Enrollment
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }

    // Assignment Class

    class Assignment
    {
        public string Title { get; set; }
        public DateTime Deadline { get; set; }

        public void Submit(DateTime submissionDate)
        {
            if (submissionDate > Deadline)
                throw new AssignmentDeadlineException("Assignment submitted after deadline.");

            Console.WriteLine("Assignment submitted successfully.");
        }
    }

    // Program

    class Program
    {
        static IRepository<Course> courseRepo = new Repository<Course>();
        static IRepository<Student> studentRepo = new Repository<Student>();
        static IRepository<Instructor> instructorRepo = new Repository<Instructor>();
        static List<Enrollment> enrollments = new List<Enrollment>();

        static void Main()
        {
            SeedData();

            try
            {
                EnrollStudent(1, 1, 1);
                EnrollStudent(2, 1, 1);
                EnrollStudent(1, 2, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            RunLINQQueries();

            Console.ReadLine();
        }

        // Seed Data

        static void SeedData()
        {
            courseRepo.Add(new Course { Id = 1, Title = "C# Mastery", MaxCapacity = 100, Rating = 4.5 });
            courseRepo.Add(new Course { Id = 2, Title = "Data Structures", MaxCapacity = 50, Rating = 4.8 });
            courseRepo.Add(new Course { Id = 3, Title = "AI Basics", MaxCapacity = 60, Rating = 4.2 });

            studentRepo.Add(new Student { Id = 1, Name = "Amit" });
            studentRepo.Add(new Student { Id = 2, Name = "Ravi" });
            studentRepo.Add(new Student { Id = 3, Name = "Neha" });

            instructorRepo.Add(new Instructor { Id = 1, Name = "Mr. Sharma" });
        }

        // Enrollment Logic

        static void EnrollStudent(int studentId, int courseId, int instructorId)
        {
            var student = studentRepo.GetAll().FirstOrDefault(s => s.Id == studentId);
            var course = courseRepo.GetAll().FirstOrDefault(c => c.Id == courseId);
            var instructor = instructorRepo.GetAll().FirstOrDefault(i => i.Id == instructorId);

            if (student == null || course == null || instructor == null)
                throw new Exception("Invalid student, course or instructor ID.");

            if (enrollments.Any(e => e.Student.Id == studentId && e.Course.Id == courseId))
                throw new DuplicateEnrollmentException("Student already enrolled in this course.");

            int currentCount = enrollments.Count(e => e.Course.Id == courseId);

            if (currentCount >= course.MaxCapacity)
                throw new CourseCapacityExceededException("Course capacity exceeded.");

            enrollments.Add(new Enrollment
            {
                Student = student,
                Course = course,
                Instructor = instructor
            });

            Console.WriteLine("Enrollment successful.");
        }

        // LINQ Queries

        static void RunLINQQueries()
        {
            Console.WriteLine("\nCourses with more than 50 students:");

            var popularCourses = enrollments
                .GroupBy(e => e.Course)
                .Where(g => g.Count() > 50)
                .Select(g => g.Key.Title);

            foreach (var course in popularCourses)
                Console.WriteLine(course);

            Console.WriteLine("\nStudents enrolled in more than 3 courses:");

            var activeStudents = enrollments
                .GroupBy(e => e.Student)
                .Where(g => g.Count() > 3)
                .Select(g => g.Key.Name);

            foreach (var student in activeStudents)
                Console.WriteLine(student);

            Console.WriteLine("\nMost Popular Course:");

            var mostPopular = enrollments
                .GroupBy(e => e.Course)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            if (mostPopular != null)
                Console.WriteLine(mostPopular.Key.Title);

            Console.WriteLine("\nAverage Course Rating:");

            var avgRating = courseRepo.GetAll().Average(c => c.Rating);
            Console.WriteLine(avgRating);

            Console.WriteLine("\nInstructor with Highest Enrollments:");

            var instructorEnrollments = enrollments
                .GroupBy(e => e.Instructor)
                .OrderByDescending(g => g.Count())
                .Select(g => new
                {
                    InstructorName = g.Key.Name,
                    TotalEnrollments = g.Count()
                });

            foreach (var instructor in instructorEnrollments)
                Console.WriteLine($"{instructor.InstructorName} - {instructor.TotalEnrollments}");

            Console.WriteLine("\nLINQ Join Result:");

            var joinResult =
                from e in enrollments
                join s in studentRepo.GetAll()
                on e.Student.Id equals s.Id
                join c in courseRepo.GetAll()
                on e.Course.Id equals c.Id
                select new
                {
                    StudentName = s.Name,
                    CourseTitle = c.Title
                };

            foreach (var item in joinResult)
                Console.WriteLine($"{item.StudentName} enrolled in {item.CourseTitle}");

            Console.WriteLine("\nCourses Sorted By Rating:");

            var sortedCourses = courseRepo.GetAll().ToList();
            sortedCourses.Sort();

            foreach (var course in sortedCourses)
                Console.WriteLine($"{course.Title} - {course.Rating}");
        }
    }
}
