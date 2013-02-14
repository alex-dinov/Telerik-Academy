/*Write a method that reverses the digits of given decimal number. Example: 256  652
*/
using System;

class ReverseDigitsInNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        ReverseDigits(n);
    }

    static void ReverseDigits(int n)
    {       
        string number = n.ToString();
        for (int i = number.Length-1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
    }
}