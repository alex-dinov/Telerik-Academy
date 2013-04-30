using System;
using System.Linq;

namespace ConsolePrinter
{
    internal class ConsolePrinter
    {
        public void Print(bool variable)
        {
            string variableAsString = variable.ToString();
            Console.WriteLine(variableAsString);
        }
    }
}
