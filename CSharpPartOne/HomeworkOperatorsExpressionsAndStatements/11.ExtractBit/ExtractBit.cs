//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
using System;

class ExtractBit
{
    static void Main()
    {
        int i = 8;
        int b = 2;
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine("The value of bit at position b = {0}",bit);
    }
}

