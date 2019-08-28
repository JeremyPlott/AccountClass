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
*/

namespace AccountClass {

    class Program {

        static void Main(string[] args) {

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

        }


    }
}
