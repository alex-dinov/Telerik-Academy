using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> a = new Matrix<int>(3, 3);
            Matrix<int> b = new Matrix<int>(3, 3);

            Random rand = new Random();
            for (int i = 0; i < a.Row; i++)
            {
                for (int j = 0; j < a.Col; j++)
                {
                    a[i, j] = rand.Next(0, 10);
                    b[i, j] = rand.Next(0, 10);
                }
            }

            Console.WriteLine("Matrix a:\n{0}",a);
            Console.WriteLine("Matrix b:\n{0}", b);
            Console.WriteLine("Addition Matrices:\n{0}\nSubstraction Matrices:\n{1}\nMultiplication Matrices:\n{2}"
                , a + b, a - b, a * b);

            if (a) Console.WriteLine("Not empty matrix!");
            else Console.WriteLine("Empty matrix!");
        }
    }
}
