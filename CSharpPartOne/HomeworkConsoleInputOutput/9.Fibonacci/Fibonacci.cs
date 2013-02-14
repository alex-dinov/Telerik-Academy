//Write a program to print the first 100 members
//of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
using System;

class Fibonacci
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int sum = 0;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        for (int i = 1; i < 100; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(sum);
        }
    }
}

