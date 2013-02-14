using System;

class FormulaBit1
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            int N = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                if ((N & (1 << col)) != 0)
                {
                    matrix[row, col] = 1;
                }
            }
        }

        int lenght = 1;
        int turn = -1;
        int trackRow = 0;
        int trackCol = 0;
       
        if (matrix[trackRow,trackCol]==1)
        {
            Console.WriteLine("No"+" "+0);
            return;
        }

        while (true)
        {
            //down
            turn++;
            while (trackRow < 7 && matrix[trackRow+1, trackCol] == 0)
            {
                trackRow++;
                lenght++;
            }
            if (trackRow == 7 && trackCol == 7)
            {
                Console.WriteLine(lenght + " " + turn);
                return;
            }
            if (trackCol < 7 && matrix[trackRow, trackCol + 1] != 0)
            {
                Console.WriteLine("No" + " " + lenght);
                return;
            }          
            //left
            turn++;
            while (trackCol < 7 && matrix[trackRow, trackCol+1] == 0)
            {
                trackCol++;
                lenght++;
            }         
            if (trackRow == 7 && trackCol == 7)
            {
                Console.WriteLine(lenght + " " + turn);
                return;
            }
            if (trackRow > 0 && matrix[trackRow - 1, trackCol] != 0)
            {
                Console.WriteLine("No" + " " + lenght);
                return;
            }
            //up
            turn++;
            while (trackRow > 0 && matrix[trackRow-1, trackCol] == 0)
            {
                trackRow--;
                lenght++;
            }         
            if (trackRow == 7 && trackCol == 7)
            {
                Console.WriteLine(lenght + " " + turn);
                return;
            }
            if (trackCol == 7)
            {
                Console.WriteLine("No" + " " + lenght);
                return;
            }
            if (trackCol < 7 && matrix[trackRow, trackCol + 1] != 0)
            {
                Console.WriteLine("No" + " " + lenght);
                return;
            }          
            //left
            turn++;
            while (trackCol < 7 && matrix[trackRow, trackCol+1] == 0)
            {
                trackCol++;
                lenght++;
            }        
            if (trackRow == 7 && trackCol == 7)
            {
                Console.WriteLine(lenght + " " + turn);
                return;
            }
            if (trackRow < 7 && matrix[trackRow + 1, trackCol] != 0)
            {
                Console.WriteLine("No" + " " + lenght);
                return;
            }
        }
    }
}

