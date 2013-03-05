using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Attribute
{
    [Version(1,0)]
    class Test
    {
        static void Main(string[] args)
        {
            Type type = typeof(Test);
            object[] Attribute = type.GetCustomAttributes(false);
            Console.WriteLine("The version of the class is: {0}", Attribute);
        }
    }
}
