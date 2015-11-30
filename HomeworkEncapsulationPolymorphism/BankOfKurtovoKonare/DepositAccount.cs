using System;
using System.Collections.Generic;

namespace BankOfKurtovoKonare
{
    using Interfaces;
    public class DepositAccount : Accounts, IWithdrow
    {
        public DepositAccount (double balance, Customer customers, double interestRate)
            : base(balance, customers, interestRate)
        {

        }            

        public override double CalculateRate(int mounths)
        {
            double sum = 0;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return this.Balance;
            }

            return sum = this.Balance * (1 + this.InterestRate * mounths);
        }

        public double Withdrow(double amount)
        {
            return this.Balance -= amount;
        }
    }
}
