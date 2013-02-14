//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
using System;

class SequenceBitExchange
{
    static void Main()
    {
        Console.WriteLine("Enter positive number:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("In binary code: {0}", Convert.ToString(number, 2).PadLeft(32,'0'));
        Console.WriteLine("Enter bit position p:");
        byte p = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position q:");
        byte q = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many bits you want to exchange k:");
        byte k = byte.Parse(Console.ReadLine());

        bool check = ((p + k - 1) <= 31) && ((q + k - 1) <= 31);
        if (check)
        {
            uint[] binaryNumber = new uint[32];
            for (int i = 0; i < 32; i++)
            {
                binaryNumber[i] = number % 2;
                number = number / 2;
            }
            uint changeBit = new uint();
            for (int i = 0; i < k; i++)
            {
                changeBit = binaryNumber[p];
                binaryNumber[p] = binaryNumber[q];
                binaryNumber[q] = changeBit;
                p++;
                q++;
            }
            Console.WriteLine("After changing bits:");
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid data entered!");
        }
    }
}

