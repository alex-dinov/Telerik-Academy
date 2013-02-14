/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/
using System;

class Tasks
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("Please choose what task , you want to solve:");
        Console.WriteLine("1.Reverse the digits of a number");
        Console.WriteLine("2.Calculate the average of a sequence of integers");
        Console.WriteLine("3.Solve a linear equation a * x + b = 0");
        Console.WriteLine();
        while (true)
        {
            ConsoleKeyInfo choise = Console.ReadKey(true);
            if (choise.KeyChar == '1') ReverseDigits();
            else if (choise.KeyChar == '2') Average();
            else if (choise.KeyChar == '3') Equation();
            Main();
        }
       
    }

    static void ReverseDigits()
    {
        Console.WriteLine("Please enter number:");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("The number must be positive!");
        }
        else
        {
            string number = n.ToString();
            Console.WriteLine("The reversed number is:");
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }
    }

    static void Average()
    {
        Console.WriteLine("Please enter lenght of the sequence:");
        int lenght = int.Parse(Console.ReadLine());
        if (lenght <= 0)
        {
            Console.WriteLine("The sequence should not be empty!");
        }
        else
        {
            decimal sum = 0;
            for (int i = 1; i <= lenght; i++)
            {
                Console.WriteLine("Please enter number:");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The average of the sequence is:");
            Console.WriteLine(sum / lenght);
        }
    }

    static void Equation()
    {
        Console.WriteLine("Enter a:");
        decimal a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a should not be equal to 0!");
        }
        else
        {
            Console.WriteLine("Enter b:");
            decimal b = int.Parse(Console.ReadLine());

            Console.WriteLine("The root is:");
            Console.WriteLine(-b / a);
        }
    }
}
