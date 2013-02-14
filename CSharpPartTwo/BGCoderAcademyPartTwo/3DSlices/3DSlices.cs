using System;

class Slices3D
{
    static string input = Console.ReadLine();
    static string[] coord = input.Split(' ');
    static int width = int.Parse(coord[0]);
    static int height = int.Parse(coord[1]);
    static int depth = int.Parse(coord[2]);

    static int[, ,] cube = new int[width, height, depth];
   
    static void Main()
    {
        int maxSum = 0;
        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split('|');
            for (int d = 0; d < depth; d++)
            {
                string[] numbers = parts[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    int value = int.Parse(numbers[w]);
                    cube[w, h, d] = value;
                    maxSum += value;
                }
            }
        }
        int sum = 0;
        int count = 0;
        for (int w = 0; w < width-1; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    sum += cube[w, h, d];
                }
            }
            if (sum*2==maxSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int h = 0; h < height-1; h++)
        {
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    sum += cube[w, h, d];
                }
            }
            if (sum * 2 == maxSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int d = 0; d < depth-1; d++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    sum += cube[w, h, d];
                }
            }
            if (sum * 2 == maxSum)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

