using System;
class Program
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Hello World");
        for(int i = 0;i<sb.Length;i++)
        Console.Write(sb[i]);

        StringBuilder sb = new StringBilder();
        sb.AppendLine("World");
        sb.Append("Hello");
        sb.AppendLine("World");
        sb.AppendLine("Hello Ca");
        Console.Write(Sb);

        stringBuilder sbAmount = new StringBilder("Your total amount is ");

        sbAmount.AppendFormat("{0:C}", 25);

        CultureInfo india = new CultureInfo("en-In");
        sbAmount.AppendFormat(india, "(0:C)",12345678);

        Console.WriteLine(sbAmount);

        StringBuilder sb = new StringBuilder("Hello World");
        sh.Insert(5," ca");
        Console.WriteLine(sb);

        StringBuilder sb = new StringBilder("Hello World",50);
        sb.Remove(6, 6);
        Console.WriteLine(sb);

        Console.ReadKey();




        list.Reverse();

        Console.WriteLine("\n")

        ArrayList list = new  ArrayList();
        Employee employee1 = new Employee()[Id=10,Name="Rajesh"];
        Employee employee2 = new Employee()[Id=10,Name="Suresh"];
        Employee employee3 = new Employee()[Id=10,Name="Ganesh"];
        list.Add(30);
        list.Add(10);
        list.Add(20);
        list.Add(50);
        list.Add(40);

        list.Add(60.45f);
        list.Add(false);

        list,Add(employee1);
        list,Add(employee2);
        list,Add(employee3);

        Console.WriteLine($"Count of Array List is {list.Count}");
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }

        ArrayList list1 = new ArrayList();
        list1.Add(80;);
        list1.Add(70;);
        list1.Add(60;);

        list.AddRange(list1);

        Console.WriteLine("\n\n\n List After Adding Range");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Count of Array List is {list.Count}");


        Console.WriteLine("\n\n\n List After Cleaing Range");
        foreach (var item in list)
        {
            Console.WRiteLine(item);
        }

        if(list.Contains(90))
        {
            Console.WriteLine($"Object 50 is at index no {list.IndexOf(50)}");
        }
        else
        {
            Console.WriteLine($"Object Not Found");
        }

        list.RemoveAt(5);

        Console.WriteLine("\n\n\n List After Removing value at index 5 Range ");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.remove(false);
        Console.WriteLine("\n\n\n List After Removing value false from the list");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.RemoveRange(5,3);
        Console.WriteLine("\n\n\n List After Removing Range from the list ");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n\n\n List Before Sorting the list");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.Sort();
        Console.WriteLine("List After Sorting");
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        list.Reverse();
        Console.WriteLine("\n\n\n Litst After Reversing the List");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Insert(0,90);
        console.WriteLine("\n\n\n List After inserting at 0 index the list");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Insert(3,65);
        console.WriteLine("\n\n\n List After inserting at 0 index the list");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        ArrayList list2 = new ArrayList();
        list2.Add(46);
        list2.Add(44);
        list2.Add(42);
        list.InsertRange(5,list2);
        Console.WriteLine("n\n\n List After insertion range in the list");
        


        

    }
}