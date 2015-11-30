using System;

namespace BankOfKurtovoKonare
{
    using Interfaces;
    using System.Collections.Generic;

    public abstract class Accounts : IAccounts, IDeposit,IInterestRate
    {
        private double balance;
        private Customer customers;
        private double interestrate;


        public Accounts (double balance, Customer customers, double interestRate)
        {
            this.Balance = balance;
            this.Customers = customers;
            this.InterestRate = interestRate;
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public Customer Customers { get; set; }
        

        public double InterestRate
        {
            get
            {
                return this.interestrate;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cant be negative");
                }
                this.interestrate = value;
            }
        }

        public virtual double CalculateRate(int mounths)
        {
            double sum = 0;
            return sum = this.Balance * (1 + this.InterestRate * mounths);
        }
       

        public double Deposit(double amount)
        {
            return this.Balance += amount;
        }
       
    }
}
