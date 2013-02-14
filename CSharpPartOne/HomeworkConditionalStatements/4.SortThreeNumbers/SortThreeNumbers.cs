//Sort 3 real values in descending order using nested if statements.
using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        int temp;

        if (secondNumber>firstNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            if (thirdNumber>secondNumber)
            {
                temp = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = temp;
            }
            if (secondNumber>firstNumber)
            {
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }
        }
        if (thirdNumber>secondNumber)
        {
            temp = thirdNumber;
            thirdNumber = secondNumber;
            secondNumber = temp;
            if (secondNumber>firstNumber)
            {
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }
        }
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);
    }
}

