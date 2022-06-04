using System;
using System.Collections.Generic;


namespace BankingApplication
{
    public class Bank
    {
        //private double _balance = 100;

        //        Dictionary<string,{} > userAccountDetails = new Dictionary<string, string>
        //            {
        //                { "User1", telemetry.UserEmail
        //},
        //                { "User2", telemetry.UserId },
        //                { "User3", telemetry.Country },
        //                { "User4", telemetry.UltimateId }
        //            };

        //public Dictionary<string, string> useraccountDetails = new Dictionary<string, string>(){
        //    {"UK", "London, Manchester, Birmingham"},
        //    {"USA", "Chicago, New York, Washington"},
        //    {"India", "Mumbai, New Delhi, Pune"}
        //    };

        static void Main(string[] args)
        {
            var user1 = new UserAccountInformation("Stewie Griffin", 1234, 1000, "s.g@gmail.com", "SG");
            Console.WriteLine($"Account for {user1.Name} with {user1.AccountNumber} was created with {user1.AccountBalance} as initial balance");
            user1.WithDraw("Stewie Griffin", 1234, 500, "CAD" ,DateTime.Now);
            Console.WriteLine(user1.AccountBalance);
            user1.Deposit("Stewie Griffin", 1234,100, "USD", DateTime.Now);
            Console.WriteLine(user1.AccountBalance);

            user1.Deposit("Stewie Griffin", 1234, 10, "MXN", DateTime.Now);
            Console.WriteLine(user1.AccountBalance);

            user1.WithDraw("Stewie Griffin", 1234, 10, "MXN", DateTime.Now);
            Console.WriteLine(user1.AccountBalance);

            Dictionary<string, int> userAccountDetails = new Dictionary<string, int>();


        // may be create the dictionary here
             //void CreateUserAccountDictionary(string name, int accountNumber)
             //   {
             //       userAccountDetails.Add(name, accountNumber);
             //   }


            // test to see if the initial balance is positive
            //try
            //{
            //    var invalidAccount = new UserAccountInformation("InvalidAccount", 0000, -100, "abc@g.com", "9900");
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception causght creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //Console.WriteLine("Hello World!");
            //List<UserAccountInformation> users = new List<UserAccountInformation>();
            //users.Add(new UserAccountInformation("User1", 1234, 100, "abc@g.com", "23KK"));
            //users.Add(new UserAccountInformation("User2", 5678, 200, "def@g.com", "45KK"));

            //UserAccountInformation user1 = new UserAccountInformation();
            //user1.Name = "User1";


        }

        public Dictionary<int, Tuple<string, int>> populateInitialUserDetails()
        {
            //Dictionary<int, string> useraccountDetails = new Dictionary<int, string>();
            //useraccountDetails.Add(1234, "Stewie Griffin");
            //useraccountDetails.Add(5678, "ABCDEFG");

            Dictionary<int, Tuple<string,int>> useraccountDetails = new Dictionary<int, Tuple<string, int>>();
            useraccountDetails.Add(1234, new Tuple<string, int>("Stewie Griffin", 100));
            useraccountDetails.Add(5678, new Tuple<string, int>("ABCDEFG", 900));

            //List<UserAccountInformation> userAccounts = new List<UserAccountInformation>();
            //userAccounts.Add(new UserAccountInformation("Stewie Griffin", 1234, 100, "s.g@gmail.com", "SG"));
            //userAccounts.Add(new UserAccountInformation("ABCDEFG", 1234, 100, "s.g@gmail.com", "SG"));

            return useraccountDetails;
            //List<UserAccountInformation> userAccounts = new List<UserAccountInformation>();
            //userAccounts.Add(new UserAccountInformation("Stewie Griffin", 1234, 100, "s.g@gmail.com", "SG"));
            //userAccounts.Add(new UserAccountInformation("ABCDEFG", 1234, 100, "s.g@gmail.com", "SG"));
            //return userAccounts;
            //useraccountDetails.Add(name, accountNumber);
        }

        //REMOVE THIS BEFORE SUBMITTING
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }
    }
}
