/*Write a program that reads a date and time given in the format: day.month.year hour:minute:
 * second and prints the date and time after 6 hours and 30 minutes (in the same format) 
 * along with the day of week in Bulgarian.
*/
using System;
using System.Globalization;

class DateAndTime
{
    static void Main()
    {
        string date = "30.01.2013 22:56:30";
        CultureInfo provider = new CultureInfo("bg-BG");

        DateTime day = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", provider);
        day = day.AddHours(6);
        day = day.AddMinutes(30);

        Console.WriteLine(day);
        Console.WriteLine(day.ToString("dddd", provider));
    }
}
