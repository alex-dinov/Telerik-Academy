using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ExtensionMethodsIEnumerable
{
    public static class ExtensionMethodsIEnumerable
    {
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            decimal sum= 0;
            foreach (var item in collection)
            {
                sum += Convert.ToDecimal(item);
            }
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal product=1;
            foreach (var item in collection)
            {
                product*=Convert.ToDecimal(item);
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T: IComparable
        {
            T min = collection.ToList<T>()[0];
            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
           where T : IComparable
        {
            T max = collection.ToList<T>()[0];
            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
        {
            decimal average = 0;
            foreach (var item in collection)
            {
                average += Convert.ToDecimal(item);
            }
            return average / collection.Count();
        }
    }
}
