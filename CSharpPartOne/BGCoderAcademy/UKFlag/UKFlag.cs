using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int endDots = 0;
        int middleDots = n / 2 - 1;
        for (int row = 0; row < n/2; row++)
        {
            Console.Write(new string('.',endDots)+new string('\\',1)+new string('.',middleDots)+new string('|',1)
                +new string('.',middleDots)+new string('/',1)+new string('.',endDots)+"\n");
            endDots++;
            middleDots--;
        }
        Console.WriteLine(new string('-', n / 2) + new string('*', 1) + new string('-', n / 2));
        endDots--;
        middleDots++;
        for (int row = 0; row < n/2; row++)
        {
             Console.Write(new string('.',endDots)+new string('/',1)+new string('.',middleDots)+new string('|',1)
                +new string('.',middleDots)+new string('\\',1)+new string('.',endDots)+"\n");
             endDots--;
             middleDots++;
        }
    }
}

