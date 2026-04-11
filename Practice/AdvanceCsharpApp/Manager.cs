using System;
Class MAnager : Employee
{
    double Bonus, CA;
    public override void GetEmployeeData()
    {
        Console.WriteLine("ENTER MANAGER DETAILS:");
        Console.WriteLine("ENTER THE ID");
        Eid = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE NAME");
        Ename = Console.ReadLine();
        Console.WriteLine("ENTER THE BONUS");
        Bonus = double.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE CA");
        CA = Convert.ToDouble(Console.ReadLine());
    }
    public override void DisplayEmployeeData()
        {
            Console.WriteLine("MANAGER DETAILS ARE:");
            Console.WriteLine("EMPLOYEE ID IS: " + Eid);
            Console.WriteLine("EMPLOYEE NAME IS: " + Ename);
            Console.WriteLine("MANAGER BONUS IS: " + Bonus);
            Console.WriteLine("MANAGER CA IS : " + CA);
        }

}