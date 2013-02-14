/** Modify your last program and try to make it work for any number type, not just integer 
 * (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
*/
using System;
using System.Collections.Generic;

class SetOfNumbers
{
    static void Main()
    {
       
        Console.WriteLine("The minimum of the set is : {0}", Min(1,2,10,15));
        Console.WriteLine("The maximum of the set is : {0}", Max(1,2,10,15));
        Console.WriteLine("The average of the set is : {0}", Average(1, 2.0, 10, 14));
        Console.WriteLine("The sum of the set is : {0}", Sum(1, 2, 10, 15));
        Console.WriteLine("The product of the set is : {0}", Product(1, 2, 10, 15));
    }

    static T Min<T>(params T[] arr)
    {
        dynamic min;
        dynamic bestMin = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            min = arr[i];
            if (min < bestMin)
            {
                bestMin = min;
            }
        }
        return bestMin;
    }

    static T Max<T>(params T[] arr)
    {
        dynamic max;
        dynamic bestMax = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            max = arr[i];
            if (max > bestMax)
            {
                bestMax = max;
            }
        }
        return bestMax;
    }

    static T Average<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }

    static T Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static T Product<T>(params T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}

