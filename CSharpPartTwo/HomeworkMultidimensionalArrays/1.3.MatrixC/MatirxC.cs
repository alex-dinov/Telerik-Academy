using System;

class MatirxC
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;
        int lastRow = 0;
        int lastCol = 0;

        int col=0;
        int row=0;
        for ( row = n - 1; row >= 0; row--)
        {              
            matrix[row, col] = count;
            count ++;
            lastCol = col;
            lastRow = row;
            while (row < n-1 && col < n-1)
            {                  
                row++;
                col++;
                matrix[row, col] = count;
                count++;
            }
            col = lastCol;
            row = lastRow;
        }
        row = 0;
        for ( col = 1; col < n; col++)
        {
            matrix[row, col] = count;
            count ++;
            lastCol = col;
            lastRow = row;
            while (row < n - 1 && col < n - 1)
            {
                row++;
                col++;
                matrix[row, col] = count;
                count++;
            }
            col = lastCol;
            row = lastRow;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

