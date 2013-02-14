//Write an expression that checks if given integer is odd or even.
using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number =int.Parse(Console.ReadLine());
        bool check = number % 2 == 0;
        Console.WriteLine("The number is even:\n" +check);
    }
}

