/*Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
 * Find in the array a subset of K elements that have sum S or indicate about its absence.*/
using System;
using System.Collections.Generic;

class FindingSubsetThatHaveGivenSum
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
        Console.Write("Enter S:");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Enter K:");
        int K = int.Parse(Console.ReadLine());
       

        int maxSubset = (int)Math.Pow(2, N)-1;

        for (int i = 0; i < maxSubset; i++)
        {
            int sum = 0;
            List<int> elements = new List<int>();
            elements.Clear();
            for (int j = 0; j <= N; j++)
            {
                int mask = i & (1<<j);
                int bit = mask >> j;
                if (bit == 1)
                {
                    sum += arr[j];
                    elements.Add(arr[j]);
                }
            }
            if (sum==S && elements.Count==K)
            {
                for (int p = 0; p < elements.Count; p++)
                {
                    Console.Write(elements[p]+" ");
                }
                Console.WriteLine();
                return;
            }
        }
        Console.WriteLine("No such sum!");
    }
}

