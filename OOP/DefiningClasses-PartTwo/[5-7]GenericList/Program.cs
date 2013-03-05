using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> nums = new GenericList<int>();
            nums.Add(1);
            nums.Remove(0);
            nums.Add(3);
            nums.Add(6);
            nums.Insert(100,1);
            nums.Add(10);
            nums.Remove(2);
            Console.WriteLine(nums.Min<int>());
            Console.WriteLine(nums.Max<int>());
            Console.WriteLine("------------------");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
