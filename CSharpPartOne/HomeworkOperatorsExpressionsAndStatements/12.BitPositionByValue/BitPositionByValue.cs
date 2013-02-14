//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
using System;

class BitPositionByValue
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter v (v=0 or 1):");
        byte v = byte.Parse(Console.ReadLine());
        if (v==1)
        {
            n = n | (1 << p);
            Console.WriteLine("n={0}",n);
        }
        else if (v==0)
        {
            n = n & (~(1 << p));
            Console.WriteLine("n={0}",n);
        }           
        else
        {
            Console.WriteLine("Invalid value v!");
        }      
    }
}

