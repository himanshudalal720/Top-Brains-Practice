using System;
class AddTwoNumber
{
    public delegate void dg_OddNumber(); //delegate Delegate
    public event dg_OddNumber ev_OddNumber; //Declared Events

    public void Add()
    {
        int result;
        result = 5 + 4;
        Console.WriteLine(result.ToString());
        // Check if result is odd Number then raise event
        if((result % 2 !=0) && (ev_OddNumber != null))
        {
            ev_OddNumber();
        }
    }
}