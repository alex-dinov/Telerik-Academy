using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _3.MathFuncComparsion
{
    public class TestPerformance
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Sqrt.CalculateSqrtDouble(2d, 10000d, 0.002d);

            Sqrt.CalculateSqrtDecimal(2m, 10000m, 0.002m);

            Sqrt.CalculateSqrtFloat(2f, 10000f, 0.002f);

            Log.CalculateLogDouble(2d, 10000d, 0.002d);

            Log.CalculateLogDecimal(2m, 10000m, 0.002m);

            Log.CalculateLogFloat(2f, 10000f, 0.002f);

            Sinus.CalculateSinDouble(2d, 10000d, 0.002d);

            Sinus.CalculateSinDecimal(2m, 10000m, 0.002m);

            Sinus.CalculateSinFloat(2f, 10000f, 0.002f);
        }
    }
}
