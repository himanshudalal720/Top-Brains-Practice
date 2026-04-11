using System;
namespace CalculatorApp
{
    public delegate int CalculatorDelegate(int num1,int num2);
    class Program
    {
        pulic static void Main(string[] args)
        {
            Calculator clculator = new Calculator();

            CalculatorDelegate calcutAdd = new CalculatorDelegate(calculator.Add);
            CalculatorDelegate calcutSubtract = new CalculatorDelegate(calculator.Subtract);
            CalculatorDelegate calcutMultiply = new CalculatorDelegate(calculator.Multiply);
            CalculatorDelegate calcutDivide = new CalculatorDelegate(calculator.Divide);
            CalculatorDelegate calcutMulticast;

            int sum=calcutAdd(30,20);
            Console.WriteLine("Sum of the Two Number is (0)",sum);

            int subtract=calcutSubtract(30,20);
            Console.WriteLine("Subtract of Two Number is (0)",subtract);

            int multiply=calcutMultiply(30,20);
            Console.WriteLine("Product of Two Number is (0)",multiply);

            int divide=calcutDivide(30,20);
            Console.WriteLine("Divide of Two Number is (0)",divide);

            calcultMulticast=calcutAdd;
            calcultMulticast+=calcutSubtract;
            calcultMulticast-=calcutMultiply;
            calcultMulticast+=calcutDivide;

            Console.WriteLine("Called Multicast Delegate (0)",CalcutMulticast(30,3));



        }

    }
}