using System;

class Program
{
    static void Main(string[] args)
    {


    // Practice Question 1: program to store elements in an array and print it. 
    // int[] arr = new int[10];

    //     Console.WriteLine("Input 10 elements in the array:");
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         Console.WriteLine($"element - {i} : ");
    //         arr[i] = Convert.ToInt32(Console.ReadLine());
    //     }

    //     Console.WriteLine("\nElements in array are: ");
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         Console.WriteLine(arr[i] + " ");
    //     }




        // 2. program to read n number of values in an array and display it in reverse order.

        // Console.Write("Input the number of elements to store in the array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];

        // Console.WriteLine($"Input {n} number of elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine("\nThe values store into the array are:");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }

        // Console.WriteLine("\nThe values store into the array in reverse :");
        // for (int i = n - 1; i >= 0; i--)
        // {
        //     Console.Write(arr[i] + " ");
        // }




        //3. program to find the sum of all elements of the array.

        // Console.WriteLine("Input the number of elements to be stored in the array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];
        // int sum = 0;

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.WriteLine($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        //     sum += arr[i];
        // }

        // Console.WriteLine("\nSum of all elements stored in the array is : " + sum);





        // 4. program to copy the elements one array into another array.  

        // Console.WriteLine("Input the number of elements to be stored in the array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr1 = new int [n];
        // int[] arr2 = new int[n];

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.WriteLine($"element - {i} : ");
        //     arr1[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // for (int i = 0; i < n; i++)
        // {
        //     arr2[i] = arr1[i];
        // }

        // Console.WRiteLine("The array stored in the first array are: ");
        // for (int i = 0; i < n; i++  )
        // {
        //     Console.WriteLine(arr1[i] + " ");

        // }

        // Console.WriteLine("The elements copied into the second array are :")
        // for (int i = 0; i < n; i++)
        // {
        //     Console.WriteLine(arr2[i] + " ");
        // }


        //5. program to count a total number of duplicate elements in an array.
        // Console.Write("Input the number of elements to be stored in the array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];
        // int duplicateCount = 0;

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = i + 1; j < n; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             duplicateCount++;
        //             break; 
        //         }
        //     }
        // }

        // Console.WriteLine("\nTotal number of duplicate elements found in the array is : " + duplicateCount);




        //6. program to print all unique elements in an array.  

        // Console.Write("Input the number of elements to be stored in the array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine("\nThe unique elements found in the array are :");

        // for (int i = 0; i < n; i++)
        // {
        //     bool isUnique = true;

        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i != j && arr[i] == arr[j])
        //         {
        //             isUnique = false;
        //             break;
        //         }
        //     }

        //     if (isUnique)
        //     {
        //         Console.Write(arr[i] + " ");
        //     }
        // }



        //7. program to merge two arrays of same size sorted in ascending order. 

        // Console.Write("Input the number of elements to be stored in the first array : ");
        // int n1 = Convert.ToInt32(Console.ReadLine());

        // int[] arr1 = new int[n1];
        // Console.WriteLine($"Input {n1} elements in the array :");
        // for (int i = 0; i < n1; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr1[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.Write("Input the number of elements to be stored in the second array : ");
        // int n2 = Convert.ToInt32(Console.ReadLine());

        // int[] arr2 = new int[n2];
        // Console.WriteLine($"Input {n2} elements in the array :");
        // for (int i = 0; i < n2; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr2[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // int[] merged = new int[n1 + n2];

        // int i1 = 0, i2 = 0, k = 0;
        // while (i1 < n1 && i2 < n2)
        // {
        //     if (arr1[i1] <= arr2[i2])
        //         merged[k++] = arr1[i1++];
        //     else
        //         merged[k++] = arr2[i2++];
        // }

        // while (i1 < n1)
        //     merged[k++] = arr1[i1++];

        // while (i2 < n2)
        //     merged[k++] = arr2[i2++];

        // Console.WriteLine("\nThe merged array in ascending order is :");
        // for (int i = 0; i < merged.Length; i++)
        // {
        //     Console.Write(merged[i] + " ");
        // }



        //8. program to count the frequency of each element of an array.

//         Console.Write("Input the number of elements to be stored in the array : ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];
//         bool[] visited = new bool[n];

//         Console.WriteLine($"Input {n} elements in the array :");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"element - {i} : ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.WriteLine("\nFrequency of all elements of array :");

//         for (int i = 0; i < n; i++)
//         {
//             if (visited[i])
//                 continue;

//             int count = 1;
//             for (int j = i + 1; j < n; j++)
//             {
//                 if (arr[i] == arr[j])
//                 {
//                     count++;
//                     visited[j] = true;
//                 }
//             }

//             Console.WriteLine($"{arr[i]} occurs {count} times");
//             Console.WriteLine
//         }

        //9. program to find maximum and minimum element in an array.

        // Console.Write("Input the number of elements to be stored in the array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // int max = arr[0];
        // int min = arr[0];

        // for (int i = 1; i < n; i++)
        // {
        //     if (arr[i] > max)
        //         max = arr[i];

        //     if (arr[i] < min)
        //         min = arr[i];
        // }

        // Console.WriteLine("\nMaximum element is : " + max);
        // Console.WriteLine("Minimum element is : " + min);



        //10. program to separate odd and even integers in separate arrays.

    //     Console.Write("Input the number of elements to be stored in the array : ");
    //     int n = Convert.ToInt32(Console.ReadLine());

    //     int[] arr = new int[n];
    //     int[] even = new int[n];
    //     int[] odd = new int[n];

    //     int evenCount = 0, oddCount = 0;

    //     Console.WriteLine($"Input {n} elements in the array :");
    //     for (int i = 0; i < n; i++)
    //     {
    //         Console.Write($"element - {i} : ");
    //         arr[i] = Convert.ToInt32(Console.ReadLine());
    //     }

    //     for (int i = 0; i < n; i++)
    //     {
    //         if (arr[i] % 2 == 0)
    //             even[evenCount++] = arr[i];
    //         else
    //             odd[oddCount++] = arr[i];
    //     }

    //     Console.WriteLine("\nThe Even elements are:");
    //     for (int i = 0; i < evenCount; i++)
    //     {
    //         Console.Write(even[i] + " ");
    //     }

    //     Console.WriteLine("\nThe Odd elements are :");
    //     for (int i = 0; i < oddCount; i++)
    //     {
    //         Console.Write(odd[i] + " ");
    //     }
    // }

    // 11. program to sort elements of array in ascending order.     

        // Console.Write("Input the size of array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // for (int i = 0; i < n - 1; i++)
        // {
        //     for (int j = i + 1; j < n; j++)
        //     {
        //         if (arr[i] > arr[j])
        //         {
        //             int temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }
        // }

        // Console.WriteLine("\nElements of array in sorted ascending order:");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }          



        //12. program to sort elements of the array in descending order.

    //     Console.Write("Input the size of array : ");
    //     int n = Convert.ToInt32(Console.ReadLine());

    //     int[] arr = new int[n];

    //     Console.WriteLine($"Input {n} elements in the array :");
    //     for (int i = 0; i < n; i++)
    //     {
    //         Console.Write($"element - {i} : ");
    //         arr[i] = Convert.ToInt32(Console.ReadLine());
    //     }

    //     for (int i = 0; i < n - 1; i++)
    //     {
    //         for (int j = i + 1; j < n; j++)
    //         {
    //             if (arr[i] < arr[j])
    //             {
    //                 int temp = arr[i];
    //                 arr[i] = arr[j];
    //                 arr[j] = temp;
    //             }
    //         }
    //     }

    //     Console.WriteLine("\nElements of the array in sorted descending order:");
    //     for (int i = 0; i < n; i++)
    //     {
    //         Console.Write(arr[i] + " ");
    //     }
    // }



    // 13. program to insert New value in the array (sorted list )

        // Console.Write("Input the size of array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];

        // Console.WriteLine($"Input {n} elements in the array in ascending order:");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.Write("Input the value to be inserted : ");
        // int value = Convert.ToInt32(Console.ReadLine());




        // 14. program to insert New value in the array (unsorted list ).

        // Console.Write("Input the size of array : ");
        // int n = Convert.ToInt32(Console.ReadLine());

        // int[] arr = new int[n];

        // Console.WriteLine($"Input {n} elements in the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"element - {i} : ");
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.Write("Input the value to be inserted : ");
        // int value = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Input the Position, where the value to be inserted : ");
        // int pos = Convert.ToInt32(Console.ReadLine());

        // int[] newArr = new int[n + 1];

        // for (int i = 0; i < pos - 1; i++)
        // {
        //     newArr[i] = arr[i];
        // }

        // newArr[pos - 1] = value;

        // for (int i = pos; i <= n; i++)
        // {
        //     newArr[i] = arr[i - 1];
        // }

        // Console.WriteLine("\nThe current list of the array :");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }

        // Console.WriteLine("\nAfter Insert the element the new list is :");
        // for (int i = 0; i < newArr.Length; i++)
        // {
        //     Console.Write(newArr[i] + " ");
        // }



        //15. program to delete an element at desired position from an array.

        Console.Write("Input the size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Input {n} elements in the array :");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Input the position where to delete: ");
        int pos = Convert.ToInt32(Console.ReadLine());

        int[] newArr = new int[n - 1];

        for (int i = 0, j = 0; i < n; i++)
        {
            if (i == pos - 1)
                continue;

            newArr[j++] = arr[i];
        }

        Console.WriteLine("\nThe new list is : ");
        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write(newArr[i] + " ");
        }
    }
} 