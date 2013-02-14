/*Write a program that reads two arrays from the console and compares them element by element.*/
using System;

class CompareArrays
{
    static void Main()
    {
        //Read array from console
        Console.Write("Enter lenght of array one:");
        int firstLen = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstLen];
        for (int i = 0; i < firstLen; i++)
        {
            Console.Write("Enter element:");
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        //Read array from console
        Console.Write("Enter lenght of array two:");
        int secondLen = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondLen];
        for (int i = 0; i < secondLen; i++)
        {
            Console.Write("Enter element:");
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //Check arrays
        bool same = true;
        if (firstArray.Length==secondArray.Length)
	    {            
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i]!=secondArray[i])
                {
                    same = false;
                }              
            }
            if (same)
            {
                Console.WriteLine("The arrays are the same");
            }
            else
            {
                Console.WriteLine("The arrays are different");
            }
	    }
        else
        {
            Console.WriteLine("The arrays are different");
        }
    }
}

