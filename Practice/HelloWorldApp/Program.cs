using System;
namespace HelloWorldApp{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1. program to print a welcome message
            // Console.WriteLine("Welcome");

            // 2. program to read number user and display it
            // int number; 
            // Console.WriteLine("Enter a number");
            // number=Convert.ToInt32(Console.ReadLine()); 
            // Console.WriteLine($"number is {number}"); 

            // 3. program to read a floating point number from user
            // float fit=0.0f;
            // Console.WriteLine("Enter a floating Number");
            // fit=Convert.ToSingle(Console.ReadLine()); 
            // Console.WriteLine($"Floating number is {fit}");

            // 4.program to read a string from user and display it
            // string name="";
            // Console.WriteLine("Enter your name");
            // name=Console.ReadLine();
            // Console.WriteLine($"Your name is {name}"); 

            // 5. Program to perform all arithmetic operations
            // int number1;
            // int number2;
            // int result;
            // Console.WriteLine("Enter first number");
            // number1=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // number2=Convert.ToInt32(Console.ReadLine());
            // // result=number1+number2;
            // // Console.WriteLine($"Sum of two numbers {number1} and {number2} is {result}");
            // // result=number1-number2;
            // // Console.WriteLine($"Difference of two numbers {number1} and {number2} is {result}");
            // // result=number1*number2;
            // // Console.WriteLine($"Product of two numbers {number1} and {number2} is {result}");
            // result=number1/number2;
            // Console.WriteLine($"Division of two numbers {number1} and {number2} is {result}");


            // 6. Program to find the area of circle
            // double r;
            // double area;
            // Console.WriteLine("Enter radius of circle");
            // r=Convert.ToDouble(Console.ReadLine());
            // area=3.14*r*r;
            // Console.WriteLine($"Area of circle with radius {r} is {area}");

            // 7. Program to find whather the given number is even or odd
            // int num;
            // Console.WriteLine("Enter  a number");
            // num=Convert.ToInt32(Console.ReadLine());
            // if(num%2==0)
            // {
            //     Console.WriteLine($"Number {num} is Even");
            // }
            // else
            // {
            //     Console.WriteLine($"Number {num} is Odd");
            // }

            // 8. Program to find the greatest of two numbers
            // int num1;
            // int num2;
            // Console.WriteLine("Enter first number");
            // num1=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // num2=Convert.ToInt32(Console.ReadLine());
            // if(num1>num2)
            // {
            //     Console.WriteLine($"Number {num1} is greater than {num2}");
            // }
            // else if(num2>num1)
            // {
            //     Console.WriteLine($"Number {num2} is greater than {num1}");
            // }
            // else
            // {
            //     Console.WriteLine("Both numbers are equal");
            // }

            // 9. Program to find wheather a given number is positive, negative or zero
            // int number;
            // Console.WriteLine("Enter a number");
            // number=Convert.ToInt32(Console.ReadLine());
            // if(number>0)
            // {
            //     Console.WriteLine($"Number {number} is positive");
            // }
            // else if(number<0)
            // {
            //     Console.WriteLine($"Number {number} is negative");
            // }
            // else
            // {
            //     Console.WriteLine("Number is zero");
            // }

            // 10. Program to find the greatest of three numbers using nested if
            // int num1;
            // int num2;
            // int num3;
            // Console.WriteLine("Enter first number");
            // num1=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // num2=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter third number");
            // num3=Convert.ToInt32(Console.ReadLine());
            // if(num1>=num2)
            // {
            //     if(num1>=num3)
            //     {
            //         Console.WriteLine($"Number {num1} is greatest");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Number {num3} is greatest");
            //     }
            // }
            // else
            // {
            //     if(num2>=num3)
            //     {
            //         Console.WriteLine($"Number {num2} is greatest");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Number {num3} is greatest");
            //     }
            // }


            // 11. Program to find the greatest of 3 numbers using conditional operator
            // int num1;
            // int num2;
            // int num3;
            // Console.WriteLine("Enter first number");
            // num1=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter second number");
            // num2=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter third number");
            // num3=Convert.ToInt32(Console.ReadLine());
            // int greatest = (num1 >= num2) ? ( (num1 >= num3) ? num1 : num3 ) : ( (num2 >= num3) ? num2 : num3 );
            // Console.WriteLine($"Greatest number is {greatest}");


            // 12. Program to read student num,name,mark of six subject and calculate total and average and print result and division
            // int studentNum;
            // string studentName;
            // int mark1;
            // int mark2;
            // int mark3;
            // int mark4;
            // int mark5;
            // int mark6;
            // Console.WriteLine("Enter Student Number");
            // studentNum=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Student Name");
            // studentName=Console.ReadLine();
            // Console.WriteLine("Enter Mark of Subject 1");
            // mark1=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Mark of Subject 2");
            // mark2=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Mark of Subject 3");
            // mark3=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Mark of Subject 4");
            // mark4=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Mark of Subject 5");
            // mark5=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Mark of Subject 6");
            // mark6=Convert.ToInt32(Console.ReadLine());
            // int total=mark1+mark2+mark3+mark4+mark5+mark6;
            // double average=total/6.0;
            // Console.WriteLine($"Student Number: {studentNum}");
            // Console.WriteLine($"Student Name: {studentName}");
            // Console.WriteLine($"Total Marks: {total}");
            // Console.WriteLine($"Average Marks: {average}");

            // 13. to read eno,ename,basic salary and calculate pf,hra,da,net salary and gross salary and print eno,ename,basic salary,gross salary and net salary
            // int eno;
            // string ename;
            // double basicSalary;
            // double pf;
            // double hra;
            // double da;
            // double netSalary;
            // double grossSalary;
            // Console.WriteLine("Write Employee Number");
            // eno = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Write Employee Name");
            // ename = Console.ReadLine();
            // Console.WriteLine("Write Basic Salary");
            // basicSalary = Convert.ToDouble(Console.ReadLine());
            // pf = basicSalary*0.12;
            // hra = basicSalary*0.20;
            // da = basicSalary*0.15;
            // grossSalary=pf+hra+da+basicSalary;
            // netSalary=grossSalary-pf;

            // Console.WriteLine($"Employee Number : {eno}");
            // Console.WriteLine($"Employee Name : {ename}");
            // Console.WriteLine($"Basic Salary is : {basicSalary}");
            // Console.WriteLine($"Gross Salary is : {grossSalary}");
            // Console.WRiteLine($"Net Salary is : {netSalary}");
            

            


            // 17. program to print numbers from 1 to n(user input) using while loop

            // int n;
            // int i=1;
            // Console.WriteLine("Enter value of n");
            // n=Convert.ToInt32(Console.ReadLine());
            // while(i<=n)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            // 18. program to print even numbers from 1 to n(user input)
            // int n;
            // int i=0;
            // Console.WriteLine("Enter value of n :");
            // n=Convert.ToInt32(Console.ReadLine());
            // while(i<=n)
            // {
            //     if(i%2==0)
            //     {
            //         Console.WriteLine(i);
            //     }
            //     i++;
            // }

            // 19. program to find the sum  of numbers from 1 to n(user input) using while loop
            // int n;
            // int i=0;
            // int sum=0;
            // Console.WriteLine("Enter value of n");
            // n=Convert.ToInt32(Console.ReadLine());
            // while(i<=n)
            // {
            //     sum=i+sum;
            //     i++;
            // }
            // Console.WriteLine($"Sum of n number is {sum}");

            // 20. program to print multiplication table of given number
            // int n;
            // int i=1;
            // Console.WriteLine("Enter value of n");
            // n=Convert.ToInt32(Console.ReadLine());
            // while(i<=10)
            // {
                
            //     Console.WriteLine(i*n);
            //     i++;
            // }

            // 21 program to calculate the power of a given number
            // int baseNum;
            // int power;
            // int i = 1;
            // long result = 1;

            // Console.WriteLine("Enter base number");
            // baseNum = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter power");
            // power = Convert.ToInt32(Console.ReadLine());

            // while (i <= power)
            // {
            // result = result * baseNum;
            // i++;
            // }

            // Console.WriteLine($"Result = {result}");

            // program that calculates the factorial of a non-negative integer entered by the user.
            // The program should continuously prompt the user for input until they enter the letter q to quit.
//         string input;
//         int num;
//         long fact;

//         while (true)
//         {
//         Console.WriteLine("Enter a non-negative integer (or q to quit)");
//         input = Console.ReadLine();

//         if (input == "q")
//         {
//         break;
//         }

//         num = Convert.ToInt32(input);

//         if (num < 0)
//         {
//         Console.WriteLine("Invalid input! Please enter a non-negative integer");
//         }
//         else
//         {
//             fact = 1;
//             int i = 1;
//         while (i <= num)
//         {
//             fact = fact * i;
//             i++;
//         }
//         Console.WriteLine($"The factorial of {num} is {fact}");
//     }
// }


// program to find wheather the number is prime number or not

        int n;
        int i = 2;
        int flag = 1;

        Console.WriteLine("Enter a number");
        n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
        {
            flag = 0;
        }
        else
        {
            while (i <= n / 2)
            {
                if (n % i == 0)
                {
                    flag = 0;
                    break;
                }
                i++;
            }
        }

        if (flag == 1)
        {
            Console.WriteLine("Prime Number");
        }
        else
        {
            Console.WriteLine("Not a Prime Number");
        }

            
        



            





























            // Console.WriteLine("Hello World");
            // Console.ReadLine();
            //Write a program to print number from 1 to 10
            // int i=0;

            // while(i<=10)
            // {
            //     Console.WriteLine($"Number is {i}");
            //     i++;
            // }
            
            // int i=0;
            // do{
            //     Console.WriteLine($"Number is {i}");
            //     i++;
            // }
            // while(i<10);

            // int i=10;
            // do{
            //     Console.WriteLine($"Number is {i}");
            //     i--;
            // }
            // while(i>0);

            // for (int i=0; i <=10; i++)
            // {
            //     Console.WriteLine($"Number is {i}");
            // }

            // for (int i=10; i >=1; i--)
            // {
            //     Console.WriteLine($"Number is {i}");
            // }

            // int[] arr=[10,20,30,40,50,60,70,80,90,100];

            // int j=0;
            // while(j<arr.Length)
            // {
            //     Console.WriteLine($"While array index at {j} is {arr[j]}");
            //     j++;
            // }

            // for(int i=0; i<arr.Length; i++)
            // {
            //     Console.WriteLine($"Array index at {i} is {arr[i]}");
            // }


            // foreach(int num in arr)
            // {
            //     Console.WriteLine(i);
            // }



        //     Calculator calc = new Calculator();
        //     int choice=0;
        //     Console.WriteLine("1 For Addition");
        //     Console.WriteLine("2 For Subtraction");
        //     Console.WriteLine("3 For Multiplication");
        //     Console.WriteLine("4 For Division");
        //     Console.WriteLine("5 For Modulus");
        //     Console.WriteLine("6 For Exit");
        //     Console.WriteLine("Select option form Following");
        //     choice = Convert.ToInt32(Console.ReadLine());
        //     switch(choice)
        //     {
        //         case 1:
        //             calc.Add();
        //             break;
        //         case 2:
        //             calc.Subtract();
        //             break;
        //         case 3:
        //             calc.Multiply();
        //             break;
        //         case 4:
        //             calc.Divide();
        //             break;
        //         case 5:
        //             calc.Modulus();
        //             break;
        //         case 6:
        //             Console.WriteLine("Exiting...");
        //             break;
        //         default:
        //             Console.WriteLine("Invalid choice");
        //             break;
        //     }
        // }
    }
}
}
