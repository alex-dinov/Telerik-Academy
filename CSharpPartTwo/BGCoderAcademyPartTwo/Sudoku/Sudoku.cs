using System;

class Sudoku
{

    static void Main()
    {
        char[,] matrix=new char[9,9];
        for (int row = 0; row < 9; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < 9; col++)
            {
                matrix[row, col] = line[col];
            }
        }
        if (Solve(0,0,matrix))
        {
            PrintMatrix(matrix);
        }
        else
        {
            Console.WriteLine("Sorry!");
        }
    }

    static bool Check(int row, int col, int value ,char[,] matrix)
    {
        for (int i = 0; i < 9; i++)
		{
            if (value==matrix[i,col])
            {
                return false;
            }
		}
        for (int i = 0; i < 9; i++)
        {
            if (value==matrix[row,i])
            {
                return false;
            }
        }
        int boxRow = (row / 3) * 3;
        int boxCol = (col / 3) * 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (value==matrix[boxRow+i,boxCol+j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static bool Solve(int row, int col, char[,] matrix)
    {
        if (row==9)
        {
            row = 0;
            col++;
            if (col==9)
            {
                return true;
            }
        }
        if (matrix[row,col]!='-')
        {
            return Solve(row + 1, col, matrix);
        }
        for (char value = '1'; value <= '9'; value++)
        {
            if (Check(row,col,value,matrix))
            {
                matrix[row, col] = value;
                if (Solve(row+1,col,matrix))
                {
                    return true;
                }
            }
        }
        matrix[row, col] = '-';
        return false;
    }

    static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
