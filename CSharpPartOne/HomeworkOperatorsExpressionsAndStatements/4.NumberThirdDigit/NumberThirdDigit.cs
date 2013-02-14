//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
using System;

class NumberThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int newNumber1 = number / 100;
        int newNumber2 = newNumber1 % 10;
        bool check = newNumber2 == 7;
        Console.WriteLine("The third digit of a number is 7(right to left):\n"+check);
    }
}

