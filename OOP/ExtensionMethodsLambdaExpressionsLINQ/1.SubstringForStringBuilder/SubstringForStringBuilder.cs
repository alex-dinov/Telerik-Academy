using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SubstringForStringBuilder
{
    public static class SubstringForStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder output = new StringBuilder();
            if (index < 0 || index > input.Length)
            {
                throw new ArgumentException("Index out of range!");
            }
            if (length < 0 || length+index > input.Length)
            {
                throw new ArgumentException("Invalid length!");
            }
            int endIndex = index + length;
            for (int i = index; i < endIndex; i++)
            {
                output.Append(input[i]);
            }
            return output;
        }
    }
}
