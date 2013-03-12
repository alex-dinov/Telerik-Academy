using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class Mortgage : Account, IInterest, IDeposit
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            :base(customer,balance,interestRate)
        {
        }

        public  decimal CalcInterestAmount(byte month)
        {
            if (month < 0)
            {
                throw new ArgumentException("The month cannot be negative!");
            }
            if (month <= 12  && Customer is Company)
            {
                this.InterestRate = 50;
            }
            if (month <= 6 && Customer is Person)
            {
                this.InterestRate = 0;
            }
            return month * this.InterestRate;
        }

        public void MakeDeposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
