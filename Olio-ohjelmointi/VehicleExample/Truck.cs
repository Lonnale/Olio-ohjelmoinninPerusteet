using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palautus2.VehicleExample
{
    class Truck : Car
    {
        protected int load;
        protected int consumption;

        public Truck(int load, int consumption)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public int CalculateConsumption()
        {
            return load * consumption;

        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"tulostetaan Truck-luokan kenttien arvot:" +
               $" {this.load}, " +
               $"{this.consumption}");
        }
           
    }
}
