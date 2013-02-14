using System;

class FirTree
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', n - i - 1) + new string('*', 2 * i - 1) + new string('.', n - i - 1)+"\n");
        }
        Console.Write(new string('.',n-2) + new string('*',1) + new string('.',n-2) + "\n");
    }
}


