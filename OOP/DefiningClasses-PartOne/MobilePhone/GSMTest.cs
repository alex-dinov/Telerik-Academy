using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        public static void PrintInfo()
        {
            GSM[] test = new GSM[3];

            Battery batt = new Battery(BatteryType.NiMH, 100, 20);
            Display disp =new Display(10,56000);

            GSM firstPhone = new GSM("Galaxy", "Samsung", 200,"Me",batt,disp);
            GSM secondPhone = new GSM("N95", "Nokia", 800);
            GSM thirdPhone = GSM.IPhone4S;

            test[0] = firstPhone;
            test[1] = secondPhone;
            test[2] = thirdPhone;

            foreach (GSM phone in test)
            {
                Console.WriteLine(phone);
                Console.WriteLine();
            }
        }
    }
}
