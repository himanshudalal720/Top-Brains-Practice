using System;
class MyCollection : IEnumerable
{
    int[] data = [1,2,3];
    public IEnumerator GetEnumerator()
    {
        return data.GetEnumerator();
    }
}
class Program
{
    MyCollection obj = new MyCollection();
    foreach (int i in obj)
    {
        Console.WriteLine(i);
    }
}