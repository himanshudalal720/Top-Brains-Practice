using System;

class Bank
{
    int a = 20;
    int b = 10;

    public Calculator()
    {
    }

    public void Add(int number1, int number2)
    {
        int result = number1 + number2;
        Console.WriteLine("Addition Result : " + result);
    }

    public void Subtract()
    {
        int result = a - b;
        Console.WriteLine("Subtraction Result : " + result);
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public void Divide()
    {
        int result = a / b;
        Console.WriteLine("Division Result : " + result);
    }
}