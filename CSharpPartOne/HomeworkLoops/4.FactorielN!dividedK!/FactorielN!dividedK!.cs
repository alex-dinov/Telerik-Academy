//Write a program that calculates N!/K! for given N and K (1<K<N).
using System;

class FactorielNdividedK
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:");
        int k = int.Parse(Console.ReadLine());
        decimal factorial = 1;

        if (1<k && k<n)
        {
            for (int i = k+1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("N!/K! = " + factorial);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}

