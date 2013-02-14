//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;

class PointWithinCircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y coordinate:");
        double y = double.Parse(Console.ReadLine());
        double pointXforCircle = Math.Abs(x - 1);
        double pointYforCircle = Math.Abs(y - 1);
        bool inCircle=false;
        bool inRectangle=false;
        if (Math.Sqrt(pointXforCircle * pointXforCircle + pointYforCircle * pointYforCircle )<= 3)
        {
            inCircle = true;
        }
        if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
        {
            inRectangle = true;
        }
        if (inCircle && !inRectangle)
        {
            Console.WriteLine("The point is IN the circle and OUT of the rectangle ");           
        }
        else if (!inCircle && inRectangle)
        {
            Console.WriteLine("The point is OUT of the circle and IN the rectangle ");
        }
        else if (inCircle && inRectangle)
        {
            Console.WriteLine("The point is IN the circle and IN the rectangle ");
        }
        else
        {
            Console.WriteLine("The point is OUT of the circle and OUT of the rectangle ");
        }
    }
}

