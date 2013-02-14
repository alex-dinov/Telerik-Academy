/*Write a program that reads a number N and calculates the sum of the first N members 
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
*/
using System;

class SumOfFibonacci
{
    static void Main()
    {
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        int nextNumber = 0;
        int sum = 1;

        if (n == 1)
        {
            Console.WriteLine("The sum of the first N members is 0 ");
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                sum = sum + nextNumber;
            }
            Console.WriteLine("The sum of the first N members is: " + sum);
        }
    }
}

