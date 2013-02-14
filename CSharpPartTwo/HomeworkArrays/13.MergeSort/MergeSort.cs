/** Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
*/
using System;

class MergeSort
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
        MergeSorting(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
    }

    static int[] MergeSorting(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }
        int middle = array.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }
        int[] right = new int[array.Length - middle];
        for (int i = 0; i < array.Length-middle; i++)
        {
            right[i] = array[i + middle];
        }

        left = MergeSorting(left);
        right = MergeSorting(right);

        int leftIndex = 0;
        int rightIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (rightIndex==right.Length || (leftIndex < left.Length && left[leftIndex] <= right[rightIndex]))
            {
                array[i] = left[leftIndex];
                leftIndex++;
            }
            else if (leftIndex==left.Length || (rightIndex < right.Length && right[rightIndex] <= left[leftIndex]))
            {
                array[i] = right[rightIndex];
                rightIndex++;
            }
        }
        return array;
    }
}

