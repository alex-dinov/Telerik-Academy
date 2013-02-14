using System;

class WeAllLoveBits
{
    static uint Reverse(uint p)
    {
        uint revP = 0;
        while(p!=0)
        {
            revP <<= 1;
            revP |= (p & 1);
            p >>= 1;
        }
        return revP;
    }
    static void Main()
    {
        uint revP=0;
        uint newP = 0;
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            uint p = uint.Parse(Console.ReadLine());
            revP=Reverse(p);
            newP = ((p ^ (~p)) & revP);
            Console.WriteLine(newP);
        }     
    }
}

