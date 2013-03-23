using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        public const int Count = 64;
        public ulong BitValue { get; set; }

        public override bool Equals(object obj)
        {
            BitArray64 array = obj as BitArray64;

            if (array == null)
            {
                return false;                
            }
            if (!Object.Equals(this.BitValue,array.BitValue))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.BitValue.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                ulong mask = (ulong) 1 << index;

                if ((mask & BitValue) == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Value can be 0 or 1.");
                }

                ulong mask = (ulong) 1 << index;

                if (value == 0)
                {
                    this.BitValue &= (~mask);
                }
                else
                {
                    this.BitValue |= mask;
                }
            }
        }

        public static bool operator ==(BitArray64 bitArray1, BitArray64 bitArray2)
        {
            return Object.Equals(bitArray1, bitArray2);
        }

        public static bool operator !=(BitArray64 bitArray1, BitArray64 bitArray2)
        {
            return !(Object.Equals(bitArray1, bitArray2));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<int>).GetEnumerator();
        }
    }
}
