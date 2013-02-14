/*Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
*/
using System;

class RepeatedElement
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
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number appears {0} times in the given array",FindElement(arr,number));
    }

    static int FindElement(int[] arr, int element)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==element)
            {
                count++;
            }
        }
        return count;
    }
}

