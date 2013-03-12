using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Figures
{
    class Triangle : Shape
    {
        public Triangle(float width, float height):base(width,height)
        {
        }

        public override float CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
