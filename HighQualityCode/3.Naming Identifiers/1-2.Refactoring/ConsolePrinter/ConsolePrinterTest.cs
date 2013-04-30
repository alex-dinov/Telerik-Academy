using System;
using System.Linq;

namespace ConsolePrinter
{
    class ConsolePrinterTest
    {
        const int MaxCount = 6;

        static void Main(string[] args)
        {
            ConsolePrinter printer = new ConsolePrinter();
            printer.Print(true);
        }
    }
}
