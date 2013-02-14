/*Write a method that checks if the element at given position in given array of integers is bigger 
 * than its two neighbors (when such exist).
*/
using System;

class BiggerThanNeighbours
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
        Console.Write("Enter position:");
        int position = int.Parse(Console.ReadLine());
        CheckNeighbours(arr, position);
    }

    static void CheckNeighbours(int[] arr, int position)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr.Length == 1)
            {
                Console.WriteLine("The element is NOT bigger than its neighbours!");
                return;
            }
            if (i==position)
            {
                if (i > 0 && i < arr.Length-1 && arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    Console.WriteLine("The element is bigger than its neighbours!");
                    return;
                }
                if (position==0 && arr[i] > arr[i+1])
                {
                    Console.WriteLine("The element is bigger than its neighbours!");
                    return;
                }
                if (position==arr.Length-1 && arr[i] > arr[i-1])
                {
                    Console.WriteLine("The element is bigger than its neighbours!"); 
                    return;
                }
            }
        }
        Console.WriteLine("The element is NOT bigger than its neighbours!");
    }
}

