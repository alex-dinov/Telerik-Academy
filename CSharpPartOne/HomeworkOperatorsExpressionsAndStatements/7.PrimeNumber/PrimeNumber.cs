//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
using System;

class PrimeNumber
{
    static void Main()
    {       
        Console.Write("Enter a positive integer number: ");        
        int number = int.Parse(Console.ReadLine());
        if (number<2)
        {
            Console.WriteLine("Not a prime");
            return;
        }
        uint maxDivider=(uint)Math.Sqrt(number);
        bool prime=true;
        for (int diveder = 2; prime &&(diveder <= maxDivider); diveder++)
        {
            if (number%diveder==0)
	        {
		        prime=false;
                break;
	        }                  
        }
        Console.WriteLine("Prime?: {0}", prime);   
    }
}

