using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points3D
{
    public class Path
    {
        private List<Point3D> paths = new List<Point3D>();

        public List<Point3D> Paths
        {
            get { return this.paths; }
            set { this.paths = value; }
        }

        public void AddPoint(Point3D point)
        {
            paths.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            paths.Remove(point);
        }

        public void ClearPath()
        {
            paths.Clear();
        }
    }
}
