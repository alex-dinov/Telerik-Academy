//Write a program that reads an integer number n from the console and 
//prints all the numbers in the interval [1..n], each on a single line.
using System;

class NumbersOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers from [1..n]:");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }        
    }
}

