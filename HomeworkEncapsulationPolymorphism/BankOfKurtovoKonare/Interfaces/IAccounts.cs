using System;
using System.Collections.Generic;

namespace BankOfKurtovoKonare.Interfaces
{
    public interface IAccounts
    {
        Customer Customers { get; set; }
        double Balance { get; set; }
        double InterestRate { get; set; }
    }
}
