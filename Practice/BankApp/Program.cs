using System;

class Program
{
    public static void Main(string[] args)
    {
        Bank ban = new bank();

        ban.Add(15, 5);
        ban.Subtract();

        int mulResult = ban.Multiply(4, 5);
        Console.WriteLine("Multiplication Result : " + mulResult);

        ban.Divide();
    }
}
