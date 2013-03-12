using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class TestBank
    {
        static void Main(string[] args)
        {
            Loan acc = new Loan(new Person("Gosho"), 2000,3.5m);
            Console.WriteLine(acc.CalcInterestAmount(3));
            acc.MakeDeposit(500);
            Console.WriteLine(acc.Balance);
        }
    }
}
