using System;

class TripleRotationOfDigits
{
    static void Main(string[] args)
    {
        int K = int.Parse(Console.ReadLine());
        string current = null;
        if (K<10)
        {
            Console.WriteLine(K);
            return;
        }
        if (K==100)
        {
            Console.WriteLine(1);
            return;
        }
        for (int i = 0; i < 3; i++)
        {

            string tens = (K % 10).ToString();
            current = K.ToString();
            current = (K / 10).ToString();
            current = current.Insert(0, tens);
            K = int.Parse(current);
        }
        Console.WriteLine(K);
    }
}

