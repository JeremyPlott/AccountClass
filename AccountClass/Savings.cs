using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    class Savings : Account {

        private decimal IntRate = 0.01m;

        public string Print() {
            return base.Print() + $", Interest rate: {(IntRate) * 100}%";
        }

        public decimal CalcInterest(int months) {
            return IntRate / 12 * months * GetBalance();
        }

        public void CalcAndPayInterest(int months) {
            var interest = CalcInterest(months);
            this.Deposit(interest);
        }

        public void SetInterestRate(decimal intrate) {
            this.IntRate = intrate;
        }

        public Savings(decimal intrate,  string description, Customer customer) 
            : base(description, customer) { //only these two get passed to the base constructor being called in Account
            this.IntRate = intrate;
        }
    }
}
