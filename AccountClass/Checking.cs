using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {
    public class Checking {

        private Account _account = null; //good practice to initialize any variable you create

        public bool Deposit(decimal amount) {
            return _account.Deposit(amount);
        }
        public bool Withdraw(decimal amount) {
            return _account.Withdraw(amount);
        }
        public string Print() {
            return _account.Print();
        }
        public decimal GetBalance() {
            return _account.GetBalance();
        }

        public Checking(string description, Customer customer) { //composition instead of inheriting
            _account = new Account(description, customer);
        }
    }
}
