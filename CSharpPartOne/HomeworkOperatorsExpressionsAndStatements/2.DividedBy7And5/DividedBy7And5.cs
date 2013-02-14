//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
using System;

class DividedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        bool check = (number % 7 == 0) && (number % 5 == 0);
        Console.WriteLine("The number can be divided by 7 and 5 in the same time:\n"+check);
    }
}

