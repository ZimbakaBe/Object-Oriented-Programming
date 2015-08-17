using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankOfKurtovoKonare
{
    abstract class Account : IAcount
    {
        public Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get; set; 
            
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance can't be negative.");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate can't be negative.");
                }
                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Customer: {0}\nBalance: {1}\nInterestRate: {2}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
