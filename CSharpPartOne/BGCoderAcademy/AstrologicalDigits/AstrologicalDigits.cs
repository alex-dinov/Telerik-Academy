using System;
using System.Threading;
using System.Globalization;

class AstrologicalDigits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        string n = Console.ReadLine();
        decimal sum = 0;

        decimal num = 0;
        int x = 0;
        int y = 0;
       
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] != '-' && n[i] != '.')
            {
                sum += int.Parse(n[i].ToString());
            }          
        }
        if (sum <= 9)
        {
            Console.WriteLine(sum);
        }
        else
        {
            while (sum > 9)
            {
                do
                {
                    x = (int)sum % 10;
                    y = (int)sum / 10;
                    sum = x + y;
                    if (x + y < 9)
                    {
                        break;
                    }
                }
                while (sum < 9);               
            }
            Console.WriteLine(sum);
        }
    }
}

