using System;
class Program
{
    public static void Main(string[] args)
    {
        // 44)program to read a string and display it on the screen
        // Console.WriteLine("Write a string: ");
        // string input = Console.ReadLine();
        // Console.WriteLine("Stging is: {0}", input);

        // 45)program to read 10 strings and display them on the screen
        // string[] arr = new string[10];
        // for(int i=0;i<10;i++)
        // {
        //     Console.WriteLine("Write string : {0}", i+1);
        //     arr[i]=Console.ReadLine();
        // }
        // Console.WriteLine("Written Strings are :");
        // for(int i=0;i<10;i++)
        // {
        //     Console.WriteLine(arr[i]);
        // }


        //46a)program to accept 2x2 matrices and display in matrix
        // int[,] matrix = new int[2, 2];

        // Console.WriteLine("Enter elements of 2x2 matrix:");

        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"Element [{i},{j}]: ");
        //         matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // Console.WriteLine("\nMatrix is:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write(matrix[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // } 


        //46b)program to add 2 matrices
        // int[,] m1 = new int[2, 2];
        // int[,] m2 = new int[2, 2];
        // int[,] sum = new int[2, 2];

        // Console.WriteLine("Enter elements of first 2x2 matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"m1[{i},{j}]: ");
        //         m1[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // Console.WriteLine("\nEnter elements of second 2x2 matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"m2[{i},{j}]: ");
        //         m2[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         sum[i, j] = m1[i, j] + m2[i, j];
        //     }
        // }

        // Console.WriteLine("\nSum of matrices:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write(sum[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }


        //47)program to find the largest and smallest element in the array
        // int[] arr = new int[10];

        // Console.WriteLine("Enter 10 elements:");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write($"Element {i + 1}: ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // int largest = arr[0];
        // int smallest = arr[0];

        // for (int i = 1; i < 10; i++)
        // {
        //     if (arr[i] > largest)
        //         largest = arr[i];

        //     if (arr[i] < smallest)
        //         smallest = arr[i];
        // }

        // Console.WriteLine("\nLargest element = " + largest);
        // Console.WriteLine("Smallest element = " + smallest);



        //48) matrix multiplication 2 by 2
        // int[,] m1 = new int[2, 2];
        // int[,] m2 = new int[2, 2];
        // int[,] result = new int[2, 2];

        // Console.WriteLine("Enter elements of first 2x2 matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"m1[{i},{j}]: ");
        //         m1[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // Console.WriteLine("\nEnter elements of second 2x2 matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"m2[{i},{j}]: ");
        //         m2[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         result[i, j] = 0;
        //         for (int k = 0; k < 2; k++)
        //         {
        //             result[i, j] += m1[i, k] * m2[k, j];
        //         }
        //     }
        // }

        // Console.WriteLine("\nResult of matrix multiplication:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write(result[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }



        //49)transpose of a matrix i.e swaping elements between row and column
        // int[,] matrix = new int[2, 2];
        // int[,] transpose = new int[2, 2];

        // Console.WriteLine("Enter elements of 2x2 matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write($"Element [{i},{j}]: ");
        //         matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }

        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         transpose[j, i] = matrix[i, j];
        //     }
        // }

        // Console.WriteLine("\nOriginal Matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write(matrix[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }

        // Console.WriteLine("\nTranspose Matrix:");
        // for (int i = 0; i < 2; i++)
        // {
        //     for (int j = 0; j < 2; j++)
        //     {
        //         Console.Write(transpose[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }



        //50) program to find whether the given matrix is diagonal matrix or not

        // int [,] matrix = new int[3,3];
        // bool isDiagonal = true;

        // Console.WriteLine("Enter elements of 3x3 matrix: ");
        // for(int i=0;i<3;i++)
        // {
        //     for(int j=0;j<3;j++)
        //     {
        //         Console.Write($"Element [{i},{j}]: ");
        //         matrix[i,j]=Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // for(int i=0;i<3;i++)
        // {
        //     for(int j=0;j<3;j++)
        //     {
        //         if(i != j && matrix[i,j] != 0)
        //         {
        //             isDiagonal = false;
        //             break;
        //         }
        //     }
        // }
        // if(isDiagonal){
        // Console.WriteLine("The given matrix is a diagonal matrix");
        // }
        // else
        // {
        //     Console.WriteLine("The given matrix is not a diagonal matrix");
        // }


        //52)program to reverse the contents of a string using string function
        Console.WriteLine("Write a string: ");
        string str=Console.ReadLine();

        char[] ch = str.ToCharArray()
        Array.Reverse(ch);
        string reversed = new string(ch);
        Console.WriteLine("Reversed string : "+ reversed);
        



        //53)program to reverse the contents of a string 

    }
}