/*Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
*/
using System;

class AllPermutations
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int[] arr=new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i+1;
        }
        Permutation(arr, 0);
    }

    static void Permutation(int[] array, int current)
    {
        if (current==array.Length)
        {
            foreach (var element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();
            return;
        }

        Permutation(array, current + 1);
        
        for (int i = current+1; i < array.Length; i++)
        {
            if (array[i]!=array[current])
            {
                Swap(array, current, i);
                Permutation(array, current + 1);
                Swap(array, current, i);
            }
        }
    }

    static void Swap(int[] array, int current, int i)
    {
        int temp = array[current];
        array[current] = array[i];
        array[i] = temp;
    }
}

