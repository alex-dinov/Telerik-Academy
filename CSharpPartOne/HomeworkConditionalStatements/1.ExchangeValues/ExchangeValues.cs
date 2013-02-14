//Write an if statement that examines two integer variables and exchanges their values if the first one is greater 
//than the second one.
using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int temp;
        if (firstNumber>secondNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        Console.WriteLine("First number:{0}",firstNumber);
        Console.WriteLine("Second number:{0}", secondNumber);
    }
}

