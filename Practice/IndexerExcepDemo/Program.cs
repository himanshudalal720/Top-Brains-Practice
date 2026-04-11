using System;
class Program
{
    public static void Main(string[] str)
    {
        Employee emp = new Employee();

        emp[0] = "String 0";
        emp[1] = "String 1";
        emp[2] = "String 2";
        emp[3] = "String 3";
        emp[4] = "String 4";
        for(int i = 0;i<5;i++)
        {
            Console.WriteLine(employee[i]);
        }
        Console.WriteLine("Value at third is {0}",emp[3]);
        Console.WriteLine("Value at String 4 is at Index is {0}",emp["string 4"])
    }
}