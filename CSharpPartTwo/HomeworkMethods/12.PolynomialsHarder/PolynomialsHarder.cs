/*Extend the program to support also subtraction and multiplication of polynomials.
*/
using System;

class PolynomialsHarder
{
    static void Main()
    {
        decimal[] first = { 3, 5, 4 };
        PrintPol(first);
        Console.WriteLine();

        decimal[] second = { 2, 0, 1 };
        PrintPol(second);
        Console.WriteLine();

        Console.WriteLine("Substraction:");
        decimal[] substraction = Substraction(first, second);
        PrintPol(substraction);
        Console.WriteLine();

        Console.WriteLine("Multiplication:");
        decimal[] multiplicaton = Multiplication(first, second);
        PrintPol(multiplicaton);
    }

    static void PrintPol(decimal[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + "x^" + i + (i == 0 ? "\n " : "+"));
        }
    }

    static decimal[] Substraction(decimal[] first, decimal[] second)
    {
        decimal[] subs = new decimal[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < first.Length; i++)
        {
            subs[i] = first[i];
        }
        for (int i = 0; i < second.Length; i++)
        {
            subs[i] -= second[i];
        }
        return subs;
    }

    static decimal[] Multiplication(decimal[] first, decimal[] second)
    {
        decimal[] multiple = new decimal[(first.Length+(second.Length-1))];

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                multiple[i + j] += first[i] * second[j];
            }
        }
        return multiple;
    }
}

