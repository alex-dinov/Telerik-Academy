using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D pointA = new Point3D(21,10,15);
            Point3D pointB = new Point3D();
            Console.WriteLine(CalcDistance.CalculateDistanceBetweenTwoPoints(pointA, pointB));
            Point3D pointC = Point3D.PointO;
            Path shortPath = new Path();
            shortPath.AddPoint(pointA);
            shortPath.AddPoint(pointC);
            PathStorage.PathSave(shortPath);
            PathStorage.PathLoad(@"../../path.txt");
        }
    }
}
