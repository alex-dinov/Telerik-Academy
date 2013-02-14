/*Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
 * */
using System;

class Polynomials
{
    static void Main()
    {
        decimal[] first = { 2, 3, 5, 4 };
        PrintPol(first);
        Console.WriteLine();

        decimal[] second = { 5, 0, 1 };
        PrintPol(second);
        Console.WriteLine();

        decimal[] sum = AddPol(first, second);
        PrintPol(sum);
    }

    static decimal[] AddPol(decimal[] first, decimal[] second)
    {
        decimal[] sum=new decimal[Math.Max(first.Length,second.Length)];
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = first[i];
        }
        for (int i = 0; i < second.Length; i++)
        {
             sum[i] += second[i];
        }
        return sum;
    }

    static void PrintPol(decimal[] arr)
    {
        for (int i = arr.Length-1; i >=0 ; i--)
        {
            Console.Write(arr[i]+"x^"+i+(i==0 ? "\n " : "+"));
        }
    }
}

