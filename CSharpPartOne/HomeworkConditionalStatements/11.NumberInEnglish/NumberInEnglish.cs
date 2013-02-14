/** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"
*/
using System;

class NumberInEnglish
{
    static void Main()
    {
        string[] specials = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                             "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                             "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        int number;
        do
        {
            Console.Write("Enter a number from 1 to 999: ");
            number = int.Parse(Console.ReadLine());
        }
        while (number < 0 || number > 999);

        int firstDigit = number / 100;
        int secondDigit = number / 10;
        int digitHundreds = (number % 100) / 10;
        int firstDigitHundreds = number % 100;
        int thirdDigit = number % 10;
 
        if (number >= 0 && number < 20)
        {
            Console.WriteLine(specials[number]);
        }
        else if (number > 19 && number < 100)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(tens[secondDigit - 2]);
            }
            else
            {
                Console.WriteLine(tens[secondDigit - 2] + " " + specials[thirdDigit]);
            }
        }
        else if (number > 99 && number < 1000)
        {
            if (firstDigitHundreds == 0)
            {
                Console.WriteLine(specials[firstDigit] + " Hundred" );
            }
            else if (firstDigitHundreds > 0 && firstDigitHundreds < 20)
            {
                Console.WriteLine(specials[firstDigit] + " Hundred " + "and " + specials[firstDigitHundreds]);
            }
            else if (thirdDigit == 0)
            {
                Console.WriteLine(specials[firstDigit] + " Hundred " + tens[digitHundreds - 2]  );
            }
            else
            {
                Console.WriteLine(specials[firstDigit] + " Hundred " + tens[digitHundreds - 2] + " " + specials[thirdDigit]);
            }
        }
    }
}

