using System;

class Student
{
    private int rollNo;
    private string name;
    private int m1;
    private int m2;
    private int m3;
    private int m4;
    private int m5;
    private int m6;
    private int total;
    private double average;
    private string grade;

    public int RollNo
    {
        get { return rollNo; }
        set { rollNo = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Mark1 
    {
         get { return m1; }
        set { m1 = value; }
    }
    public int Mark2
    {
        get { return m2; } 
        set { m2 = value; } 
    }
    public int Mark3 
    { get { return m3; }
    set { m3 = value; }
    }
    public int Mark4 
    { get { return m4; }
     set { m4 = value; }
    }
    public int Mark5
    { get { return m5; } 
    set { m5 = value; } 
    }
    public int Mark6 
    { get { return m6; } 
    set { m6 = value; } 
    }

    public void AcceptDetails()
    {
        Console.WriteLine("Enter Student Number:");
        RollNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Student Name:");
        Name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Enter 6 Subject Marks:");
        Mark1 = Convert.ToInt32(Console.ReadLine());
        Mark2 = Convert.ToInt32(Console.ReadLine());
        Mark3 = Convert.ToInt32(Console.ReadLine());
        Mark4 = Convert.ToInt32(Console.ReadLine());
        Mark5 = Convert.ToInt32(Console.ReadLine());
        Mark6 = Convert.ToInt32(Console.ReadLine());
        
    }

    public void Calculate()
    {
        total = m1 + m2 + m3 + m4 + m5 + m6;
        average = total / 6.0;

        if (average >= 90)
            grade = "A";
        else if (average >= 80)
            grade = "B";
        else if (average >= 70)
            grade = "C";
        else if (average >= 60)
            grade = "D";
        else
            grade = "F";
    }

    public void Display()
    {
        Console.WriteLine($"Student Number : {rollNo}");
        Console.WriteLine($"Student Name   : {name}");
        Console.WriteLine($"Total Marks    : {total}");
        Console.WriteLine($"Average Marks  : {average}");
        Console.WriteLine($"Grade          : {grade}");
    }
}
