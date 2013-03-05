using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3D
{
    public static class PathStorage
    {
        public static void PathSave(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../path.txt"))
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path PathLoad(string path)
        {
            Path loadPath = new Path();
            using (StreamReader reader=new StreamReader(path))
            {
                string line = reader.ReadLine();
                while (line!=null)
                {
                    string[] splited = line.Split(':');
                    string[] points = splited[1].Split(new char[]{',', '(',')',' '},StringSplitOptions.RemoveEmptyEntries);
                    Point3D point = new Point3D();
                    point.X = int.Parse(points[0]);
                    point.Y = int.Parse(points[1]);
                    point.Z = int.Parse(points[2]);
                    line = reader.ReadLine();
                    loadPath.AddPoint(point);
                }
            }
            Console.WriteLine("Path loaded!");
            return loadPath;
        }
    }
}
