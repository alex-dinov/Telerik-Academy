using System;

class TribonacciTriangle
{
    static void Main()
    {
        long t1 = long.Parse(Console.ReadLine());
        long t2 = long.Parse(Console.ReadLine());
        long t3 = long.Parse(Console.ReadLine());
        long L = long.Parse(Console.ReadLine());
        long sum = 0;
        Console.WriteLine(t1);
        Console.WriteLine(t2+" "+t3);
        for (int row = 3; row <= L; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                sum = t1 + t2 + t3;
                Console.Write(sum+" ");
                t1 = t2;
                t2 = t3;
                t3 = sum;
            }
            Console.WriteLine();
        }
    }
}

