/*Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
*/using System;

class ArrayBinarySearch
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
       
        Array.Sort(arr);
        int index = Array.BinarySearch(arr, K);
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
        }
        else if (index==-1)
        {
            Console.WriteLine("K is the smallest element in the array!");
        }
        else
        {
            int numb = Math.Abs(index) - 2;
            Console.WriteLine(arr[numb]);
        }
       
    }
}

