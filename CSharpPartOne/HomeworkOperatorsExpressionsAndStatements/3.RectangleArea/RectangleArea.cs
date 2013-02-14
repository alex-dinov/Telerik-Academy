//Write an expression that calculates rectangle’s area by given width and height.
using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle height:");
        int height = int.Parse(Console.ReadLine());
        int area = (2 * (height + width));
        Console.WriteLine("Rectangle's area is:\n"+area);
    }
}

