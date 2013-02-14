//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;

class SumThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three numbers is:\n{0}",(firstNumber+secondNumber+thirdNumber));
    }
}

