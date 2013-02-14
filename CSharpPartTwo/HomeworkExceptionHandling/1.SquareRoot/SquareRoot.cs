/*Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
*/
using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FindSqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    static double FindSqrt(int number)
    {
        if (number<0)
        {            
            throw new FormatException();
        }
        return Math.Sqrt(number);
    }
}

