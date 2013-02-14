/*Write a method that calculates the number of workdays between today and given date, 
 * passed as parameter. Consider that workdays are all days from Monday to Friday except a 
 * fixed list of public holidays specified preliminary as array.
*/
using System;

class WorkDays
{
    static void Main()
    {
        Console.WriteLine("Enter future date in that format(dd.mm.year):");
        string futureDate=Console.ReadLine();

        DateTime endDate = DateTime.Parse(futureDate);
        Console.WriteLine("There is {0} workdays between today and the chosen date", FindWorkdays(endDate));
    }

    static int FindWorkdays(DateTime endDate=new DateTime())
    {
        int workdays=0;
        DateTime startDate = DateTime.Today;
        int difference = Math.Abs((endDate - startDate).Days);

        DateTime[] holidays=
        {
            new DateTime(2014, 1, 1),
            new DateTime(2013, 3, 1),
            new DateTime(2013, 5, 24),
            new DateTime(2012, 9, 6),
            new DateTime(2013, 12, 25)
        };
        bool holiday = false;
        for (int i = 0; i < difference; i++)
        {
            startDate=startDate.AddDays(1);
            if (startDate.DayOfWeek != DayOfWeek.Sunday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDate.Date==holidays[j])
                    {
                        holiday = true;
                    }
                }
                if (!holiday)
                {
                    workdays++;
                }
            }
            holiday = false;
        }
        return workdays;  
    }
}

