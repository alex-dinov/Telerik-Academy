using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public abstract class Account
    {
        public Customer Customer { get; private set; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; protected set; }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            if (balance < 0 || interestRate < 0 || interestRate > 100)
            {
                throw new ArgumentException("Invalid arguments");
            }
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
    }
}
