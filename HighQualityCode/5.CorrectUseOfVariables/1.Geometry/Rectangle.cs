using System;
using System.Linq;

namespace _1.Geometry
{
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        public static Rectangle GetTransformedRectangle(Rectangle rectangle, double transformedAngle)
        {
            double width = Math.Abs(Math.Cos(transformedAngle)) * rectangle.Width + Math.Abs(Math.Sin(transformedAngle)) * rectangle.Height;
            double height = Math.Abs(Math.Sin(transformedAngle)) * rectangle.Width + Math.Abs(Math.Cos(transformedAngle)) * rectangle.Height;
            Rectangle transformedRectangle = new Rectangle(width, height);
            return transformedRectangle;
        }

        private static void Main(string[] args)
        {
        }
    }
}
