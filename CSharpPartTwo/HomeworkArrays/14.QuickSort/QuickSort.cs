/*Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
*/
using System;

class QuickSort
{
    static void Main()
    {
        string[] arr = { "z", "d", "a", "l", "m", "h", "o" };
        QuickSorting(arr, 0, arr.Length-1);
        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }

    static void QuickSorting(string[] array, int left, int right)
    {
        int i = left;
        int j = right;
        string pivot = array[(left + right) / 2];

        while (i <= j)
        {
            while (array[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (array[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                string temp = array[i];
                array[i++] = array[j];
                array[j--] = temp;
            }
        }

        if (left < j)
        {
            QuickSorting(array, left, j);
        }
        if (i < right)
        {
            QuickSorting(array, i, right);
        }
    }
}



