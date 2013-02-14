//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Enter radius r of a circle:");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the circle is:\n{0}",(2*Math.PI*r));
        Console.WriteLine("The area of the circle is:\n{0}",(Math.PI*r*r));
    }
}

