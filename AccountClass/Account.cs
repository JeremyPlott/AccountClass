﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    class Account{

        private static int nextAccountNbr = 0;  //static means this one property is unique to the class, not created per instance

        public int Id { get; private set; }
        private decimal Balance { get; set; } = 0.0M; //sets default value. The M is to put as dec instead of double.
        public string Description { get; set; }
        public Customer CustomerInstance { get; set; } = null; //property for PK-FK relationship with other class

        public string Print() {
            return ($"{this.GetType().Name} Nbr: {Id}, Desc: {Description}, Bal: {GetBalance().ToString("C")}");
        }


        private Account() { //still doing work in other constructors, but cannot be used to create a new instance when set private
            Id = ++nextAccountNbr;
        }  //constructors are conventionally at the end of the class. Same name as class.

        public Account(string Description) : this () { // : this () calls the other constructor first with () parameter.
            this.Description = Description; //distinguishes between parameter and property of the same name
        }

        public Account(Customer customer) : this () {     //constructor for PK-FK relationship with other class
            this.CustomerInstance = customer;
        }

        public Account(string Description, Customer customer) {
            this.Description = Description;
            this.CustomerInstance = customer;
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

        public void Transfer(Account acct, decimal amount) {            
            var withdrawSuccessful = this.Withdraw(amount); //this is a variable that referrs to an instance of the class get gets provided
            if(withdrawSuccessful) { //if(!____) flips the boolean.
                acct.Deposit(amount);
            }
            Console.WriteLine("Transfer failed.");
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
