using System;

namespace BankOfKurtovoKonare.Interfaces
{
    public interface IInterestRate
    {
        double CalculateRate(int mounths);
    }
}
