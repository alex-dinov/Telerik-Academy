/*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
*/
using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year));
    }
}

