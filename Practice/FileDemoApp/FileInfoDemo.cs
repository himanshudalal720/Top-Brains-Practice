using System;
Class FileInfoDemo
{
    public static void Main()
    {
        // string path = @"MyTestFile.txt";
        // FileInfo f1 =new FileInfo(path);
        // File.Create(path);
        // {
        //     Console.WriteLine("File has been created");
        // }

        // FileInfo fi = new FileInfo(@"MyTextFileCreatedText2");
        // StreamWriter str = fi.CreateText();
        // str.WriteLine("hello");
        // Console.WriteLine("File has been created with text");
        // str.Close();




        // string path1 = @"MyTextFile7.txt";
        // string path2 = @"NewFile.txt";
        // FileInfo fi1 = new FileInfo(path);
        // FileInfo fi2 = new FileInfo(path2);
        // fi1.CopyTo(path2);
        // Console.WriteLine($"{path1} was copy to {path2}");




        // string path1 = @"MyTextFile7.txt";
        // string path2 = @"NewFile.txt";
        // FileInfo fi1 = new FileInfo(path1);
        // FileInfo fi2 = new FileInfo(path2);
        // fi1.MoveTo(path2);
        // Console.WriteLine("{0} was copy to {1}", path1, path2);


        // FileInfo f13 = new FileInfo(@"Data1/newFile1.txt");
        // StreamWriter sw13 = f13.AppendText();
        // sw13.WriteLine("this");
        // sw13.WriteLine("this11111111");
        // sw13.WriteLine("thisss11111123r31e24");
        // Console.WriteLine("File has been appended");
        // sw13.Close();

        // FileInfo fi = new FileInfo(@"Data2/newFile1.txt");
        // StreamReader sr14 = f14.OpenText();
        // string s = " ";
        // while ((s = sr.ReadLine())!= null)
        // {
        //     Console.WriteLine(s);

        // }



        FileInfo fi5 = new FileInfo(@"Data2/newFile1.txt");
        Console.WriteLine($"File name is {0} ",f1.Name);
        Console.WriteLine($"File creation time is {0}",fi5.CreationTime,ToLongTimeString());
        Console.WriteLine($"File LAstacessTime is {0} ",fi5.LastAcessTime.ToLongDateString());
        Console.WriteLine($"File length is {0} ",f15.Length.ToString());
        Console.WriteLine($"File extension is {0} ",fi5.Extension());
        Console.WriteLine($"File exist is {0} ",fi5.Exists);





    }
}

class Student
{
    int rollNo;
    string Name;
    public Student(int rollNo)
}
 