/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/
using System;

class Numbers
{
    static void Main()
    {
        try
        {
            ReadNumber(1, 99);
        }
        catch (System.FormatException) 
        {
            Console.WriteLine("Not an integer number.");
        }
        catch (System.ArgumentOutOfRangeException) 
        {
            Console.WriteLine("The entered number is not in range."); 
        }
    }

    static void ReadNumber(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}

