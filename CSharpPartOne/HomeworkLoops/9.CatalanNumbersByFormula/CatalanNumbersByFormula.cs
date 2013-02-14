//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
using System;

class CatalanNumbersByFormula
{
    static decimal Factorial(decimal number)
    {
        decimal factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial*=i;
        }
        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter n:");
        decimal n = decimal.Parse(Console.ReadLine());
        decimal catalanSum = 0;
        catalanSum = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine("The Catalan number is: " + catalanSum);
    }
}

