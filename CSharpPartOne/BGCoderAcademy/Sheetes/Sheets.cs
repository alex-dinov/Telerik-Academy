using System;

class Sheets
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] bits = new int[11];
        for (int i = 0; i < bits.Length; i++)
        {
            if ((N & (1<<i))!=0)
            {
                bits[i] = 1;
            }
        }
        int A10 = bits[0];
        int A9 = bits[1];
        int A8 = bits[2];
        int A7 = bits[3];
        int A6 = bits[4];
        int A5 = bits[5];
        int A4 = bits[6];
        int A3 = bits[7];
        int A2 = bits[8];
        int A1 = bits[9];
        int A0 = bits[10];
        if (A10==0)
        {
            Console.WriteLine("A10");
        }
        if (A9 == 0)
        {
            Console.WriteLine("A9");
        }
        if (A8 == 0)
        {
            Console.WriteLine("A8");
        }
        if (A7 == 0)
        {
            Console.WriteLine("A7");
        }
        if (A6 == 0)
        {
            Console.WriteLine("A6");
        }
        if (A5 == 0)
        {
            Console.WriteLine("A5");
        }
        if (A4 == 0)
        {
            Console.WriteLine("A4");
        }
        if (A3 == 0)
        {
            Console.WriteLine("A3");
        }
        if (A2 == 0)
        {
            Console.WriteLine("A2");
        }
        if (A1 == 0)
        {
            Console.WriteLine("A1");
        }
        if (A0 == 0)
        {
            Console.WriteLine("A0");
        }
    }
}
