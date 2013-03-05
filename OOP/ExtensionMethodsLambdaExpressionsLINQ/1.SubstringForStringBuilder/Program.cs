using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SubstringForStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Tova OOP mi e golqma kasha");
            StringBuilder newStr = new StringBuilder();
            newStr = str.Substring(14,12);
            Console.WriteLine(newStr.ToString());
        }
    }
}
