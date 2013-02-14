/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has 
 * maximal sum of its elements.
*/
using System;

class MaxSumInSquare
{
    static void Main()
    {
        int[,] matrix = {
                        {7, 1, 3, 3, 2, 1},
                        {1, 3, 9, 8, 5, 6},
                        {4, 6, 7, 9, 1, 0} 
                        };
        int bestSum = int.MinValue;

      
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] +
                    matrix[row, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 2] +
                    matrix[row + 1, col + 2] + matrix[row + 2, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
        Console.WriteLine(bestSum);
    }
}

