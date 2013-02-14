using System;

class TelerikLogo
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int middleDots = n + n - 3;
        Console.WriteLine(new string('.',n/2)+new string('*',1)+new string('.',middleDots)+new string('*',1)+new string('.',n/2));
        
        
        for (int i = 1; i < n/2+1; i++)
        {
            middleDots-=2;
            Console.Write(new string('.', n / 2 - i) + new string('*', 1) + new string('.', 2 * i - 1) + new string('*', 1)+
                new string('.', middleDots) + new string('*', 1) + new string('.', 2 * i - 1) + new string('*', 1) + new string('.', n / 2 - i));
            Console.WriteLine();
        }
        int endDots = 0;
        for (int i = middleDots; i >1 ; i=i-2)
        {
            middleDots -= 2;
            Console.Write(new string('.', n+endDots) + new string('*', 1) + new string('.', middleDots) + new string('*', 1) + new string('.', n+endDots));
            Console.WriteLine();
            endDots++;
        }
        Console.Write(new string('.', n+endDots) + new string('*', 1) + new string('.', n+endDots));
        Console.WriteLine();

        for (int i = 0; i < n-1; i++)
        {
            endDots--;
            Console.Write(new string('.', n + endDots) + new string('*', 1) + new string('.', middleDots) + new string('*', 1) + new string('.', n + endDots));
            Console.WriteLine();
            middleDots += 2;
        }
        
        middleDots -= 2;
        for (int i = 0; i < n-2; i++)
        {
            endDots++;
            middleDots -= 2;
            Console.Write(new string('.', n + endDots) + new string('*', 1) + new string('.', middleDots) + new string('*', 1) + new string('.', n + endDots));
            Console.WriteLine();           
        }
        endDots++;
        Console.Write(new string('.', n + endDots) + new string('*', 1) + new string('.', n + endDots));
        Console.WriteLine();
    }
}

