using System;

class Employee
{
    private int EmpId=0;
    private string Name = string.Empty;
    string Department = string.Empty;
    private float Salary=0.0f;
    bool Status = true;    
public void AcceptDetails()
{
    Console.WriteLine("Enter Employee Details");
    Console.WriteLine("Enter Employee Id: ");
    EmpId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Name: ");
    Name = Console.ReadLine();
    Console.WriteLine("Enter Employee Department");
    Department = Console.ReadLine();
    Console.WriteLine("Enter Employee Salary: ");
    Salary = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Enter Employee status on project : True or False");
    Status = Convert.ToBoolean(Console.ReadLine());
}
public void DisplayDetails(){
    Console.WriteLine($"Employee id: {EmpId}");
    Console.WriteLine($"Employee name: {Name}");
    Console.WriteLine($"Employee Department: {Department}");
    Console.WriteLine($"Employee Salary: {Salary}");
    Console.WriteLine($"Employee Status: {Status}");

}
}