using System;

namespace BankOfKurtovoKonare
{
    using Interfaces;
    public abstract class Customer : ICustomer
    {
        public Customer (string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }       
    }
}
