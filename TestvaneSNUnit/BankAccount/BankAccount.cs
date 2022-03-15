using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
    public class BankAccount
    {
        public decimal balance;
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public BankAccount(decimal amount = 0)
        {
            this.balance = amount;
        }
        public void Deposit(decimal cash)
        {
            this.balance += cash;
        }
        public void Credit(decimal cash)
        {
            this.balance += cash;
        }
        public void Increase(double percent)
        {
            this.balance += this.balance * (decimal)percent / 100;
        }
        public void Bonus()
        {
            if(this.balance > 1000&&this.balance<2000)
            {
                this.balance += 100;
            }
            else if(this.balance>= 2000 &&this.balance < 3000)
            {
                this.balance += 200;
            }
            else if(this.balance>= 3000)
            {
                this.balance += 300;
            }
        }
        public void PaymentForCredit(decimal payment)
        {
            if(payment<=0)
            {
                throw new ArgumentException("Payment cannot be zero or negative!");
            }
            if(this.Balance<payment)
            {
                throw new ArgumentException("Not enough money!");
            }
            this.Balance -= payment;
        }
    }
}
