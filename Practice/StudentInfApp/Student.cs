using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student()
    {
        Name = "Hellen Doe";
        Age = 21;
        Grade = "A";
    }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}