using System;

class Program
{
    static void Main(string[] args)
    {
        Student stu = new Student();

        Console.WriteLine("Default Student:");
        Console.WriteLine($"Name: {stu.Name}");
        Console.WriteLine($"Age: {stu.Age}");
        Console.WriteLine($"Grade: {stu.Grade}");

        Console.WriteLine("Enter Student Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Student Age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Student Grade:");
        string grade = Console.ReadLine();

        Student newStudent = new Student(name, age, grade);

        Console.WriteLine("New Student:");
        Console.WriteLine($"Name: {newStudent.Name}");
        Console.WriteLine($"Age: {newStudent.Age}");
        Console.WriteLine($"Grade: {newStudent.Grade}");


        Console.WriteLine("New Student: ");
        console.WriteLine($"Name: {newStudent.Name}");
        Console.WriteLine($"Age: {newStudent.Age}");
        Console.WriteLine($"Grade: {newStudent.Grade}"); 

    }
}
