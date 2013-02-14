/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes 
 * algorithm (find it in Wikipedia).
*/
using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] sieve = new bool[10000000];
        sieve[0] = sieve[1] = true;

        for (int i = 2; i <= Math.Sqrt(sieve.Length); i++)
        {
            if (sieve[i]==true)
            {
                continue;
            }
            for (int j = 2 * i; j < sieve.Length; j += i)
            {
                sieve[j] = true;
            }
        }

        for (int i = 2; i < sieve.Length; i++)
        {
            if (sieve[i]==false)
            {
                Console.Write(i+" ");
            }
        }
    }
}

