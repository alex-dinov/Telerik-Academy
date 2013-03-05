using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IntegersDivisibleBy21
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda
            int[] arr = new int[] { 5, 2, 10, 3, 42, 105, 5, 5 };
            var divisibleBy21 = arr.Where(x => x % 21 == 0);
            foreach (var element in divisibleBy21)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------");

            //LINQ
            var divisibleBy21WithLINQ =
                from element in arr
                where element % 21 == 0
                select element;
            foreach (var element in divisibleBy21WithLINQ)
            {
                Console.WriteLine(element);
            }
            // TODO:7zad.
        }
    }
}
