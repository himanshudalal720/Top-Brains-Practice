using System;
class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine("User Defined exception");
    }
}