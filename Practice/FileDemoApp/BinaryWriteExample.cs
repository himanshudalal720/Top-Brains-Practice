using System;
Class BinaryWeiteExample
{
    static void Main()
    {
        using (FileStream fs = new FileStream(filePath,FileMode.Create))
        ising (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);
            writer.Write("Ravi");
            writer.Write(45000.75);
            writer.Write(true);
        }
        Console.WriteLine("Binary files written successfully");
    }
}