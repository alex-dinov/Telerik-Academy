/*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
*/
using System;
using System.Collections.Generic;

class AnyNumeralSystem
{
    static void Main()
    {
        Console.WriteLine("Please enter numeral system s:");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter numeral system d:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number:");
        string n = Console.ReadLine();

        MakeResult(s,d,n);
    }

    static int ConvertSystemToDecimal(int s,string n)
    {
        int sum = 0;
        int counter = n.Length - 1;
        for (int i = 0; i < n.Length; i++)
        {
            int number = n[i];
            if (number-'0' > 9)
            {
                number = number - '0'- 7;
            }
            else
            {
                number = number - '0';
            }
            sum += number * (int)Math.Pow(s, counter);
            counter--;
        }
        return sum;
    }

    static string ConvertDecimalToSystem(int n, int d)
    {
        string sum = "";
        List<string> remainders = new List<string>();
        while (n > 0)
        {
            int remainder = n % d;
            if (remainder == 10)
            {
                remainders.Add("A");
            }
            else if (remainder == 11)
            {
                remainders.Add("B");
            }
            else if (remainder == 12)
            {
                remainders.Add("C");
            }
            else if (remainder == 13)
            {
                remainders.Add("D");
            }
            else if (remainder == 14)
            {
                remainders.Add("E");
            }
            else if (remainder == 15)
            {
                remainders.Add("F");
            }
            else
            {
                remainders.Add(remainder.ToString());
            }
            n /= d;
        }
        remainders.Reverse();
        foreach (var ch in remainders)
        {
            sum+=ch;
        }
        return sum;
    }

    static void MakeResult(int s ,int d ,string n)
    {
        Console.WriteLine(ConvertDecimalToSystem(ConvertSystemToDecimal(s,n), d));
    }
}

