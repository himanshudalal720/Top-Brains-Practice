using System;
class FileDemo
{
    public void ReadTextData()
    {
        FileStream fileStream = new FileStream(@"c:Data\Test.txt",FileMode.Open,FileAccess.Read);
        StreamReader streamReader = new StreamReader(fileStream);
        streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
        string str = streamReader.ReadLine();

        while(str!= null)
        {
            Console.WriteLine(str);
            str = streamReader.ReadLine();
        }

        Console.ReaLine();
        streamReader.Close();
        fileStream.Close()
    }

    public void 
}