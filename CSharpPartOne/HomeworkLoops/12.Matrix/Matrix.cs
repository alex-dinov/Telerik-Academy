//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N:");
        byte n = byte.Parse(Console.ReadLine());
        if (n < 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= i + n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong Input");
        }
    }
}

