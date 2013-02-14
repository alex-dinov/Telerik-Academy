/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
 * located on the same line, column or diagonal. Write a program that finds the longest sequence of equal 
 * strings in the matrix. 
*/
using System;

class LongestSeqOfStrings
{
    static void Main()
    {

        string[,] matrix = { 
                           { "ha", "fifi", "hi", "hi" }, 
                           { "fo", "ha", "fo", "xx" }, 
                           { "xxx", "ho", "ha", "xx" } 
                           };
        int lenght = 1;
        int bestLenght = 0;
        string word = "";

        //horizontal
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                while (col>=0 && col <matrix.GetLength(0) && matrix[row,col]==matrix[row,col+1])
                {
                    lenght++;
                    col++;                  
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    word = matrix[row, col];
                }
                lenght = 1;
            }
        }

        //vertical
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                while (row >= 0 && row<matrix.GetLength(0)-1 && matrix[row, col] == matrix[row+1, col])
                {
                    lenght++;
                    row++;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    word = matrix[row, col];
                }
                lenght = 1;
            }
        }

        //diagonal
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                while (col >= 0 && col < matrix.GetLength(1) && row >= 0 && row < matrix.GetLength(0)-1 && matrix[row, col] == matrix[row + 1, col + 1])
                {
                    lenght++;
                    row++;
                    col++;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    word = matrix[row, col];
                }
                lenght = 1;
            }
        }

        Console.WriteLine(bestLenght);
        Console.WriteLine(word);
    }

    
}

