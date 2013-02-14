using System;

class MatrixB
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            if (col%2==0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = n-1; row >= 0; row--)
                {
                     matrix[row, col] = count;
                     count++;
                }
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

