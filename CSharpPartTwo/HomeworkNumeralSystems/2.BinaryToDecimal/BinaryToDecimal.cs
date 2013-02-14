/*Write a program to convert binary numbers to their decimal representation.
*/
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        int binary = int.Parse(Console.ReadLine());
        Console.WriteLine("The converted number in decimal is:");
        Console.WriteLine(ConvertBinaryToDecimal(binary));
    }

    static int ConvertBinaryToDecimal(int n)
    {
        int sum = 0;
        string dec = n.ToString();
        int counter = dec.Length-1;
        for (int i = 0; i < dec.Length; i++)
        {
            if (dec[i]=='1')
            {
                sum += (int)Math.Pow(2, counter);
            }
            counter--;
        }
        return sum;
    }
}
