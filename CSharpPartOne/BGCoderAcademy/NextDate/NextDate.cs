using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        if (day == 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
        {
            day = 1;
            month += 1;
            if (month==13)
            {
                month = 1;
                year += 1;
            }
            Console.WriteLine(day + "." + month + "." + year);
            return;
        }
        if (day==30 && (month==4 || month ==6 || month==9 || month==11))
        {
            day = 1;
            month += 1;
            Console.WriteLine(day + "." + month + "." + year);
            return;
        }
        if (month==2)
        {
            if ((year==2000 || year==2004 || year==2008 || year==2012) && day==29)
            {
                day = 1;
                month += 1;
                Console.WriteLine(day + "." + month + "." + year);
                return;
            }
            else if (day == 28 && (year == 2001 || year == 2002 || year == 2003 || year == 2005 || year == 2006 || year == 2007 || year == 2009 || year == 2010 || year==2011 || year==2013))
            {
                day = 1;
                month += 1;
                Console.WriteLine(day + "." + month + "." + year);
                return;
            }
        }
        Console.WriteLine(day + 1 + "." + month + "." + year);
    }
}

