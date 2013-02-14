/*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
 * Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/
using System;

class AllCombinations
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        for (int i = 0; i < k; i++)
        {
            arr[i] = i + 1;
        }
        Variation(arr, 0, n,1);
    }

    static void Variation(int[] array, int current, int n,int next)
    {
        if (current == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            return;
        }

        for (int i = next; i <= n; i++)
        {
            array[current] = i;
            Variation(array, current + 1, n,i+1);    
        }
    }
}

