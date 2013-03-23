using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitArray
{
    class TestBitArray
    {
        static void Main(string[] args)
        {
            BitArray64 arr = new BitArray64();
            arr[1] = 1;
            arr[2] = 1;

            foreach (var bit in arr)
            {
                Console.WriteLine(bit);
            }
        }
    }
}
