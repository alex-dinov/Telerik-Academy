using System;

class Carpets
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.Write(new string('.', N / 2 - 1) + new string('/', 1) + new string('\\', 1) + new string('.', N / 2 - 1));
        Console.WriteLine();

        string bSlash="/";
        string fSlash = "\\";
        for (int row = 2; row < N/2+1; row++)
        {
            if (row%2==0)
            {
                bSlash += " ";
                fSlash = " " + fSlash;
            }
            else
            {
                bSlash += "/";
                fSlash = "\\"+fSlash;
            }
            Console.Write(new string('.',N/2-row));
            Console.Write(bSlash+fSlash);
            Console.Write(new string('.', N / 2 - row));
            Console.WriteLine();
        }
        bSlash = bSlash.Replace("/", "\\");
        fSlash = fSlash.Replace("\\", "/");
        Console.WriteLine(bSlash+fSlash);
        int dot=1;
        int index = N / 2 - 1;
        for (int row = N/2+2; row <=N ; row++)
        {
            Console.Write(new string('.',dot));
            fSlash = fSlash.Remove(0, 1);
            bSlash = bSlash.Remove(index, 1);
            Console.Write(bSlash+fSlash);
            Console.Write(new string('.', dot));
            Console.WriteLine();
            dot++;
            index--;
        }
    }
}

