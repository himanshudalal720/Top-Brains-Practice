using System;
using System.Collections.Generic;
using System.Linq;

// Base constraints
public interface IStudent
{
    int StudentId { get; }
    string Name { get; }
    int Semester { get; }
}

public interface ICourse
{
    string CourseCode { get; }
    string Title { get; }
    int MaxCapacity { get; }
    int Credits { get; }
}

// 1. Generic enrollment system
public class EnrollmentSystem<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<TCourse, List<TStudent>> _enrollments = new();
    
    // TODO: Enroll student with constraints
    public bool EnrollStudent(TStudent student, TCourse course)
    {
        // Rules:
        // - Course not at capacity
        // - Student not already enrolled
        // - Student semester >= course prerequisite (if any)
        // - Return success/failure with reason

        if (student == null || course == null)
        {
            Console.WriteLine("Invalid student or course.");
            return false;
        }

        if (!_enrollments.ContainsKey(course))
            _enrollments[course] = new List<TStudent>();

        var student = _enrollments[course];

        if (students.Count >= course.MaxCapacity)
        {
            Console.WriteLine($"Enrollment failed: {course.Title} is at full capacity.");
            return false;
        }

        if (students.Any(s => s.StudentId == student.StudentId))
        {
            Console.WriteLine($"Enrollment failed: {student.Name} already enrolled.");
            return false;
        }

        // Check prerequisite if LabCourse
        if (course is LabCourse labCourse)
        {
            if (student.Semester < labCourse.RequiredSemester)
            {
                Console.WriteLine($"Enrollment failed: {student.Name} does not meet semester prerequisite.");
                return false;
            }
        }

        students.Add(student);
        Console.WriteLine($"{student.Name} enrolled successfully in {course.Title}");
        return true;
    }
    
    // TODO: Get students for course
    public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
    {
        // Return immutable list
        if (_enrollments.ContainsKey(course))
            return _enrollments[course].AsReadOnly();

        return new List<TStudent>().AsReadOnly();
    }
    
    // TODO: Get courses for student
    public IEnumerable<TCourse> GetStudentCourses(TStudent student)
    {
        // Return courses student is enrolled in
        return _enrollments
            .Where(e => e.Value.Any(s => s.StudentId == student.StudentId))
            .Select(e => e.Key);
    }
    
    // TODO: Calculate student workload
    public int CalculateStudentWorkload(TStudent student)
    {
        // Sum credits of all enrolled courses
        return GetStudentCourses(student).Sum(c => c.Credits);
    }
}

// 2. Specialized implementations
public class EngineeringStudent : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Semester { get; set; }
    public string Specialization { get; set; }
}

public class LabCourse : ICourse
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int MaxCapacity { get; set; }
    public int Credits { get; set; }
    public string LabEquipment { get; set; }
    public int RequiredSemester { get; set; } // Prerequisite
}

// 3. Generic gradebook
public class GradeBook<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<(TStudent, TCourse), double> _grades = new();
    private EnrollmentSystem<TStudent, TCourse> _enrollmentSystem;

    public GradeBook(EnrollmentSystem<TStudent, TCourse> enrollmentSystem)
    {
        _enrollmentSystem = enrollmentSystem;
    }
    
    // TODO: Add grade with validation
    public void AddGrade(TStudent student, TCourse course, double grade)
    {
        // Grade must be between 0 and 100
        // Student must be enrolled in course

        if (grade < 0 || grade > 100)
            throw new ArgumentException("Grade must be between 0 and 100.");

        if (!_enrollmentSystem.GetEnrolledStudents(course)
                .Any(s => s.StudentId == student.StudentId))
            throw new InvalidOperationException("Student not enrolled in course.");

        _grades[(student, course)] = grade;
    }
    
    // TODO: Calculate GPA for student
    public double? CalculateGPA(TStudent student)
    {
        // Weighted by course credits
        // Return null if no grades

        var studentGrades = _grades
            .Where(g => g.Key.Item1.StudentId == student.StudentId)
            .ToList();

        if (!studentGrades.Any())
            return null;

        double totalPoints = 0;
        int totalCredits = 0;

        foreach (var entry in studentGrades)
        {
            var course = entry.Key.Item2;
            totalPoints += entry.Value * course.Credits;
            totalCredits += course.Credits;
        }

        return totalPoints / totalCredits;
    }
    
    // TODO: Find top student in course
    public (TStudent student, double grade)? GetTopStudent(TCourse course)
    {
        // Return student with highest grade

        var courseGrades = _grades
            .Where(g => EqualityComparer<TCourse>.Default.Equals(g.Key.Item2, course))
            .ToList();

        if (!courseGrades.Any())
            return null;

        var top = courseGrades.OrderByDescending(g => g.Value).First();
        return (top.Key.Item1, top.Value);
    }
}

// 4. TEST SCENARIO: Create a simulation
// a) Create 3 EngineeringStudent instances
// b) Create 2 LabCourse instances with prerequisites
// c) Demonstrate:
//    - Successful enrollment
//    - Failed enrollment (capacity, prerequisite)
//    - Grade assignment
//    - GPA calculation
//    - Top student per course

class Program
{
    static void Main()
    {
        var enrollmentSystem = new EnrollmentSystem<EngineeringStudent, LabCourse>();

        var s1 = new EngineeringStudent { StudentId = 1, Name = "Rahul", Semester = 3, Specialization = "AI" };
        var s2 = new EngineeringStudent { StudentId = 2, Name = "Priya", Semester = 2, Specialization = "Cyber" };
        var s3 = new EngineeringStudent { StudentId = 3, Name = "Arjun", Semester = 1, Specialization = "Robotics" };

        var c1 = new LabCourse
        {
            CourseCode = "CS301",
            Title = "Advanced Programming Lab",
            MaxCapacity = 2,
            Credits = 4,
            LabEquipment = "High-End PCs",
            RequiredSemester = 2
        };

        var c2 = new LabCourse
        {
            CourseCode = "CS401",
            Title = "AI Research Lab",
            MaxCapacity = 1,
            Credits = 5,
            LabEquipment = "GPU Servers",
            RequiredSemester = 3
        };

        // Successful enrollments
        enrollmentSystem.EnrollStudent(s1, c1);
        enrollmentSystem.EnrollStudent(s2, c1);

        // Failed due to capacity
        enrollmentSystem.EnrollStudent(s3, c1);

        // Failed due to prerequisite
        enrollmentSystem.EnrollStudent(s2, c2);

        // Successful
        enrollmentSystem.EnrollStudent(s1, c2);

        Console.WriteLine($"\n{s1.Name} Workload: {enrollmentSystem.CalculateStudentWorkload(s1)} credits");

        var gradeBook = new GradeBook<EngineeringStudent, LabCourse>(enrollmentSystem);

        gradeBook.AddGrade(s1, c1, 85);
        gradeBook.AddGrade(s1, c2, 92);
        gradeBook.AddGrade(s2, c1, 78);

        Console.WriteLine($"\n{s1.Name} GPA: {gradeBook.CalculateGPA(s1):F2}");

        var topStudent = gradeBook.GetTopStudent(c1);
        if (topStudent.HasValue)
        {
            Console.WriteLine($"\nTop student in {c1.Title}: {topStudent.Value.student.Name} with {topStudent.Value.grade}");
        }

        Console.ReadKey();
    }
}
