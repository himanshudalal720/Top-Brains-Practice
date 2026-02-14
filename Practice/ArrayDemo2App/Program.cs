using System;
public class Program
{
    public static void Main()
    {
        int[] arr = new int{ 50,20,30,10.40,60};

        Console.WriteLine($"Array index of value 60: {Array.IndexOf(arr, 60)}");
        Console.WriteLine($"Array value at index 3: {arr.GetValue(3)}");
        Console.WriteLine($"Array is fixed size: {arr.IsFixedSize}");
        Console.WriteLine($"Array is ReadOnly: {arr.IsReadOnly}");
        Console.WriteLine($"Array's Rank : {arr.Rank}");

        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("Before Sorting");
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }

        Array.Sort(arr);

        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("After Sorting");
        Console.WriteLine("Before Reversing")



        Console.WriteLine("Array before sorting:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Sorting array...");
        Array.Sort(arr);
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Array.Reverse(arr);
        Console.WriteLine("Reversed array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();


        Employee employee1 = new Employee{} { Id = 30, Name = "Gaurav" };
        Employee employee2 = new Employee{} { Id = 40, Name = "Krishna" };
        Employee employee3 = new Employee{} { Id = 20, Name = "Kundan" };
        Employee employee4 = new Employee{} { Id = 60, Name = "Shubham" };
        Employee employee5 = new Employee{} { Id = 10, Name = "Aman" };

        Employee[] employeeList = new Employee[5];
        employeeList[0] = employee1;
        employeeList[1] = employee2;
        employeeList[2] = employee3;
        employeeList[3] = employee4;
        employeeList[4] = employee5;
        Console.WriteLine("Before Sorting");
        
        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }
        Array.Sort(rmployeeList);
        Console.WriteLine("After Sorting");

        foreach (Employee e in employeeList)
        {
            Console.WriteLine(e);
        }






    }
    public Employee ReturnObject()
    {
        Program program = new program();
        Employee employee = new Employee
        {
            Id=90,
            Name="Dinesh Kumar"
        }

    public Employee ReturnObject()
    {
        Employee employee = new Employee
        {
            Id=120,
            Name="Suresh Kumar"
        };

        return employee;

        public void PassArrayObject(Employee[] employee)
        {
            foreach(Employee e in employee)
            {
                Console.WriteLine(e);
            }
        }



        program.PassObject(employee);

        Employee employee6 = program.ReturnObject();
        Console.WriteLine(employee6);

        program.PassArrayObject(employeeList);
    }

}