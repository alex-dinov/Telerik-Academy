/*Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.
*/
using System;

class MaxElement
{
    static void Main()
    {
        Console.Write("Enter lenght of array N:");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        SortAscending(arr);
        PrintArray(arr);

        SortDescending(arr);
        PrintArray(arr);
    }

    static int[] SortDescending(int[] arr)
    {
        SortAscending(arr);
        Array.Reverse(arr);
        return arr;
    }

    static int[] SortAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
           Swap(arr,i,FindMaxElement(arr,i));
        }
        return arr;
    }

    static int FindMaxElement(int[] arr, int startIndex)
    {
        int max = startIndex;
        for (int i = startIndex+1; i < arr.Length; i++)
        {
            if (arr[i] < arr[max] )
            {
                max = i;
            }
        }
        return max;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

