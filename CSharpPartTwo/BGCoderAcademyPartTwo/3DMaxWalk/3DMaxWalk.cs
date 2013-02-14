using System;

class MaxWalk3D
{
    static string input = Console.ReadLine();
    static string[] coord = input.Split(' ');
    static int width = int.Parse(coord[0]);
    static int height = int.Parse(coord[1]);
    static int depth = int.Parse(coord[2]);

    static int[, ,] cube = new int[width, height, depth];
    static bool[, ,] check = new bool[width, height, depth];

    static void Main()
    {
        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split('|');
            for (int d = 0; d < depth; d++)
            {
                string[] numbers = parts[d].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    int value = int.Parse(numbers[w]);
                    cube[w, h, d] = value;
                }
            }
        }
        int sum = 0;
        int[] point = new int[4];
        point[0] = width / 2;
        point[1] = height / 2;
        point[2] = depth / 2;
        point[3] = cube[point[0], point[1], point[2]];

        int[] wi = new int[4];
        wi[3] = -1001;
        int[] he = new int[4];
        he[3] = -1001;
        int[] de = new int[4];
        de[3] = -1001;
        while (CheckFree(point) && CheckOnlyOne(wi,he,de,point[3]))
        {
            sum += point[3];
            check[point[0], point[1], point[2]] = true;

            wi = CheckWidth(point);
            he = CheckHeight(point);
            de = CheckDepth(point);
            point=GetBestPoint(wi, he, de);
        }
        Console.WriteLine(sum);
    }

    static int[] CheckWidth(int[] point)
    {
        int[] curWidth = new int[4];
        curWidth[1] = point[1];
        curWidth[2] = point[2];
        curWidth[3] = -1001;
        for (int w = 0; w < width; w++)
        {
            if (point[0]!=w)
            {
                if (cube[w,point[1],point[2]] > curWidth[3])
                {
                    curWidth[3] = cube[w, point[1], point[2]];
                    curWidth[0] = w;
                }
            }
        }
        return curWidth;
    }

    static int[] CheckHeight(int[] point)
    {
        int[] curHeight = new int[4];
        curHeight[0] = point[0];
        curHeight[2] = point[2];
        curHeight[3] = -1001;
        for (int h = 0; h < height; h++)
        {
            if (point[1]!=h)
            {
                if (cube[point[0],h,point[2]] > curHeight[3])
                {
                    curHeight[3] = cube[point[0], h, point[2]];
                    curHeight[1] = h;
                }
            }
        }
        return curHeight;
    }

    static int[] CheckDepth(int[] point)
    {
        int[] curDepth = new int[4];
        curDepth[0] = point[0];
        curDepth[1] = point[1];
        curDepth[3] = -1001;
        for (int d = 0; d < depth; d++)
        {
            if (point[2]!=d)
            {
                if (cube[point[0],point[1],d] > curDepth[3])
                {
                    curDepth[3] = cube[point[0], point[1], d];
                    curDepth[2] = d;
                }
            }
        }
        return curDepth;
    }

    static bool CheckFree(int[] point)
    {
        if (check[point[0],point[1],point[2]])
        {
            return false;
        }
        return true;
    }

    static bool CheckOnlyOne(int[] w, int[] h, int[] d, int max)
    {
        int count = 0;
        if (w[3]==max)
        {
            count++;
        }
        if (h[3]==max)
        {
            count++;
        }
        if (d[3]==max)
        {
            count++;
        }
        if (count > 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static int[] GetBestPoint(int[] w, int[] h, int[] d)
    {
        if (w[3] >=h[3] && w[3]>=d[3])
        {
            return w;
        }
        else if (h[3] >= w[3] && h[3] >= d[3])
        {
            return h;
        }
        else
        {
            return d;
        }
    }
}

