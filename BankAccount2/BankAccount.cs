using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount2
{
         public class BankAccount
        {
            public string AccountNumber { get; }
            public string Owner { get; set; }
            public decimal Balance
            {
                get
                {
                    decimal balance = 0;
                    foreach (var item in allTransactions)
                    {
                        balance += item.AccountBalance;
                    }

                    return balance;
                }
            }
        
            private static int accountNumberSeed = 1234567890;
           
            public BankAccount(string name, decimal initialBalance)
            {
                this.AccountNumber = accountNumberSeed.ToString();
                accountNumberSeed++;

                this.Owner = name;
                Deposit(initialBalance, DateTime.Now, "Initial balance");
            }
          
            private List<Bank> allTransactions = new List<Bank>();
       
            public void Deposit(decimal amount, DateTime date, string note)                        
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                }
                var deposit = new Bank(amount, date, note);
                allTransactions.Add(deposit);
            }

            public void Withdraw(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
                }
                if (Balance - amount < 0)
                {
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                }
                var withdrawal = new Bank(-amount, date, note);
                allTransactions.Add(withdrawal);
            }
       

            public string GetAccountHistory()
            {
                var report = new System.Text.StringBuilder();

                report.AppendLine("Date\tAmount\tNote");
                foreach (var item in allTransactions)
                {
                    report.AppendLine($"{item.Date.ToShortDateString()}\t{item.AccountBalance}\t{item.AccountType}");
                }

                return report.ToString();
            }
         
        }
    }