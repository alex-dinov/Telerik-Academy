using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;
        for (int i = 0; i < n; i++)
        {
            //right
            for (int row = i; row <= i; row++)
            {
                for (int col = i; col < n-i; col++)
                {
                    if (n*n < count)
                    {
                        break;
                    }
                    matrix[row, col] = count;
                    count++;
                }
            }
            //down
            for (int col = n-1-i; col <= n-i-1; col++)
            {
                for (int row = i+1; row <= n-i-1; row++)
                {
                    if (n * n < count)
                    {
                        break ;
                    }
                    matrix[row, col] = count;
                    count++;
                }
            }
            //left
            for (int row = n - i - 1; row >= n - i - 1; row--)
            {
                for (int col = n-i-2; col >=i; col--)
                {
                    if (n * n < count)
                    {
                        break;
                    }
                    matrix[row, col] = count;
                    count++;
                }
            }
            //up
            for (int col = i; col <= i; col++)
            {
                for (int row = n-2-i; row >= i+1; row--)
                {
                    if (n * n < count)
                    {
                        break;
                    }
                    matrix[row, col] = count;
                    count++;
                }
            }

        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}",matrix[row, col]);
            }
            Console.WriteLine();
        }

    }
}

