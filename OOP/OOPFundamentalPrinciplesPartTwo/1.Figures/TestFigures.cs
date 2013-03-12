using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Figures
{
    class TestFigures
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(2.2f),
                new Triangle(2,4),
                new Rectangle(5,10)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0} surface = {1}",shape.GetType().Name.PadRight(10,' '),shape.CalculateSurface());
            }
        }
    }
}
