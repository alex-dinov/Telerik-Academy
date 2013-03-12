using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Figures
{
    public abstract class Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Shape(float width,float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract float CalculateSurface();
    }
}
