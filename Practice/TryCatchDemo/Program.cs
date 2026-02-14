using System;
class Program
{
    public static void Main(string[] args)
    {

        try
        {
            throw new MyException("Rajesh");
        }
        catch {Exception e}
        {
            Console.WriteLine("Exception caught here "+ e.ToString());
        }
        Console.WriteLine("LAST STATEMENT");





        int num1=0;
        int num2=0;
        int result=0;

        int[] arr=new int[6][10,20,30,40,50,60];

        // for(int i=0;i<6;i++)
        // {
        //     Console.WriteLine(arr[i]);
        // }

        // Console.WriteLine("Enter first number :");
        // num1 = Convert.ToInt32(COnsole.ReadLine());
        // Console.WriteLine("Enter first number :");
        // num2 = Convert.ToInt32(COnsole.ReadLine());

        try{
            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32(COnsole.ReadLine());

            Console.WriteLine("Enter first number :");
            num2 = Convert.ToInt32(COnsole.ReadLine());
            result= num1/num2;

            for(int i=0;i<9;i++)
            {
                Console.WriteLine(arr[i]);
            }


            try {
                Console.WriteLine(arr[i]);
            }  
        }

        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Index is out of range {ex.Message}");
        }

        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Cannot Divide Number by Zero {ex.Message.ToString()}");
        }

        catch(FormatException ex)
        {
            Console.WriteLine($"Enter Number only {ex.Message}");
        }

        catch(Exceptional ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }

        finally
        {
            Console.WriteLine($"Division of two numbers{num1} and {num2} is {result}");
        }

        Console.WriteLine($"Division of two numbers{num1} and {num2} is {result}");





    }
}