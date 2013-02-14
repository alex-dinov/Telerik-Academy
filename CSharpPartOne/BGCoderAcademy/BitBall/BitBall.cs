using System;

class BitBall
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int N = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((N & (1 << col)) != 0)
                {
                    matrix[row, col] = 1;
                }
            }
        }

        for (int row = 0; row < 8; row++)
        {
            int N = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((N & (1 << col)) != 0)
                {
                    if (matrix[row,col]==1)
                    {
                        matrix[row, col] = 0;
                        continue;
                    }
                    matrix[row, col] = 2;
                }
            }
        }
        int topGoal = 0;
        int bottomGoal = 0;
        int oldRow = 0;
        int oldCol = 0;

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row,col]==1 && row==7)
                {
                    topGoal++;
                }
                if (matrix[row,col]==2 && row==0)
                {
                    bottomGoal++;
                }
                if (matrix[row,col]==2)
                {
                    oldRow = row;
                    oldCol = col;
                    while (row>0 && matrix[row-1,col]==0)
                    {
                        row--;
                        if (row==0 && matrix[row,col]==0)
                        {
                            bottomGoal++;
                        }
                    }
                    row = oldRow;
                    col = oldCol;
                }

                if (matrix[row,col]==1)
                {
                    oldRow = row;
                    oldCol = col;
                    while (row<7 && matrix[row+1,col]==0)
                    {
                        row++;
                        if (row==7 && matrix[row,col]==0)
                        {
                            topGoal++;
                        }
                    }
                    row = oldRow;
                    col = oldCol;
                }
            }
        }
        Console.WriteLine(topGoal+":"+bottomGoal);
    }
}

