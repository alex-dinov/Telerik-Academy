using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr", "Array is null!");
        }

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("startIndex", "Start index cannot be negative!");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "Count cannot be negative!");
        }

        if (startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException("startIndex", "Start index cannot be larger than length of the array!");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("count, startIndex", "Sum of start index and count cannot be larger than length of the array!");
        }

        List<T> result = new List<T>();

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str", "String is null!");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "Count cannot be negative!");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count", "Count cannot be larger than length of the string!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        try
        {
            CheckPrime(23);
            Console.WriteLine("23 is prime.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
        }

        try
        {
            CheckPrime(33);
            Console.WriteLine("33 is prime.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
