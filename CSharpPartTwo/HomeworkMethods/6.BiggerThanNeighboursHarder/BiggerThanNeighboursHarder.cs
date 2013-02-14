/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
 * if there’s no such element.
Use the method from the previous exercise.
*/
using System;

class BiggerThanNeighboursHarder
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
        Console.WriteLine("The index of the first element bigger than its neighbours is {0}",CheckNeighbours(arr));
    }

    static int CheckNeighbours(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr.Length==1)
            {
                return -1;
            }
            if (i > 0 && i < arr.Length - 1 && arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
            if (i == 0 && arr[i] > arr[i + 1])
            {
                return i;
            }
            if (i == arr.Length - 1 && arr[i] > arr[i - 1])
            {
                return i;
            }          
        }
        return -1;
    }
}

