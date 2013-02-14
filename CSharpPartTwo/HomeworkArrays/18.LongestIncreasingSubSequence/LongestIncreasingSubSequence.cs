/*Write a program that reads an array of integers and removes from it a minimal number of elements in such way that
 * the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5} ? {1, 3, 3, 4, 5}
*/
using System;

class LongestIncreasingSubSequence
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

        LISS(arr);
    }

    static void LISS(int[] array)
    {
        string[] elements=new string[array.Length];
        int[] lenght = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            elements[i] = array[i] + " ";
            lenght[i] = 1;
        }

        int maxLenght = 1;

        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] >= array[j] && lenght[i] <lenght[j]+1)
                {
                    lenght[i] = lenght[j] + 1;
                    elements[i] = elements[j] + array[i] + " ";
                    if (maxLenght < lenght[i])
                    {
                        maxLenght = lenght[i];
                    }
                }
            }
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (lenght[i]==maxLenght)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}

