/*You are given an array of strings. Write a method that sorts the array by the length of 
 * its elements (the number of characters composing them).
*/
using System;

class SortByLenght
{
    static void Main()
    {
        string[] array = { "xxx", "ho", "hahhaha", "xx", "a" };
        SortArray(array);
        foreach (var item in array)
	    {
            Console.Write("{0} ",item);
	    }
        Console.WriteLine();
    }

    static string[] SortArray(string[] array)
    {
        int[] lengthArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            lengthArray[i] = array[i].Length;
        }
        Array.Sort(lengthArray, array);
        return array; 
    }
}

