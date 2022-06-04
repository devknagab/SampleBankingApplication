using System;
using System.Collections.Generic;
using System.Text;
using BankingApplication;

namespace BankingApplication
{
    public class UserAccountInformation : Bank
    {
        public string Name { get ; set; }
        public int AccountNumber { get; set; }
        public double AccountBalance 
        { 
        get 
            {
                double accountBalance = 0;
                foreach (var transaction in allTransactions)
                {
                    accountBalance += transaction.Amount;
                }
                return accountBalance;
            } 
        }
        public string Email { get; set; }
        public string Address { get; set; }

        //private Dictionary<string, int> userAccountDetails = new Dictionary<string, int>();
        public UserAccountInformation()
        {
            Console.WriteLine("ParameterLess Constructor");
        }

        public UserAccountInformation(
        string name, 
        int accountNumber, 
        double accountBalance, 
        string email, 
        string address
        )
        {
            this.Name = name;
            this.AccountNumber = accountNumber;
            Deposit(name, accountNumber, accountBalance, "CAD", DateTime.Now);
            this.Email = email;
            this.Address = address;
        }

        private List<Transactions> allTransactions = new List<Transactions>();

        public bool AuthenticateUser(int accountNumber, string name)
        {
            var users = populateInitialUserDetails();
            foreach (var pair in users)
            {
                Console.WriteLine(pair);
                Console.WriteLine(pair.Value.Item1);
                if (pair.Key == accountNumber && pair.Value.Item1 == name)
                {
                    //_currentBalance = pair.Value.Item2;
                    return true;
                }

            }
            return false;
        }
        public double Deposit(string name, int accountNumber, double amount, string currency, DateTime date)
        {
         //List<Transactions> allTransactions = new List<Transactions>();

        double _currentBalance = 0;

            //var users = populateInitialUserDetails();
            //foreach (var pair in users)
            //{
            //    Console.WriteLine(pair);
            //    Console.WriteLine(pair.Value.Item1);
            //    if (pair.Key == accountNumber && pair.Value.Item1 == name)
            //    {
            //        _currentBalance = pair.Value.Item2;
            //    }

            //}

            //if (!AuthenticateUser(accountNumber, name))
            //{
            //    throw new Exception("Authentication Failed");
            //}

            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException("Enter amount greater than 0");
            }

            if (currency == "CAD")
            {
                amount = amount + this.AccountBalance;
            }
            else if (currency == "USD")
            {
                amount = 0.5 * amount + this.AccountBalance;
            }
            else if (currency == "MXN")
            {
                amount = amount / 10 + this.AccountBalance;
            }

            var deposit = new Transactions(name, accountNumber, amount, currency, date);
            Console.WriteLine(allTransactions);
            allTransactions.Add(deposit);
            return amount;
        }

        public void WithDraw(string name, int accountNumber, double amount, string currency, DateTime date)
        {
            //List<Transactions> allTransactions = new List<Transactions>();

            if (!AuthenticateUser(accountNumber, name))
            {
                throw new Exception("Authentication Failed");
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Enter amount greater than 0");
            }
            if(AccountBalance - amount < 0)
            {
                // see if u can throw some other exceptions
                throw new InvalidOperationException("Insufficient Funds");
            }

            if (currency == "USD")
            {
                amount = 0.5 * amount;
            }
            else if (currency == "MXN")
            {
                amount = amount / 10;
            }

            var withdrawal = new Transactions(name, accountNumber,- amount, currency, date);
            allTransactions.Add(withdrawal);
        }
    }
}
