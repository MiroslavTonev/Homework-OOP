using System;

namespace BankOfKurtovoKonare
{
    public class Mortgage : Accounts
    {
        public Mortgage(double balance, Customer customers, double interestRate) : base(balance, customers, interestRate)
        {
        }

        public override double CalculateRate(int mounths)
        {
            double sum = 0;
            if(mounths <= 12 && this.Customers is Companies)
            {
                sum = this.Balance * (1 + (this.InterestRate / 2) * mounths);
            }
            else if(mounths <= 6 && this.Customers is IndividualCustomer)
            {
                sum = this.Balance * (1 + this.InterestRate * mounths);
            }
            else
            {
                sum = this.Balance * (1 + (this.InterestRate / 2) * mounths);
            }
            return sum;
        }

    }
}
