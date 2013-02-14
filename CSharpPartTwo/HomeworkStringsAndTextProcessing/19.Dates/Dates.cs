/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
 * Display them in the standard date format for Canada.
*/
using System;
using System.Globalization;
using System.Text.RegularExpressions;

class Dates
{
    static void Main()
    {
        string str = "I was born at 14.05.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        var reg = Regex.Matches(str, @"\b(\d{2}|\d{1})\.(\d{2}|\d{1})\.\d\d\d\d\b");
       
        foreach (var dates in reg)
        {
            Console.WriteLine(dates);
        }
    }
}

