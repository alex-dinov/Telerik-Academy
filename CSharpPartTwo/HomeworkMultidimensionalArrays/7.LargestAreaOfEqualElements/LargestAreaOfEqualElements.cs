using System;

class LargestAreaOfEqualElements
{    
    static bool[,] visited;
    static int[,] matrix =
    {
        {1,3,2,2,2,4},
        {3,3,3,2,4,4},
        {4,3,1,2,3,3},
        {4,3,1,3,3,1},
        {4,3,3,3,1,1},
    };

    static void Main()
    {
        int number = 0;
        int count = 0;
        int maxCount = 0;
        visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {              
                count = FindArea(j,i,matrix[i,j]);
                if (count > maxCount)
                {
                    maxCount = count;
                    number = matrix[i, j];
                }               
            }
        }       
        Console.WriteLine("The largest area is with element {0} and have size {1}",number,maxCount);
    }

    static int FindArea(int row, int col, int element)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }       
        if (visited[row,col])
        {
            return 0;  
        }      
        if (matrix[row, col] == element)
        {
            visited[row, col] = true;
            return 1 + FindArea(row + 1, col, element) + FindArea(row - 1, col, element) + FindArea(row, col + 1, element) + FindArea(row, col - 1, element);
        }
        return 0;
    }
}

