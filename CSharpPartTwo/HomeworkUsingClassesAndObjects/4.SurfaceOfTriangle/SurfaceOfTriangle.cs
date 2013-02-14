/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
*/
using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine(CalculateBySideAndAltitude(5,2));
        Console.WriteLine(CalculateByThreeSides(4,3,2));
        Console.WriteLine(CalculateByTwoSideAndAngle(2,3,4));
        
    }

    static double CalculateBySideAndAltitude(double a, double h)
    {
        double S = (a * h) / 2;
        return S;
    }

    static double CalculateByThreeSides(double a, double b, double c)
    {
        double P=(a+b+c)/2;
        double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        return S;
    }

    static double CalculateByTwoSideAndAngle(double a, double b, double y)
    {
        double S = (a * b * Math.Sin(y)) / 2;
        return S;
    }
}

