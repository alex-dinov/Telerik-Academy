using System;

class ShipDamage
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());

        int maxX = Math.Max(sx1, sx2);
        int minX = Math.Min(sx1, sx2);
        int minY = Math.Min(sy1, sy2);
        int maxY = Math.Max(sy1, sy2);
        int catapult1X = cx1;
        int catapult1Y = (2 * h - cy1);
        int catapult2X = cx2;
        int catapult2Y = (2 * h - cy2);
        int catapult3X = cx3;
        int catapult3Y = (2 * h - cy3);
        int damage = 0;

        //catapult 1
        if (((catapult1X > minX) && (catapult1X < maxX)) && ((catapult1Y > minY) && (catapult1Y < maxY)))
        {
            damage += 100;
        }
        if ((catapult1X==maxX && (catapult1Y==minY || catapult1Y==maxY)) || ((catapult1X==minX && (catapult1Y==minY || catapult1Y==maxY))))
        {
            damage += 25;
        }
        if ((catapult1X > minX) && (catapult1X < maxX) && ((catapult1Y == minY) || (catapult1Y==maxY)))
        {
            damage += 50;
        }
        if ((catapult1Y > minY) && (catapult1Y < maxY) && (catapult1X == minX || catapult1X == maxX))
        {
            damage += 50;
        }

        //catapult 2
        if (((catapult2X > minX) && (catapult2X < maxX)) && ((catapult2Y > minY) && (catapult2Y < maxY)))
        {
            damage += 100;
        }
        if ((catapult2X == maxX && (catapult2Y == minY || catapult2Y == maxY)) || ((catapult2X == minX && (catapult2Y == minY || catapult2Y == maxY))))
        {
            damage += 25;
        }
        if ((catapult2X > minX) && (catapult2X < maxX) && ((catapult2Y == minY) || (catapult2Y == maxY)))
        {
            damage += 50;
        }
        if ((catapult2Y > minY) && (catapult2Y < maxY) && (catapult2X == minX || catapult2X == maxX))
        {
            damage += 50;
        }

        //catapult 3
        if (((catapult3X > minX) && (catapult3X < maxX)) && ((catapult3Y > minY) && (catapult3Y < maxY)))
        {
            damage += 100;
        }
        if ((catapult3X == maxX && (catapult3Y == minY || catapult3Y == maxY)) || ((catapult3X == minX && (catapult3Y == minY || catapult3Y == maxY))))
        {
            damage += 25;
        }
        if ((catapult3X > minX) && (catapult3X < maxX) && ((catapult3Y == minY) || (catapult3Y == maxY)))
        {
            damage += 50;
        }
        if ((catapult3Y > minY) && (catapult3Y < maxY) && (catapult3X == minX || catapult3X == maxX))
        {
            damage += 50;
        }
        Console.WriteLine(damage + "%");
    }
}

