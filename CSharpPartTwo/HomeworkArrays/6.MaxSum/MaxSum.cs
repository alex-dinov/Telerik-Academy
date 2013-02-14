/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
*/
using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter K:");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of array N:");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (K > N)
        {
            Console.WriteLine("Wrong Input!");
            return;
        }
        int minIndex = 0;
        int p,j;

        //Selection sort
        for ( p = 0; p < arr.Length; p++)
        {
            minIndex = p;
            for ( j = p+1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }   
            }
            if (minIndex!=p)
            {
                int temp = arr[p];
                arr[p]=arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        //Print result
        Console.WriteLine("The elements K with max sum:");
        for (int i = N-K; i < N; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
    }
}

