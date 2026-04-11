using System;
class Calculator
{
    int number1;
    int number2;
    int result;
public void Add()
{
    Console.WriteLine("Enter first number");
    number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second numer");
    number2=Convert.ToInt32(Console.ReadLine());
    result=number1+number2;
    Console.WriteLine($"Sum of two number {number1} and {number2} is {result}");    
}
public void Subtract()
{
    Console.WriteLine("Enter first number");
    number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second numer");
    number2=Convert.ToInt32(Console.ReadLine());
    result=number1-number2;
    Console.WriteLine($"Difference of two number {number1} and {number2} is {result}");
    
}
public void Multiply()
{
    Console.WriteLine("Enter first number");
    number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second numer");
    number2=Convert.ToInt32(Console.ReadLine());
    result=number1*number2;
    Console.WriteLine($"Product of two number {number1} and {number2} is {result}");
}
public void Divide()
{
    Console.WriteLine("Enter first number");
    number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second numer");
    number2=Convert.ToInt32(Console.ReadLine());
    result=number1/number2;
    Console.WriteLine($"Division of two number {number1} and {number2} is {result}");
}
public void Modulus()
{
    Console.WriteLine("Enter first number");
    number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second numer");
    number2=Convert.ToInt32(Console.ReadLine());
    result=number1%number2;
    Console.WriteLine($"Modulus of two number {number1} and {number2} is {result}");
}
}