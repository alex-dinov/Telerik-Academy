using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMCallHistoryTest 
    {
        static void Main(string[] args)
        {
            //zad.7
            GSMTest.PrintInfo();

            //Create an instance of the GSM class.
            GSM myPhone = new GSM("N95", "Nokia");

            //Add few calls.
            Call call = new Call(DateTime.Now, "0883333333", 60);
            Call nextCall = new Call(new DateTime(2013,02,10,20,34,20), "+3592376541212", 120);
            myPhone.AddCall(call);
            myPhone.AddCall(nextCall);

            //Display the information about the calls.
            foreach (var c in myPhone.CallHistory)
            {
                Console.WriteLine(c);
            }

            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.Write("The total price of the calls is: ");
            myPhone.PriceOfCalls(0.37m);

            //Remove the longest call from the history and calculate the total price again.
            Call longest = new Call();
            longest.Duration = 0;
            for (int i = 0; i < myPhone.CallHistory.Count; i++)
            {
                if (myPhone.CallHistory[i].Duration > longest.Duration)
                {
                    longest = myPhone.CallHistory[i];
                }
            }
            myPhone.RemoveCall(longest);
            Console.Write("The new price after removing longest call is: ");
            myPhone.PriceOfCalls(0.37m);

            //Finally clear the call history and print it.
            myPhone.ClearCallHistory();
            foreach (var c in myPhone.CallHistory)
            {
                Console.WriteLine(c);
            }
        }
    }
}
