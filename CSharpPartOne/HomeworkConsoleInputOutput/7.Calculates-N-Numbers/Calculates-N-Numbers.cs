﻿//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
using System;

class CalculatesNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter the count of numbers:");
        int countNumbers = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= countNumbers; i++)
        {
            Console.WriteLine("Enter number {0}:",i);
            int number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The sum of the numbers is {0}", sum);
    }
}

