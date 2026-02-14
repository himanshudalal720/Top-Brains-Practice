using System;

class Calculator
{
    private int number1;
    public int Number2;

    get
    {
        return number1;
    }
    set
    {
        number1=value;
    }

    public int Number1 {get;set;}
    public int Number2 {get;set;}

    public int Result {get;set;}

    public void Add()
    public void Calculator()//Deffault Constructor
    {
        Number1 = 0;
        Number2 = 0;
        Result=0;
    }
    public Calculatoir(int Number1,intNumber2)
    {
        this.Number1=Number1;
        this.Number2=Number2;
    }






    public int Add(int number1, int number2)
    {
        Number1-number1;
        Number2=number2;

        Result=number1+number2;

        return Result;

    }

    public int Subtract()
    {
        number1=30;
        number2=20;
        Result=number1-number2;

        return result;
    }

    public void Multiply(int number1,int number2)
    {
        Number1=number1;
        Number2=number2;
        Result=Number1*Number2;

        Console.WriteLine($"Product of two number {Number1} and {number2} is {Result} ");
    }

    public void Divide()
    {
        Result=Number1+Number2;
        Console.WriteLine($"Devisions of two numbers{Number1} and {Number2} is {Result}");
    }


    public void Divide()
    {
        int num1=Number1;
        int num2=Number2;
        Result= num1/num2;
        Console.WriteLine($"Division of the Two Numbers{num1} and {num2} is {Result}");

    }
    public void 

    
}