using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareDataTypes
{
    class TestPerformance
    {
        static void Main(string[] args)
        {
            Add.AddDecimal(2m, 1000000m);
            Add.AddDouble(2d, 1000000d);
            Add.AddFloat(2f, 1000000f);
            Add.AddInt(2, 1000000);
            Add.AddLong(2L, 1000000L);

            Substract.SubstractDecimal(1000000m, 2m);
            Substract.SubstractDouble(1000000d, 2d);
            Substract.SubstractFloat(1000000f, 2f);
            Substract.SubstractInt(1000000, 2);
            Substract.SubstractLong(1000000L, 2L);

            Multiply.MultiplyDecimal(2m, 1000000m, 2m);
            Multiply.MultiplyDouble(2d, 1000000d, 2d);
            Multiply.MultiplyFloat(2f, 1000000f, 2f);
            Multiply.MultiplyInt(2, 1000000, 2);
            Multiply.MultiplyLong(2L, 1000000L, 2L);

            Divide.DivideDecimal(1000000m, 2m, 2m);
            Divide.DivideDouble(1000000d, 2d, 2d);
            Divide.DivideFloat(1000000f, 2f, 2f);
            Divide.DivideInt(1000000, 2, 2);
            Divide.DivideLong(1000000L, 2L, 2L);
        }
    }
}
