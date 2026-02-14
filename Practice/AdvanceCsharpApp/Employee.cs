using System;
public class Employee
{
    protected int Eid, Eage;
    protected string Ename, Eaddress;
    protected float Salary;
    public virtual void GetEmployeeData()
    {
        Console.WriteLine("ENTER EMPLOYEE DETAILS:");
        Console.WriteLine("ENTER THE ID");
        Eid = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE NAME");
        Ename = Console.ReadLine();
        Console.WriteLine("Enter the Age : ");
        Eage=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the salary : ");
        salary=float.Parse(Console.ReadLine());
    }
    public virtual void DisplayEmployeeData()
    {
        Console.WriteLine("EMPLOYEE DETAILS ARE:");
        Console.WriteLine("EMPLOYEE ID IS:"+Eid);
        Console.WriteLine("EMPLOYEE NAME IS:"+Ename);
        Console.WriteLine("EMPLOYEE ADDRESS IS:"+Eaddress);
        
        
    }
}