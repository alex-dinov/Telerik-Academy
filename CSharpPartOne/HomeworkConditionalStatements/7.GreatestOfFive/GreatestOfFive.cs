//Write a program that finds the greatest of given 5 variables.
using System;

class GreatestOfFive
{
    static void Main()
    {
        int max = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());         
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine("The greatest number is: {0}", max);
    }
}

