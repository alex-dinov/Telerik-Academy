using System;

class MatrixD
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int numb = 1;
        int counter = 0;

        do
        {
            
            //down
            for (int col = counter; col <= counter; col++)
            {
                for (int row = counter; row < n-counter; row++)
                {
                    matrix[row, col] = numb;
                    numb++;
                }
            }

            //right
            for (int row = n-1-counter; row <= n-1-counter; row++)
            {
                for (int col = counter+1; col <= n-counter-1; col++)
                {
                    matrix[row, col] = numb;
                    numb++;
                }
            }

            //up
            for (int col = n-counter-1; col >= n-counter-1; col--)
            {
                for (int row = n-counter-2; row >= counter ; row--)
                {
                    matrix[row, col] = numb;
                    numb++;
                }
            }
            //left
            for (int row = counter; row <=counter ; row++)
            {
                for (int col = n-counter-2; col >= counter+1; col--)
                {
                    matrix[row, col] = numb;
                    numb++;
                }
            }

            counter++;

        } while (numb <= n*n);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

