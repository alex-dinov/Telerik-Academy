using System;

class Lines
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        int bestLen = 0;
        int count = 0;
        for (int row = 0; row < 8; row++)
        {
            int N = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((N & (1<<col))!=0)
                {
                    matrix[row, col] = 1;
                }                           
            }
        }
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int len = 0;
                while (col < 8 && matrix[row, col] == 1)
                {
                    col++;
                    len++;
                    if (len == bestLen)
                    {
                        count++;
                    }
                    if (len>bestLen)
                    {
                        bestLen = len;
                        count = 1;
                    }                  
                }               
            }
        }

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                int len = 0;
                while (row < 8 && matrix[row, col] == 1)
                {
                    row++;
                    len++;
                    if (len==bestLen)
                    {
                        count++;
                    }
                    if (len > bestLen)
                    {
                        bestLen = len;
                        count = 1;
                    }
                }
            }
        }
        if (bestLen==1)
        {
            count /= 2;
        }
        Console.WriteLine(bestLen);
        Console.WriteLine(count);
    }
}

