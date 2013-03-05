using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_GenericList
{
    public static class GenericExtensionMethods
    {
        public static T Min<T>(this GenericList<T> list)
            where T:IComparable
        {
            T min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min.CompareTo(list[i]) > 0)
                {
                    min = list[i];
                }
            }
            return min;
        }

        public static T Max<T>(this GenericList<T> list)
            where T : IComparable
        {
            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (max.CompareTo(list[i]) < 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
