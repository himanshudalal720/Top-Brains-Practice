using System;
class Program {
    public static void Main(string[] args)
    {
        string fname, Iname;
        fname = "Rowan";
        Iname = "Atkinson";

        char []letters= {'H', 'e', 'I'. 'l', 'n'};
        string [] sarray = ( "Hello", "From", "Tutorials", "Point");

        string greetings = new string(letters);
        Console.WriteLine("Greetings: {0}", greetings);


        string message = String.Join(" ", sarray);
        Console.WRiteLine("Message: {0}", message);

        DateTime waiting = new DateTime(2012,10,10,17,58,1);
        string chat = String Format("Message sent at{0:t} on {0:0}",waiting);
        Console.WriteLine("Message {0}",);

        string str ="This is test";
        if(str.Contains("test")) {
            console.WriteLine("The sequesnce 'test' was found.")
        }

        string str3 = "Last night I dreamt of Sam Pedro";
        Console.WriteLine(str3);
        string substr = str3.Substring(23);
        Console.WriteLine(substr);

        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("\"Hello World\"");
        Console.WriteLine("D:\\Project\\csharp\\Program.cs");
        Console.WriteLine(@"D:\Projects\csharp\\Program.cs");

        var message = @"Hello Alice,
        Good Morning!
        Your file have been saved to this location.
        Thanks.";
        Console.WriteLine(message1);

        var name ="Alice";
        var greeting =String.Format("Hello {0}, {1}!",name, "good morning");
        Console.WriteLine(greeting);

        var name2="Alice";
        var greet ="good morning";
        vr greeting2 = $"Hello {name}, {greet}!";
        Console.WriteLine(greeting);

        var num=12;
        Console.WriteLine($"Square of {num} = {num*num}");

        var text="Hello World";
        var sub_text = text.Substring(6,5);

        Console.WriteLine(sub_text);
        var text3 ="Hello World";
        Console.WriteLine(text3.ToUpper());

        var text4 ="Hello World";
        Console.WriteLine(text4.ToLower());

        var text5 = "   Hello world     ";
        Console.WriteLine(text5.Trim());

        var csv = "Alis,Bob,Chris,Dave,Eric,Freed";
        var names =csv.Split(',');
        for( var i=0;i<name.Length;i++)
        {
            Console.WriteLine(names[i]);
        }
        var greet3 = "Hello Alice. WElcome";
        var index = greet3.IndexOf("el");

        var greet4 = "Hello Alice. Welcome";
        var index4 = gree4.LastIndexOf("el");
        Console.WriteLine(index4)



        //Declare the Jagged Array of four elements;
        int[][] jagged_arr = new int[4][];

        //initialize 


        //Display the array elements:
        For(int n =0;n< jagged_arr,Length; n++) {

            //Print the row number 
            System.Console.Write("Row({0}): ",n);
            for(int k=0;k<jagged_arr[n].Length;k++){
                System.Console.Write("{0}",
                jagged_arr[n][k]);
            }
            Console.WriteLine();
        }
    }
}