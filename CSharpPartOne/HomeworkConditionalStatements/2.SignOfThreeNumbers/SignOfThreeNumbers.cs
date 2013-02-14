//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.
using System;

class SignOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product of three numbers is zero");
        }
        else if (firstNumber>0 && secondNumber>0 && thirdNumber>0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber<0 && secondNumber<0 && thirdNumber<0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber>0 && secondNumber>0 && thirdNumber<0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber<0 && secondNumber<0 && thirdNumber>0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
    }
}

