/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
 * */
using System;

class SequenceMaximaSum
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

        int[] maxElem = new int[N];
        maxElem[0] = arr[0];
      
        int maxSum = maxElem[0];
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 1; i < N; i++)
        {
            if (maxElem[i-1] >= 0)
            {
                maxElem[i] = maxElem[i - 1] + arr[i];              
            }
            else
            {
                maxElem[i] = arr[i];
                startIndex = i;
            }
            if (maxElem[i] > maxSum)
            {
                maxSum =maxElem[i];
                endIndex = i;
            }
        }
        Console.WriteLine("The maximal sum is:{0}",maxSum);
        for (int i = startIndex; startIndex <= endIndex; startIndex++)
        {
            Console.Write(arr[startIndex]+" ");
        }
        Console.WriteLine();
    }
}

