/*Write a program to convert decimal numbers to their binary representation.
*/
using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        ConvertDecimalToBinary(n);
    }

    static void ConvertDecimalToBinary(int n)
    {
        List<int> binary = new List<int>();
        while (n > 0)
        {
            binary.Add(n % 2);
            n /= 2;
        }
        binary.Reverse();
        foreach (var bit in binary)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }
}

