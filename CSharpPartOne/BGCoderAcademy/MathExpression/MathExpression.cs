using System;
using System.Threading;
using System.Globalization;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal n = decimal.Parse(Console.ReadLine());      
        decimal m = decimal.Parse(Console.ReadLine());      
        decimal p = decimal.Parse(Console.ReadLine());

        decimal result = ((n * n + 1 / (m * p) + 1337) / (n - 128.523123123M * p)) + (decimal)Math.Sin((int)m%180);
        Console.WriteLine("{0:F6}",result);
    }
}

