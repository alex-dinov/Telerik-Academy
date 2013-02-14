using System;

class FighterAttack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int maxX = Math.Max(px1, px2);
        int minX = Math.Min(px1, px2);
        int minY = Math.Min(py1, py2);
        int maxY = Math.Max(py1, py2);
        int planeX = fx + d;
        int planeY = fy;
        int damage = 0;

        if (((planeX >= minX) && (planeX <= maxX)) && ((planeY >= minY) && (planeY <= maxY)))
        {
            damage += 100;
        }

        if ((((planeX + 1) >= minX) && ((planeX + 1) <= maxX)) && ((planeY >= minY) && (planeY <= maxY)))
        {
            damage += 75;
        }

        if (((planeX >= minX) && (planeX <= maxX)) && (((planeY + 1) >= minY) && ((planeY + 1) <= maxY)))
        {
            damage += 50;
        }

        if (((planeX >= minX) && (planeX <= maxX)) && (((planeY - 1) >= minY) && ((planeY - 1) <= maxY)))
        {
            damage += 50;
        }
        Console.WriteLine(damage + "%");
    }
}

