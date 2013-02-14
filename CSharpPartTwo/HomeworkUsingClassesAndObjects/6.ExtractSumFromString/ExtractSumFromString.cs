/*You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. Example:
*/
using System;

class ExtractSumFromString
{
    static void Main()
    {
        string elements = "43 68 9 23 318";
        Console.WriteLine( ExtractInteger(elements));
    }

    static int ExtractInteger(string elements)
    {
        string[] numbers=elements.Split(' ');
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += int.Parse(numbers[i]);
        }
        return sum;
    }
}


