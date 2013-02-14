/*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/
using System;
using System.Collections.Generic;

class BinaryShort
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        ConvertDecimalToBinary(n);
    }

    static void ConvertDecimalToBinary(short n)
    {
        List<int> binary = new List<int>();
        if (n <= 0)
        {
            for (int i = 0; i < 16; i++)
            {
                binary.Add((n >> i) & 1);
            }
        }
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

