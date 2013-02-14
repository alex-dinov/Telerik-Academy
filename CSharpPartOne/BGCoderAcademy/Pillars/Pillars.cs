using System;

class Pillars
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
        int leftCount = 0;
        int rightCount = 0;
        for (int pillar = 7; pillar >= 0; pillar--)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = pillar + 1; col < 8; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        leftCount++;
                    }
                }
            }
            for (int row = 0; row < 8; row++)
            {
                for (int col = pillar - 1; col >= 0; col--)
                {
                    if (matrix[row, col] == 1)
                    {
                        rightCount++;
                    }
                }
            }
            if (leftCount == rightCount)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(leftCount);
                break;
            }
            if (pillar==0)
            {
                break;
            }
            leftCount = 0;
            rightCount = 0;        
        }
        if (leftCount != rightCount)
        {
            Console.WriteLine("No");
        }
    }
}

