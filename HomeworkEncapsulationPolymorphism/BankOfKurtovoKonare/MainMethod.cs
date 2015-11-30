using System;

namespace BankOfKurtovoKonare
{
    public class MainMethod
    {
        static void Main(string[] args)
        {
            Accounts loan = new Loan(7000, new Companies("Nike"), 0.09);
            loan.Deposit(600);            
            Accounts deposit = new DepositAccount(1500, new IndividualCustomer("Gosho"), 0.12);
            deposit.Deposit(200);
            Accounts mortgage = new Mortgage(5000, new Companies("Puma"), 0.12);
            mortgage.Deposit(6000);            
            Console.WriteLine(loan.CalculateRate(3));
            Console.WriteLine(mortgage.CalculateRate(15));
            Console.WriteLine(deposit.CalculateRate(10));
            
        }
    }
}
