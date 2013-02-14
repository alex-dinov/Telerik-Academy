/*Write a program that reads a text file containing a square matrix of numbers and finds in the 
 * \matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. Each of the next N 
 * lines contain N numbers separated by space. The output should be a single number in a separate text file. */
using System;
using System.Collections.Generic;
using System.IO;

class Matrix
{
    static void Main()
    {
        StreamReader reader=new StreamReader(@"..\..\Matrix.txt");
        int N = 0;
        int[,] matrix = new int[N, N];
        string[] numbers = new string[N];
        char[] separators = { ' ' };
        List<int> parsedNumbers = new List<int>();    
        using (reader)
        {
            
            string line=reader.ReadLine();
            N = int.Parse(line);
            numbers = new string[N];
            while (line!=null)
	        {
                line = reader.ReadLine();
                if (line==null)
                {
                    break;
                }
                numbers = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < N; i++)
                {
                    parsedNumbers.Add(int.Parse(numbers[i]));
                }
	        }
        }

        int maxSum=FillMatrix(matrix, N, parsedNumbers);
        StreamWriter writer = new StreamWriter(@"..\..\maxSum.txt");
        using (writer)
        {
            writer.Write(maxSum);
        }
    }

    static int FillMatrix(int[,] matrix,int n,List<int> parsedNumbers)
    {
        matrix=new int[n,n];
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = parsedNumbers[counter];
                counter++;
            }
        }
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        return bestSum;
    }
}

