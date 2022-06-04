using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication
{
    public class Transactions
    {
        public string Name { get; }
        public int AccountNumber { get; }

        public double Amount {get; }
        public string Currency { get; }

        public DateTime Date { get; }
        public Transactions(string name, int accountNumber, double amount, string currency, DateTime date) 
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            this.Amount = amount;
            this.Currency = currency;
            this.Date = date;
        }
    }
}
