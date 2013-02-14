/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in 
 * scientific notation. Format the output aligned right in 15 symbols.
*/
using System;
using System.Collections.Generic;

class DifferentFormat
{
    static void Main()
    {
        int numb = int.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("{0,15}", numb));
        Console.WriteLine(String.Format("{0,15:X}",numb));
        Console.WriteLine(String.Format("{0,15:P}", numb));
        Console.WriteLine(String.Format("{0,15:E}", numb));
    }
}

