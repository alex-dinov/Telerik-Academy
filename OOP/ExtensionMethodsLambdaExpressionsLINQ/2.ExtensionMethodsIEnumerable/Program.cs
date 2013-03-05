using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExtensionMethodsIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>(){5,2,3,1,10,2};
            Console.WriteLine("Max:{0}\nMin:{1}\nAverage:{2}\nSum:{3}\nProduct:{4}", list.Max<int>(), list.Min<int>(), list.Average<int>(), list.Sum<int>(), list.Product<int>());
        }
    }
}
