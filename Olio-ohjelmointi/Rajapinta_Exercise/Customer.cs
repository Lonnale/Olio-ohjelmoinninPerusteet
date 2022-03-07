using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Rajapinta_Exercise
{
    class Customer : ICustomer
    {
        private string name;
        private double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public int GetBonus()
        {
            if (purchases <= 1000)
            {
                return 2;
            }
           else if (1000 < purchases && purchases <= 2000)
            {
                return 3;
            }
            else 
            {
                return 5;
            }
        }

        public Customer GetCustomer(string Customername)
        {
            if (name.Equals(Customername))
            {
                return this;
            }
            else
            {
                return null;
            }
             
        }

        public override string ToString()
        {
            return $"Asiakkaan nimi: {this.name}, Ostokset: {this.purchases}";
        }
    }
}
