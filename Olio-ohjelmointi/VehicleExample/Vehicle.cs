using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palautus2.VehicleExample
{
    class Vehicle
    {
        private string make;
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle()
        {
            make = "Tuntematon";
            model = "Tuntematon";
            modelYear = 2000;
            price = 0;
        }

        
        public Vehicle(string make, string model, int modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = 0;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine($"Merkki: {this.make}" +
                $" Malli: {this.model}" +
                $" Vuosimalli: {this.modelYear}" +
                $"Hinta:{this.price} ");
        }

        public override string ToString()
        {
            return $"{this.make},{this.model},{this.modelYear},{this.price}";
        }
    }
}
