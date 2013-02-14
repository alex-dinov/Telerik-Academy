//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. 
//Example: v=5; p=1  false.
using System;

class BitPosition
{
    static void Main()
    {
        int p = 1;
        int v = 7;
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;        
        bool check = bit == 1;
        Console.WriteLine("Bit at position p = 1? {0}",check);
    }
}

