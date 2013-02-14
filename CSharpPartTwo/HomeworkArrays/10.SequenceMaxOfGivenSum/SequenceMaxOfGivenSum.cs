/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 * */
using System;

class SequenceMaxOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter S:");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of array N:");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element:");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum==S)
                {
                    startIndex = i;
                    endIndex = j;
                }
            }
            sum = 0;
        }
        if (startIndex == 0 && endIndex == 0 && arr[0]!=S)
        {
            Console.WriteLine("No such sequence!");
        }
        else
        {
            for (int i = startIndex; startIndex <= endIndex; startIndex++)
            {
                Console.Write(arr[startIndex] + " ");
            }
            Console.WriteLine();
        }
    }
}

