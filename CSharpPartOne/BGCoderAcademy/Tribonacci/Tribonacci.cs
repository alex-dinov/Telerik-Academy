using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger newT1 = 0;

        if (n==1)
        {
            Console.WriteLine(t1);
        }
        else if (n==2)
        {
            Console.WriteLine(t2);
        }
        else if (n == 3)
        {
            Console.WriteLine(t3);
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                newT1 = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = newT1;
            }
            Console.WriteLine(newT1);
        }
    }
}

