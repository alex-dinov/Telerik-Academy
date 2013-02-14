using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        long[] numbers= new long[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            numbers[i] = number;
        }
        int maxSubset = (int)Math.Pow(2, n) - 1;
        for (int i = 1; i <= maxSubset; i++)
        {
            long sum = 0;
            for (int j = 0; j <= n; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit==1)
                {
                    sum = sum + numbers[j];
                }
            }
            if (sum==s)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

