using System;
using System.Collections.Generic;

class DancingBits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int number=0;
        int len = 0;
        int result = 0;
        int lastBit=-1;

        List<int> numbs = new List<int>();
        for (int i = 0; i < N; i++)
        {
            number = int.Parse(Console.ReadLine());
            bool findedBit = false;
            for (int bitNum = 31; bitNum >= 0; bitNum--)
            {
                int bitValue = (number >> bitNum) & 1;
                
                if (bitValue==1)
                {
                    findedBit = true;                 
                }               
                if (findedBit)
                {
                    if (lastBit==bitValue)
                    {
                        len++;
                    }
                    else
                    {
                        if (len==K)
                        {
                            result++;                            
                        }
                        len = 1;                       
                    }
                    numbs.Add(bitValue);
                    lastBit = bitValue;
                }
            }
        }
        if (len == K)
        {
            result++;
        }  
        Console.WriteLine(result);        
    }
}

