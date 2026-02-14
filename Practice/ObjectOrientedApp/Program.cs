using System;

class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.AcceptDetails();
        employee.DisplayDetails();
        Console.ReadKey();
    }
}