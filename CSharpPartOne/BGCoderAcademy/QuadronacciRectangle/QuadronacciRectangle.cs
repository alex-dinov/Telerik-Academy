using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long q1 = int.Parse(Console.ReadLine());
        long q2 = int.Parse(Console.ReadLine());
        long q3 = int.Parse(Console.ReadLine());
        long q4 = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        long sum = 0;
        int col = 4;

        Console.Write(q1+" ");
        Console.Write(q2 + " ");
        Console.Write(q3 + " ");
        Console.Write(q4);
        if (c>4)
        {
            Console.Write(" ");
        }
        for (int row = 0; row < r; row++)
        {
            for (int colFirstRound = col; colFirstRound < c; colFirstRound++)
            {
                sum = q1 + q2 + q3 + q4;
                Console.Write(sum);
                if (colFirstRound!=c-1)
                {
                    Console.Write(" ");
                }
                q1 = q2;
                q2 = q3;
                q3 = q4;
                q4 = sum;
            }
            col = 0;
            Console.WriteLine();
        }
    }
}

