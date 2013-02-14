//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
using System;

class From1ToNminAndmax
{
    static void Main()
    {
        Console.Write("Enter count of numbers:");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());           
            if (number<min)
            {
                min = number;
            }
            if (number>max)
            {
                max = number;
            }        
        }
        Console.WriteLine("The minimal number is: {0}",min);
        Console.WriteLine("The maximal number is: {0}",max);
    }
}

