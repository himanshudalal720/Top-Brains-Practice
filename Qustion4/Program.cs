using System;
using System.Collections.Generic;
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int marksCompare = y.Marks.CompareTo(x.Marks);
        if (marksCompare != 0)
            return marksCompare;

        return x.Age.CompareTo(y.Age);
    }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        
    }
}
