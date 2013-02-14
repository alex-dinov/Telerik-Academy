//Write a program that reads two positive integer numbers and prints 
//how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
using System;

class NumbersDividedBy5
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        uint firstNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");       
        uint secondNumber = uint.Parse(Console.ReadLine());
        int p = 0;
        if (firstNumber <= secondNumber)
        {
            for (uint i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("There is {0} numbers p between the first and second number such that reminder of the division b 5 is 0 (inclusive)", p);
        }
        else if (firstNumber > secondNumber)
        {
            for (uint i = secondNumber; i <= firstNumber; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("There is {0} numbers p between the first and second number", p);  
        }       
    }
}
