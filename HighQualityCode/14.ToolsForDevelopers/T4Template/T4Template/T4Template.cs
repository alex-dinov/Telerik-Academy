using log4net;
using log4net.Config;
using System;
using System.Linq;

namespace ConsoleApplication1
{
    class T4Template
    {
        private static readonly ILog debug = LogManager.GetLogger("Debug");

        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            debug.Info("Program started");
            Console.WriteLine("Hello");
        }
    }
}
