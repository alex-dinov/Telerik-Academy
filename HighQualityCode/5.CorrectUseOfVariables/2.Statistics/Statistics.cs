using System;
using System.Linq;

namespace _2.Statistics
{
    public class Statistics
    {
        public static void PrintStatistics(double[] dataNumbers)
        {
            Console.WriteLine(GetMaxNumber(dataNumbers));
            Console.WriteLine(GetMinNumber(dataNumbers));
            Console.WriteLine(CalculateAverage(dataNumbers));
        }

        public static double GetMaxNumber(double[] dataNumbers)
        {
            double maxNumber = dataNumbers[0];
            for (int i = 1; i < dataNumbers.Length; i++)
            {
                if (dataNumbers[i] > maxNumber)
                {
                    maxNumber = dataNumbers[i];
                }
            }

            return maxNumber;
        }

        public static double GetMinNumber(double[] dataNumbers)
        {
            double minNumber = dataNumbers[0];
            for (int i = 1; i < dataNumbers.Length; i++)
            {
                if (dataNumbers[i] < minNumber)
                {
                    minNumber = dataNumbers[i];
                }
            }

            return minNumber;
        }

        public static double CalculateAverage(double[] dataNumbers)
        {
            double sum = 0;
            for (int i = 0; i < dataNumbers.Length; i++)
            {
                sum += dataNumbers[i];
            }

            double average = sum / dataNumbers.Length;
            return average;
        }

        private static void Main(string[] args)
        {
            double[] dataNumbers = new double[] { 3, 2.22, 0.55, 5, 10.5, 33 };
            PrintStatistics(dataNumbers);
        }
    }
}
