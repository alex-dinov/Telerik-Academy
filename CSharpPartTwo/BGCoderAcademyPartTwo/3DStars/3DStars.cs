using System;
using System.Collections.Generic;

class Stars3D
{
    static string input = Console.ReadLine();
    static string[] coord = input.Split(' ');
    static int width = int.Parse(coord[0]);
    static int height = int.Parse(coord[1]);
    static int depth = int.Parse(coord[2]);

    static char[, ,] cube = new char[width, height, depth];

    static void Main()
    {
        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split();
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = parts[d][w];
                }
            }
        }
        Get3DStar(cube);
    }

    static void Get3DStar(char[,,] cube)
    {
        List<char> stars = new List<char>();
        int count = 0;
        for (int h = 1; h < height-1; h++)
        {
            for (int d = 1; d < depth-1; d++)
            {
                for (int w = 1; w < width-1; w++)
                {
                    if (cube[w,h,d]==cube[w-1,h,d] && cube[w,h,d]==cube[w+1,h,d] && cube[w,h,d]==cube[w,h-1,d] && cube[w,h,d]
                        ==cube[w,h+1,d] && cube[w,h,d]==cube[w,h,d-1] && cube[w,h,d]==cube[w,h,d+1])
                    {
                        count++;
                        stars.Add(cube[w, h, d]);
                    }
                }
            }
        }
        Dictionary<char, int> ouput = new Dictionary<char, int>();
        stars.Sort();
        int index = 1;
        for (int i = 0; i < stars.Count; i++)
        {
            while (i<stars.Count-1 && stars[i]==stars[i+1])
            {
                index++;
                i++;
            }
            ouput.Add(stars[i], index);
            index = 1;
        }
        Console.WriteLine(count);
        foreach (var item in ouput)
        {
            Console.WriteLine("{0} {1}",item.Key,item.Value );
        }
    }
}

