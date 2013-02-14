/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
 * Use the Euclidean algorithm (find it in Internet).*/
using System;

class GreatestCommonDivisor
{
    static int GCD(int firstNumber, int secondNumber)
    {
        if (secondNumber == 0)
        {
            return firstNumber;
        }
        else
        {
            return GCD(secondNumber, firstNumber % secondNumber);
        }
    }
    static void Main()
    {
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The GCD is: " + GCD(firstNumber, secondNumber));
    }
}

