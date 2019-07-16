using System;

namespace BankAccount2
{
    public class Bank
    {
        public decimal AccountBalance { get; }
        public DateTime Date { get; }  
        public string AccountType { get; }

        public Bank(decimal amount, DateTime date, string type)
        {
            this.AccountBalance = amount;
            this.Date = date;
            this.AccountType = type;
        }
    }
}
