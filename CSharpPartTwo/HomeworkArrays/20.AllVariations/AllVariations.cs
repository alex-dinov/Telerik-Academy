/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/
using System;

class AllVariations
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
        Variation(arr, 0, n);
    }

    static void Variation(int[] array, int current,int n)
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

        for (int i = 1; i <= n; i++)
        {
            array[current] = i;   
            Variation(array, current + 1, n);   
        }
    }
}

