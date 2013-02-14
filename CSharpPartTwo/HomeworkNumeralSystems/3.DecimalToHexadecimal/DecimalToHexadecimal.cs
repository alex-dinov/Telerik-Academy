/*Write a program to convert decimal numbers to their hexadecimal representation.
*/
using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        ConvertDecimalToHexadecimal(n);
    }

    static void ConvertDecimalToHexadecimal(int n)
    {
        List<string> binary = new List<string>();
        while (n > 0)
        {
            int remainder=n%16;
            if (remainder==10)
	        {
		        binary.Add("A");
	        }
            else if (remainder==11)
	        {
		        binary.Add("B");
	        }
            else if (remainder==12)
	        {
		        binary.Add("C");
	        }
            else if (remainder==13)
	        {
		        binary.Add("D");
	        }
                else if (remainder==14)
	        {
		        binary.Add("E");
	        }
            else if (remainder==15)
	        {
		        binary.Add("F");
	        }
            else
	        {
                binary.Add(remainder.ToString());
	        }

            n /= 16;
        }
        binary.Reverse();
        foreach (var bit in binary)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }
}
