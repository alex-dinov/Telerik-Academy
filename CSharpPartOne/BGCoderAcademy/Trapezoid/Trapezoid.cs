using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n+1; i >0; i--)
        {
            for (int j = 1; j <= 2*n; j++)
            {
                if (i==n+1 && j>n)
                {
                    Console.Write("*");
                }
                else if (i==1)
                {
                    Console.Write("*");
                }
                else if (j==2*n)
                {
                    Console.Write("*");
                }
                else if (i==j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

