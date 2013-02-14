using System;

class SevenlandNumbers
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
       
        int tens = K % 10;
        int hundreds = K % 100;
        int thousand = K % 1000;
        if (thousand==666)
        {
            Console.WriteLine(K+334);
        }
        else if (hundreds==66)
        {
            Console.WriteLine(K+34);
        }
        else if (tens==6)
        {
            Console.WriteLine(K+4);
        }
        else
        {
            Console.WriteLine(K + 1);
        }
    }
}

