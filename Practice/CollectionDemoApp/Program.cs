using System;
using System.Collections;
using System.Collection.Generic;
internal class Program
{
    private static void Main(string[] args)
    {

        List<string> empName = new List<string>

        Employee employee


        Employee employee2 = new Employee()
        {
            Id=20,
            Name="Ramesh"
        };
        List<Employee> employees = new List<Employee>();
        employee.Add(employee)

        Dictionary<int,string> directory = new Dictionary<int, string>();
        dictionary.Add(100,"Rajeshhh");
        dictionary.Add(100,"Sureshhh");

        foreach(keyValuePair<int,string> key in dictionary)
        {
            Console.WriteLine($"Key is {key.key} Value is {key.Value}");
        }
        SortedList<string,string>pairs=new SortedList

        pairs.Add("100","Rajesh");
        pairs.Add("200","Ramesh");
        pairs.Add("300","Rakesh");
        Console.WriteLine("\n\n\nGeneric Sorted List");
        foreach




        // Hashtable hashtable=new Hashtable();
        // hashtable.Add(100,"Rajesh");
        // hashtable.Add(200,"Suresh");
        // hashtable.Add(400,"Harsh");
        // hashtable.Add(500,"Vivek");
        // ICollection key=hashtable.Keys;
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection value=hashtable.Values;
        // foreach(var v in value)
        // {
        //     Console.WriteLine(v);
        // }
    
        // foreach(var key1 in key)
        // {
        //     Console.WriteLine(key1+" "+ hashtable[key1]);
        // }

        // if (hashtable.ContainsKey(200))
        // {
        //     Console.WriteLine("found 200 with value: "+hashtable[200]);
        // }
        // else
        // {
        //     Console.WriteLine("Key not found");
        // }
        
        //============================sorted list================================
        // SortedList list=new SortedList();
        // list.Add(100,"Rajesh");
        // list.Add(200,"Suresh");
        // list.Add(400,"Harsh");
        // list.Add(500,"Vivek");
        // ICollection key=list.Keys;
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection value=list.Values;
        // foreach(var v in value)
        // {
        //     Console.WriteLine(v);
        // }
    
        // foreach(var key1 in key)
        // {
        //     Console.WriteLine(key1+" "+ list[key1]);
        // }
        // Console.WriteLine(list.IndexOfKey(500)+" "+list.IndexOfValue("Vivek"));
        // // list.Clear();
        // int count=list.Count;
        // Console.WriteLine(count);

        //======================Stack=====================================
        // Stack stack=new Stack();
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('F');
        // stack.Push('G');
        // stack.Push('J');
        // foreach(var item in stack)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("Element at Top: "+stack.Peek());
        // stack.Pop();

        // if (stack.Contains('F'))
        // {
        //     Console.WriteLine("F Found");
        // }
        // else
        // {
        //     Console.WriteLine("Not found");
        // }
       ///============queue==========================
        // Queue queue=new Queue();
        // queue.Enqueue('A');
        // queue.Enqueue('G');
        // queue.Enqueue('K');
        // queue.Enqueue('M');
        // foreach(var item in queue)
        // {
        //     Console.WriteLine(item);
        // }
    //   queue.Dequeue();

    //boxing and unboxing
    // object o;
    // int i=10;
    // o=i;

    // string str;
    // int j=(int)o;//unboxing

    // ArrayList list=new ArrayList();
    // list.Add(10);
    // list.Add(false);
    // list.Add(2.44f);
    //unboxing
    // int k=(int)list[10];
    // var v=list[1];
    // bool t=(bool)v;
    // var x=0;
    // x="Hello"; //error
    // dynamic d=10;
    // d="hello";


    AddClass addClass=new AddClass();
    int sumInt=addClass.AddInt(30,20);
    Console.WriteLine($"Sum of integer is {sumInt}");

    float sumfloat=addClass.AddFloat(30.15f,3.77f);
    Console.WriteLine($"Sum of float is {sumfloat}");

    string sumstring=addClass.AddString("Harsh","Singh");
    Console.WriteLine($"Sum of string is {sumstring}");

    AddGenericClass<int> addInteger=new AddGenericClass<int>(20,30);

    }
}