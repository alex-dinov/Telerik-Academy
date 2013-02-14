//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
using System;

class FindingBit3
{
    static void Main()
    {     
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool bit;
        if (bit = (number & 8) != 0)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }       
    }
}



