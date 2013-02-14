/*Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, find the smallest from the rest, 
 * move it at the second position, etc.
*/
using System;

class SelectionSort
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

        int minIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        foreach (var element in arr)
        {
            Console.Write(element+ " ");
        }
        Console.WriteLine();
    }
}

