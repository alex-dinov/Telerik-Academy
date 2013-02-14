/*Write a program that finds the index of given element in a sorted array of integers by using 
 * the binary search algorithm (find it in Wikipedia).
*/using System;

class BinarySearch
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
        Console.WriteLine("Enter element ,that you want to search for his index:");
        int element = int.Parse(Console.ReadLine());
        Console.WriteLine("Sorted aray:");
        InsertionSort(arr);
        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
        Console.WriteLine("The index of the element is:");
        BinarySearching(arr, element, 0, arr.Length-1);   
    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int value = array[i];
            for (int j = 0; j <= i-1; j++)
            {
                if (value < array[j])
                {
                    for (int k = i-1; k >= j; k--)
                    {
                        array[k + 1] = array[k];
                    }
                    array[j] = value;
                    break;
                }
            }
        }
    }

    static void BinarySearching(int[] array,int index,int minIndex,int maxIndex)
    {
        if (maxIndex < minIndex)
	    {
            Console.WriteLine("No such element!");
            return;
	    }
        else
        {
            int middleIndex = (maxIndex + minIndex) / 2;

            if (array[middleIndex] > index )
            {
                BinarySearching(array, index, minIndex, middleIndex - 1);
            }
            else if (array[middleIndex] < index)
            {
                 BinarySearching(array, index, middleIndex + 1, maxIndex);
            }
            else
            {
                Console.WriteLine(middleIndex);
                return;
            }
        }
    }
}

