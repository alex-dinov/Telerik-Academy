//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
using System;

class SumWithAccuracy
{
    static void Main()
    {
        int a = 1;
        decimal sum=1;
        decimal newNumber=0;
        for (decimal i = 2; i < 10000; i++)
        {
            if (i%2==0)
            {
                 newNumber = (a /i);
                 sum = sum + newNumber; 
            }
            else
            {
                newNumber = -(a / i);
                sum = sum + newNumber;    
            }                          
        }
        Console.WriteLine("{0:N3}", sum);
    }
}

