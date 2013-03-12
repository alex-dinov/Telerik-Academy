using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InvalidRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int start = 1;
                int end = 100;

                int number = 101;
                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>("Number out of range!", start, end);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0} Range:  Start= {1} End= {2}",ex.Message,ex.Start,ex.End);   
            }

            Console.WriteLine("-----------------------------");

            try
            {
                DateTime start = new DateTime(1980, 1, 1);
                DateTime end = new DateTime(2013, 12, 31);

                DateTime date = new DateTime(2018, 12, 12);
                if (date < start || date > end)
                {
                     throw new InvalidRangeException<DateTime>("Date out of range!", start, end);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0} Range:  Start= {1} End= {2}", ex.Message, ex.Start, ex.End);   
            }
        }
    }
}
