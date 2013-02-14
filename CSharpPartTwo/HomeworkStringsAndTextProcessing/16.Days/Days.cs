/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
*/
using System;

class Days
{
    static void Main()
    {
        Console.WriteLine("Enter the first date:");
        string firstDate = Console.ReadLine();
        DateTime fd = DateTime.Parse(firstDate);
        Console.WriteLine("Enter the second date:");
        string secondDate = Console.ReadLine();
        DateTime sd = DateTime.Parse(secondDate);
        string distance = (sd.Date - fd.Date).TotalDays.ToString();
        Console.WriteLine("Distance:{0} days",distance);
    }
}
