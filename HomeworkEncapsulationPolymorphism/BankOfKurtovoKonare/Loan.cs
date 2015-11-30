using System;

namespace BankOfKurtovoKonare
{
    public class Loan : Accounts
    {
        public Loan (double balance, Customer customers, double interestRate) : base (balance, customers, interestRate)
        {

        }
        public override double CalculateRate(int mounths)
        {
            double sum = 0;
            if(this.Customers is IndividualCustomer && mounths < 4 )
            {
                sum = this.Balance;
            }
            else if (this.Customers is Companies && mounths < 3)
            {
                sum = this.Balance;
            }
            else
            {
                return base.CalculateRate(mounths);
            }
            return sum;
        }
      
    }
}
