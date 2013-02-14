/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
 * Use variable number of arguments.
*/
using System;

class SetOfIntegers
{
    static void Main()
    {
        Console.Write("Enter lenght of the set:");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter number:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The minimum of the set is : {0}", Min(arr));
        Console.WriteLine("The maximum of the set is : {0}", Max(arr));
        Console.WriteLine("The average of the set is : {0}", Average(arr));
        Console.WriteLine("The sum of the set is : {0}",Sum(arr));
        Console.WriteLine("The product of the set is : {0}", Product(arr));
    }

    static int Min(int[] arr)
    {
        int min;
        int bestMin = int.MaxValue;
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

    static int Max(int[] arr)
    {
        int max ;
        int bestMax = int.MinValue;
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

    static int Average(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }

    static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static int Product(int[] arr)
    {
        int product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}

