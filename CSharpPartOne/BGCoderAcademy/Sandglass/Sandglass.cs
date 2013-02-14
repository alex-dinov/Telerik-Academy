using System;

class Sandglass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n/2+1; i++)
        {
            Console.Write(new string('.',i) + new string('*',n-i*2) + new string('.',i) + "\n");
        }
        for (int j = n/2-1; j>=0; j--)
        {
            Console.Write(new string('.',j) + new string('*',n-j*2) + new string('.',j) + "\n");
        }
    }
}

