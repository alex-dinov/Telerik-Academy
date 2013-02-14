/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/
using System;

class MaxEqualElements
{
    static void Main()
    {
        Console.Write("Enter lenght of array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element:");
            arr[i] = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("The maximal increasing sequence is:");
                Console.Write(arr[i]);
                Console.WriteLine();
                return;
            }
        } 

        int len = 1;
        int bestLen = 0;
        int endIndex = 0;

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
            if (len>bestLen)
            {
                bestLen = len;
                endIndex = i + 1;
            }
        }
        Console.WriteLine("The maximal increasing sequence is:");
        for (int i = endIndex - bestLen + 1; i < endIndex + 1; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

