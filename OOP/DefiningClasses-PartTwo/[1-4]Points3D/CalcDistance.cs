using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3D
{
    static class CalcDistance
    {
        static public double CalculateDistanceBetweenTwoPoints(Point3D A, Point3D B)
        {
            double distance = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2) + Math.Pow((A.Z - B.Z), 2));
            return distance;
        }
    }
}
