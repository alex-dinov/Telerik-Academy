//Write a program that finds the biggest of three integers using nested if statements.
using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber==secondNumber && secondNumber==thirdNumber)
        {
            Console.WriteLine("The numbers are equal");
        }
        else if (firstNumber>secondNumber && firstNumber>=thirdNumber)
        {
            if (firstNumber==thirdNumber)
            {
                Console.WriteLine("The first and third numbers are the biggest");
            }
            else
            {
                Console.WriteLine("The first number is the biggest");
            }
        }
        else 
        {
            if (secondNumber>thirdNumber)
            {
                if (secondNumber==firstNumber)
                {
                    Console.WriteLine("The first and second numbers are the biggest");
                }
                else
                {
                    Console.WriteLine("The second number is the biggest");
                }
            }
            else if (thirdNumber>=secondNumber)
            {
                if (secondNumber==thirdNumber)
                {
                    Console.WriteLine("The second and third numbers are the biggest");
                }
                else
	            {
                    Console.WriteLine("The third number is the biggest");
	            }
            }
        }
    }
}

