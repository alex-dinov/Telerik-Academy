using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<long> numbers = new List<long>();        
        long number=0;

        for (int i = 0; i < n; i++)
        {
            number = long.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int index = 0;
        numbers.Sort();

        while (numbers.Count>index)
        {
            if (index+1<numbers.Count)
            {
                if (numbers[index]==numbers[index+1])
                {
                    index += 2;
                }
                else
                {
                    Console.WriteLine(numbers[index]);
                    break;
                }
            }
            else
            {
                Console.WriteLine(numbers[index]);
                break;
            }
        }
    }
}

