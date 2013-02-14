/*Write a program that compares two char arrays lexicographically (letter by letter).*/
using System;

class CompareCharArrays
{
    static void Main()
    {
        //Read array from console
        Console.Write("Enter lenght of array one:");
        int firstLen = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstLen];
        for (int i = 0; i < firstLen; i++)
        {
            Console.Write("Enter element:");
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        //Read array from console
        Console.Write("Enter lenght of array two:");
        int secondLen = int.Parse(Console.ReadLine());
        char[] secondArray = new char[secondLen];
        for (int i = 0; i < secondLen; i++)
        {
            Console.Write("Enter element:");
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        //Check wich array is shorter 
        int shortestArray = firstArray.Length;
        if (firstArray.Length > secondArray.Length)
        {
            shortestArray = secondArray.Length;
        }
        //Compare arrays
        for (int i = 0; i < shortestArray; i++)
        {
            if (firstArray[i]!=secondArray[i])
            {
                if (firstArray[i]<secondArray[i])
                {
                    Console.WriteLine("The shortest array is the first one!");
                    return;
                }
                else
                {
                    Console.WriteLine("The shortest array is the second one!");
                    return;
                }
            }
        }
        if (firstArray.Length < secondArray.Length)
        {
             Console.WriteLine("The shortest array is the first one!");
        }
        else if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("The shortest array is the second one!");
        }
        else
        {
            Console.WriteLine("The arrays are the same!");
        }
    }
}

