using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {
    class Customer {

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~PROPERTIES~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private static int customerNumber = 0;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; set; } = 0.0m;
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

        public Customer() {
            Id = ++customerNumber;
        }

        public Customer(string Name, string City, string State, bool Active) : this () {
            this.Name = Name;
            this.City = City;
            this.State = State;
            this.Active = Active;
        }
    }
}
