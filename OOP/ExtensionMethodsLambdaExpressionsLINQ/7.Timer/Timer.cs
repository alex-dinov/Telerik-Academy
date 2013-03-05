using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public delegate void Delegate(int t);

    public class Timer
    {
        static void PrintOnConsole(int t)
        {
            while (true)
            {
                Thread.Sleep(t * 1000);
                Console.WriteLine("I'm sexy and i know it");
            }
        }

        static void Main(string[] args)
        {
            Delegate t = PrintOnConsole;
            t(1);
        }
    }
}
