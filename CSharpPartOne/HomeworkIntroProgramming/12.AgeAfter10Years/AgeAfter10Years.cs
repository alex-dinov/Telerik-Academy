using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Your age:");
        int age = int.Parse(Console.ReadLine());
        int birthYear = DateTime.Now.Year - age;
        DateTime ageAfter10Years = DateTime.Now.AddYears(10);
        int futureAge = ageAfter10Years.Year - birthYear;
        Console.WriteLine("Your age after 10 years:\n{0} ",futureAge);
    }
}

