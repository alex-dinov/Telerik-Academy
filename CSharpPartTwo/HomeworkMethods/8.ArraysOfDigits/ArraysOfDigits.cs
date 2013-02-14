/*Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
*/
using System;
using System.Collections.Generic;

class ArraysOfDigits
{
    static void Main()
    {
        string n = Console.ReadLine();
        string m = Console.ReadLine();
        AddDigits(n, m);
    }

    static void AddDigits(string n, string m)
    {
        int[] arr1 = new int[10000];
        int[] arr2 = new int[10000];
        int counter = 0;

        for (int i = n.Length-1; i >= 0 ; i--)
        {
            arr1[i] = int.Parse(n.Substring(counter,1));
            counter++;
        }
        counter = 0;
        for (int i = m.Length-1; i >= 0; i--)
        {
            arr2[i] = int.Parse(m.Substring(counter, 1));
            counter++;
        }

        int[] sum=new int[10001];
        for (int i = 0; i < sum.Length-1; i++)
        {
            if (i==0)
            {
                sum[i] = ((arr1[i] + arr2[i]) % 10);
            }
            if(i > 0)
            {
                sum[i] = ((arr1[i] + arr2[i]) % 10 + (arr1[i - 1] + arr2[i - 1]) / 10);
                if (sum[i] > 9)
                {
                    arr1[i]++;
                    sum[i] = 0;
                }
            }
        }
        PrintSum(sum);
    }

    static void PrintSum(int[] sum)
    {
        bool findedNumber=false;
        for (int i = sum.Length-1; i >=0 ; i--)
        {
            if (sum[i]!=0)
            {
                findedNumber = true;
            }
            if (findedNumber)
            {
                Console.Write(sum[i]);
            }
        }
        Console.WriteLine();
    }
}

