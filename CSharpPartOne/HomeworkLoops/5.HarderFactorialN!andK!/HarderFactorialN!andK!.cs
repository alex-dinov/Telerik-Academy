//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
using System;

class HarderFactorialNandK
{
    static int Factorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:");
        int k = int.Parse(Console.ReadLine());
        if (1 < n && n < k)
        {
            Console.WriteLine(Factorial(n) * Factorial(k) / Factorial(k - n));
        }
        else
        {
            Console.WriteLine("Wrong Input");
        }
    }
}

