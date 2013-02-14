//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height h:");
        double heightH = double.Parse(Console.ReadLine());
        double sum = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("Trapezoid's area is:{0}",sum);
    }
}

