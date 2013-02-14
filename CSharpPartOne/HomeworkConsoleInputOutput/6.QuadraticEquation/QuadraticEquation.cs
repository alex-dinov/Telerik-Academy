//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b:");       
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c:");       
        double c = double.Parse(Console.ReadLine());        
        double D = (b * b) - (4 * a * c);
        double x1 = -(b - Math.Sqrt(D)) / 2 * a;
        double x2 = -(b + Math.Sqrt(D)) / 2 * a;
        double x = -b /( 2 * a);
        if (D>0)
        {
            Console.WriteLine("The equation have 2 roots and they are:{0} and {1}", x1, x2);
        }
        else if (D==0)
        {
            Console.WriteLine("The equation have 1 root and he is:{0}",x);
        }
        else
        {
            Console.WriteLine("There are no real roots!");
        } 
    }
}

