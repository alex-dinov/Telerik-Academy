using System;

class ComparingFloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal roundedFirstNumber = Math.Round(firstNumber,6);
        decimal roundedSecondNumber = Math.Round(secondNumber,6);
        if (roundedFirstNumber==roundedSecondNumber)
        {
            Console.WriteLine("The numbers are equal");
        }
        else if (roundedFirstNumber>roundedSecondNumber)
	    {
		    Console.WriteLine("The First number is greater than the second");
	    }
        else
        {
            Console.WriteLine("The Second Number is greater than the first");
        }   
    }
}

