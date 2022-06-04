using NUnit.Framework;
using BankingApplication;
using System.Collections.Generic;
using System;


namespace BankingApplication.Tests
{
    class BankTests : UserAccountInformation
    {
        private Bank _test;
        //private Transactions _account;
        private UserAccountInformation _userAccounts1, _userAccounts2;

        [SetUp]
        public void Setup()
        {           
            _test = new Bank();
            //_test.populateInitialUserDetails();
        }

        // is it a good idea to pass the the list again and again
        [TestCase("Stewie Griffin", 1234, 100, "CAD", "")]
       
        public void IsAmountDepositedInCAD_ReturnBalance(string name, int accountNumber, double amount, string currency, string date)
        {
            var currentUser = new UserAccountInformation("Stewie Griffin", 1234, 100, "s.g@gmail.com", "SG");
            var balance = Deposit(name, accountNumber, amount, currency, DateTime.Now);
            //Console.WriteLine(currentUser.AccountBalance);
            Console.WriteLine(balance);
            //_account.checkBalance();
            //Assert.AreEqual(_account.checkBalance(), 200);
        }

        [TestCase("ABCDEFG", 5678, 100, "USD", "")]
        public void IsAmountDepositedInCAD_ReturnBalance2(string name, int accountNumber, double amount, string currency, string date)
        {
            var currentUser = new UserAccountInformation("ABCDEFG", 5678, 1000, "s.g@gmail.com", "SG");
            var balance = Deposit(name, accountNumber, amount, currency, DateTime.Now);
            //Console.WriteLine(currentUser.AccountBalance);
            Console.WriteLine(balance);
            //_account.checkBalance();
            //Assert.AreEqual(_account.checkBalance(), 200);
        }

        //[TestCase("User2", 2, 100, "USD")]
        //public void IsAmountDepositedInUSD_ReturnBalance(string user, int accountNo, double amount, string currency)
        //{
        //    _account.Deposit(user, accountNo, amount, currency);
        //    _account.checkBalance();
        //    Assert.AreEqual(_account.checkBalance(), 150);
        //}

        //[TestCase("User3", 3, 100, "MXN")]
        //public void IsAmountDepositedInMXN_ReturnBalance(string user, int accountNo, double amount, string currency)
        //{
        //    _account.Deposit(user, accountNo, amount, currency);
        //    _account.checkBalance();
        //    Assert.AreEqual(_account.checkBalance(), 1100);
        //}

        // REMOVE THESE BEFORE SUBMITTING
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        //[TestCase(-1)]
        //[TestCase(0)]
        //[TestCase(1)]
        //public void IsTestWorking_ReturnTrue(int value)
        //{
        //    var result = _test.IsPrime(value);
        //    Assert.IsFalse(result, $"{value} should not be prime");
        //}
    }
}