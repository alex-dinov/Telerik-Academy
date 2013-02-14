//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
using System;

class FactorialSum
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X:");
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum = sum + factorial / Math.Pow(x, i);
        }
        Console.WriteLine("The sum S= " + sum);
    }
}

