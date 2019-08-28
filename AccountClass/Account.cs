using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    class Account{

        private static int nextAccountNbr = 0;  //static means this one property is unique to the class, not created per instance

        public int Id { get; private set; }
        private decimal Balance { get; set; } = 0.0M; //sets default value. The M is to put as dec instead of double.
        public string Description { get; set; }

        public void Transfer(Account acct, decimal amount) {            
            var withdrawSuccessful = this.Withdraw(amount); //this is a variable that referrs to an instance of the class get gets provided
            if(withdrawSuccessful) { //if(!____) flips the boolean.
                acct.Deposit(amount);
            }
            Console.WriteLine("Transfer failed.");
        }

        public Account() {
            Id = ++nextAccountNbr;
        }  //constructors are conventionally at the end of the class. Same name as class.

        public Account(string Description) : this () { // : this () calls the other constructor first with () parameter.
            this.Description = Description; //distinguishes between parameter and property of the same name
        }

        public decimal GetBalance() {
            return Balance;
        }

        private bool CheckAmountIsPositive(decimal amount) {
            if (amount < 0) {
                Console.WriteLine("Amount cannot be negative.");
                return false;
            }
            return true;
        }

        public bool Deposit(decimal Amount) { //these variables are only referenced within the specific method, even with the same name.
            var valid = CheckAmountIsPositive(Amount);
            if (valid == true) {
                Balance += Amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal Amount) {
            var valid = CheckAmountIsPositive(Amount);
            if(valid == true) {     //avoid nested if statements beyond 3 levels
                if (Amount > Balance) {
                    Console.WriteLine("Insufficient funds.");
                } else {
                    Balance -= Amount;
                    return true;
                }
            }
            return false;
        }
    }
}
