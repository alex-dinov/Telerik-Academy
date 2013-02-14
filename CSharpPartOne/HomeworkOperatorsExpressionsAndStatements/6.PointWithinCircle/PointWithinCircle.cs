//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Enter x coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y coordinate:");
        double y = double.Parse(Console.ReadLine());
        if (Math.Sqrt(x*x+y*y)<=5)
        {
            Console.WriteLine("The point is IN a circle K(0,5)");
        }
        else
        {
            Console.WriteLine("The point is OUT of a circle K(0,5)");
        }
    }
}

