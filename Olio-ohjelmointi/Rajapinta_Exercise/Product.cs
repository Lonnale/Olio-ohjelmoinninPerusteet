using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Rajapinta_Exercise
{
    class Product : IProduct
    {
        private string name;
        private double price;
        private int count;

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public double CalculateTotal()
        {
            return this.price * this.count;
        }

        public Product GetProduct(string name)
        {
            //if (name == this.name)
            if (name.Equals(this.name))
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
            return $"Tuotteen nimi: {this.name}, Tuotteen hinta: {this.price}, Tuotteen määrä:{this.count}";
        }
    }
}
