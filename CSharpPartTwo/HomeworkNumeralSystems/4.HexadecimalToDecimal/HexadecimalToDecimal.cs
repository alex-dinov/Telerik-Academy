/*Write a program to convert hexadecimal numbers to their decimal representation.
*/
using System;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter hexadecimal number:");
        string n = Console.ReadLine();
        Console.WriteLine("The converted number in decimal is:");
        Console.WriteLine(ConvertHexadecimalToDecimal(n));
    }

    static int ConvertHexadecimalToDecimal(string n)
    {
        int sum = 0;
        int counter = n.Length - 1;
        for (int i = 0; i < n.Length; i++)
        {
            int number = n[i];
            if (number=='A')
            {
               number = 10;
            }
            else if (number == 'B')
            {
                number = 11;
            }
            else if (number == 'C')
            {
                number = 12;
            }
            else if (number == 'D')
            {
                number = 13;
            }
            else if (number == 'E')
            {
                number = 14;
            }
            else if (number == 'F')
            {
                number = 15;
            }
            else
            {
                number = number - '0';
            }

            sum += number * (int)Math.Pow(16, counter);          
            counter--;
        }
        return sum;
    }
}

