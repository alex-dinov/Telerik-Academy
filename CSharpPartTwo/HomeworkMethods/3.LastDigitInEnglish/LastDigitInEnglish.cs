/*Write a method that returns the last digit of given integer as an English word. 
 * Examples: 512  "two", 1024  "four", 12309  "nine".
*/
using System;

class LastDigitInEnglish
{
    static void Main()
    {
        LastDigit();
    }

    static void LastDigit()
    {
        int n = int.Parse(Console.ReadLine());
        n = n % 10;
        switch (n)
        {
            case 1: 
                Console.WriteLine("one"); 
                break;
            case 2:
                Console.WriteLine("two"); 
                break;
            case 3:
                Console.WriteLine("three"); 
                break;
            case 4:
                Console.WriteLine("four"); 
                break;
            case 5:
                Console.WriteLine("five"); 
                break;
            case 6:
                Console.WriteLine("six"); 
                break;
            case 7:
                Console.WriteLine("seven"); 
                break;
            case 8:
                Console.WriteLine("eight"); 
                break;
            case 9:
                Console.WriteLine("nine"); 
                break;           
            default:
                Console.WriteLine("zero"); 
                break;
        }
    }
}

