using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class Deposit : Account, IInterest, IDeposit, IWithdraw
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            :base(customer,balance,interestRate)
        {
        }

        public decimal CalcInterestAmount(byte month)
        {
            if (month < 0)
            {
                throw new ArgumentException("The month cannot be negative!");
            }
            if (Balance < 1000)
            {
                this.InterestRate = 0;
            }
            return month * this.InterestRate;
        }

        public void MakeDeposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void MakeWithdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("The amount to withdraw cannot be bigger than the amount in balance!");
            }
            this.Balance -= amount;
        }
    }
}
