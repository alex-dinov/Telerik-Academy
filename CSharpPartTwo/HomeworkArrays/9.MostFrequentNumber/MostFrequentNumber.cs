/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 * */
using System;

class MostFrequentNumber
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

        //Selection sort
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

        int len = 1;
        int bestLen = 0;
        int element = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length-1 && arr[i]==arr[i+1])
            {
                len++;
            }
            else
            {
                len = 1;
            }
            if (len > bestLen)
            {
                bestLen = len;
                element = arr[i];
            }
        }
        if (bestLen>1)
        {
            Console.WriteLine("The most frequent number: {0} ({1} times)", element, bestLen);
        }
        else
        {
            Console.WriteLine("There is no frequent number");
        }
    }
}

