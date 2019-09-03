using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {
    public class Customer {

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~PROPERTIES~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private static int customerNumber = 0;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; } = 0.0m;
        public bool Active { get; set; } = true;

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~METHODS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public void ChangeName(string name) {
            var oldName = Name;
            Name = name;
            Console.WriteLine($"The name of customer (Id {Id}) has been changed from {oldName} to {Name}");
        }

        public void ChangeLoc(string city, string state) {
            var oldCity = City;
            var oldState = State;
            City = city;
            State = state;
            Console.WriteLine($"The location for {Name} (Id {Id}) has been changed from {oldCity}, {oldState} to {City}, {State}");
        }

        public void ChangeActive(bool active) {
            Active = active;
            if(Active) {
                Console.WriteLine($"The status of {Name} has been changed to Active");
                return;
            }
            Console.WriteLine($"The status of {Name} has been changed to Inactive");            
        }


        public void CheckSales() {
            Console.WriteLine($"the current sales for {Name} are ${Sales}");
        }

        public void AddSales(decimal amount) {
            Sales += amount;
            Console.WriteLine($"The total amount of {Name} sales now totals ${Sales}");
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~CONSTRUCTORS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        private void Initialize() {       //this is a much better way, then just call the initialize in every constructor where it needs to happen
            Id = ++customerNumber;
        }

        //public Customer() {              // "ctor tab tab" for default constructor shortcut
        //    Id = ++customerNumber;
        //}

        public Customer() {
            Initialize();
        }

        public Customer(string Name, string City, string State) {
            this.Name = Name;
            this.City = City;
            this.State = State;
            Initialize();
        }
    }
}
