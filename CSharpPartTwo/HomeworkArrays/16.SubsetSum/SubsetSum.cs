/*We are given an array of integers and a number S. Write a program to find if there exists a subset of 
 * elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
*/
using System;

class SubsetSum
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
   
        Console.WriteLine("Result is: {0}",IsSubsetSum(arr,arr.Length,S));
    }

    static bool IsSubsetSum(int[] array, int n, int sum)
    {
        if (sum==0)
        {
            return true;
        }
        if (n==0 && sum!=0)
        {
            return false;
        }
        if (array[n-1] > sum)
        {
            return IsSubsetSum(array, n - 1, sum);
        }
        return IsSubsetSum(array, n - 1, sum) || IsSubsetSum(array, n - 1, sum - array[n - 1]);
    }
}

