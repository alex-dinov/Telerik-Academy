using System;

class FallDown
{
    static void Main()
    {
        //entering bits
        int[,] matrix = new int[8, 8];
        int num = 0;
        for (int row = 0; row < 8; row++)
        {
            int N=int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((N & (1<<col))!=0)
                {
                    matrix[row, col] = 1;
                }
            }
        }

        for (int row = 7; row >=0; row--)
        {
            for (int col = 7; col >=0; col--)
            {
                if (row<7 && matrix[row,col]==1)
                {
                    while (row<7 && matrix[row+1,col]==0)
                    {
                        matrix[row+1, col] = 1;
                        matrix[row, col] = 0;
                        row++;                      
                    }
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            num = 0;
            for (int col = 7; col>=0; col--)
            {
               
                num += (int)Math.Pow(2, col)*matrix[row, col];
            }
            Console.WriteLine(num);
        }
    }
}

