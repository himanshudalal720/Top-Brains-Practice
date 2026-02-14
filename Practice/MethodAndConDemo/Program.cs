// class Program
// {
//     public static void Main(string[] args)
//     {
//         t number1=10;



//         int subtract

//     }
// }



using System;

class Program
{
    static void Main(string[] args)
    {
        // Create calculator object
        Calculator calc = new Calculator(20, 10);

        Console.WriteLine("Addition: " + calc.Add());
        Console.WriteLine("Subtraction: " + calc.Subtract());
        Console.WriteLine("Multiplication: " + calc.Multiply());
        Console.WriteLine("Division: " + calc.Divide());

        Console.ReadLine();
    }
}
