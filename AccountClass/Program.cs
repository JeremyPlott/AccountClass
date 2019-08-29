using System;

/*
 * Homework
 * create customer class.
 * unique int 'Id'
 * string name of company
 * string city
 * string state
 * decimal sales (default 0)
 * bool active (default true)
 * 
 * Put in a default constructor, used or not
 * provide a way to set all but sales + Id
 * method for adding to sales
 * auto-gen Id
 * 
*/

namespace AccountClass {

    class Program {

        static void Main(string[] args) {


            var cust1 = new Customer("CocaCola", "Cincinnati", "OH");
            var acct1 = new Account("Primary Checking", cust1);
            Console.WriteLine($"{cust1.Name}, {cust1.City}, {cust1.State}, ${cust1.Sales}, {cust1.Active}, Id - {cust1.Id}");

            cust1.CheckSales();
            cust1.AddSales(200);
            cust1.ChangeName("Coke");

            var cust2 = new Customer("Ikea", "Tampa", "FL");
            var acct2 = new Account("Money Laundering", cust2);
            var acct3 = new Account("Swear Jar", cust1);
            Console.WriteLine($"{cust2.Name}, {cust2.City}, {cust2.State}, ${cust2.Sales}, {cust2.Active}, Id - {cust2.Id}");
            Console.WriteLine($"{acct1.CustomerInstance.Name}------");
            Console.WriteLine($"{acct3.CustomerInstance.Name}------");

            cust2.ChangeLoc("Atlantis", "NM");
            cust2.ChangeActive(false);
            cust1.ChangeActive(true);

            var cust3 = new Customer();
            Console.WriteLine($"{cust3.Name}, {cust3.City}, {cust3.State}, ${cust3.Sales}, {cust3.Active}, Id - {cust3.Id}"); //Id and defaults still work



            cust1.Name = "Playdoh";

            var acct4 = new Account("Primary Savings", cust1);

            acct1.Deposit(2);
            acct3.Deposit(1000);
            acct4.Deposit(50000);

            var accounts = new Account[] { acct1, acct3, acct4 };
            var accountTotal = 0m;
            foreach(var account in accounts) {
                accountTotal += account.GetBalance();
                Console.WriteLine($"{account.Id} {account.Description} {account.CustomerInstance.Name} {account.GetBalance()}");
            }
            Console.WriteLine($"Total of all accounts is {accountTotal}.");


            /*
            var acct1 = new Account("Primary Checking");
            //acct1.Balance = 1000000m; //should not be allowed to do this without calling a method. Safety nets.

            Console.WriteLine($"{acct1.Description} account - {acct1.Id} has a balance of {acct1.GetBalance()}.");

            acct1.Deposit(1000);
            Console.WriteLine($"{acct1.Description} account - {acct1.Id} has a balance of {acct1.GetBalance()}.");

            acct1.Withdraw(5000);
            Console.WriteLine($"{acct1.Description} account - {acct1.Id} has a balance of {acct1.GetBalance()}.");

            var balance = acct1.GetBalance();
            Console.WriteLine(balance);

            acct1.Withdraw(-1000000);
            Console.WriteLine($"{acct1.Description} account - {acct1.Id} has a balance of {acct1.GetBalance()}.");


            var acct2 = new Account("Secondary Checking");
            Console.WriteLine($"{acct2.Description} account - {acct2.Id} has a balance of {acct2.GetBalance()}.");

            acct1.Transfer(acct2, 2000);
            Console.WriteLine($"{acct2.Description} account - {acct2.Id} has a balance of {acct2.GetBalance()}.");

            acct2.Deposit(5);
            Console.WriteLine($"{acct2.Description} account - {acct2.Id} has a balance of {acct2.GetBalance()}.");
            Console.WriteLine($"{acct1.Description} account - {acct1.Id} has a balance of {acct1.GetBalance()}.");
            */

        }


    }
}
