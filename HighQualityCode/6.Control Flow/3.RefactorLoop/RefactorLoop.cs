using System;
using System.Linq;

namespace _3.RefactorLoop
{
    public class RefactorLoop
    {
        private static void Main(string[] args)
        {
            int[] array = new int[100];
            Random randomGenerator = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(1, 11);
            }

            int expectedValue = 5;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
