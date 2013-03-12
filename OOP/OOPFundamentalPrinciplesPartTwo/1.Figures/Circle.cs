using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Figures
{
    class Circle : Shape
    {
        public Circle(float radius):base(radius,radius)
        {
        }

        public override float CalculateSurface()
        {
            return (float)Math.PI * this.Height * this.Width;
        }
    }
}
