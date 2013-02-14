using System;

class AngryBits
{
    static void Main()
    {
        int[,] matrix = new int[8, 16];
        for (int row = 0; row < 8; row++)
        {
            int n = int.Parse(Console.ReadLine());
            for (int col = 0; col < 16; col++)
            {
                if ((n&(1<<col))!=0)
                {
                    matrix[row, col] = 1;
                    if (col<8)
                    {
                         matrix[row, col] = 2;
                    }
                }
            }
        }
        int lenght = 0;
        int hitCount = 0;
        bool hitted = false;
        int currentPoints=0;
        int points = 0;
        for (int col = 8; col < 16; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                   
                    hitCount = 0;
                    lenght = 0;
                    while (row > 0 && col>0)
                    {
                        matrix[row, col] = 0;
                        row--;
                        col--;
                        if (matrix[row, col] == 2)
                        {
                            hitted = true;
                        }
                        if (hitted)
                        {
                            break;
                        }
                        lenght++;
                    }
                    if (hitted==false)
                    {
                        while (row < 7 && col > 0)
                        {
                            matrix[row, col] = 0;
                            row++;
                            col--;
                            if (matrix[row, col] == 2)
                            {
                                hitted = true;
                            }
                            if (hitted)
                            {
                                break;
                            }
                            lenght++;
                        }
                    }
                  
                    lenght += 1;
                    if (hitted)
                    {
                        hitCount++;
                        matrix[row, col] = 0;
                        if (row > 0 && matrix[row - 1, col] == 2)
                        {
                            hitCount++;
                            matrix[row - 1, col] = 0;
                        }
                        if (row > 0 && matrix[row - 1, col + 1] == 2)
                        {
                            hitCount++;
                            matrix[row - 1, col + 1] =0;
                        }
                        if (row > 0 && col > 0 && matrix[row - 1, col - 1] == 2)
                        {
                            hitCount++;
                            matrix[row - 1, col - 1] = 0;
                        }
                        if (row < 7 && matrix[row + 1, col] == 2)
                        {
                            hitCount++;
                            matrix[row + 1, col] = 0;
                        }
                        if (row < 7 && matrix[row + 1, col + 1] == 2)
                        {
                            hitCount++;
                            matrix[row + 1, col + 1] = 0;
                        }
                        if (row < 7 && col > 0 && matrix[row + 1, col - 1] == 2)
                        {
                            hitCount++;
                            matrix[row + 1, col - 1] = 0;
                        }
                        if (col > 0 && matrix[row, col - 1] == 2)
                        {
                            hitCount++;
                            matrix[row, col - 1] = 0;
                        }
                        if (matrix[row, col + 1] == 2)
                        {
                            hitCount++;
                            matrix[row, col + 1] = 0;
                        }
                    }
                    hitted = false;
                    row = 0;
                    col = 8;
                    currentPoints = hitCount * lenght;
                    points += currentPoints;
                }               
            }         
        }     
        bool win = true;
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 16; col++)
            {
                if (matrix[row,col]==2)
                {
                    win = false;
                }               
            }
        }
        if (win)
        {
            Console.WriteLine(points+" "+"Yes");
        }
        else
        {
            Console.WriteLine(points+" "+"No");
        }
        
    }
}

