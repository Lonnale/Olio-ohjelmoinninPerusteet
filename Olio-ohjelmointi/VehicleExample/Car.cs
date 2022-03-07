using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palautus2.VehicleExample
{
    class Car : Vehicle
    {
        protected double engine;
        protected string type;
        protected int doors;

        public Car()
        {
            this.engine = 2000;
            this.type = "Farkku";
            this.doors = 4;

        }

        public Car(double engine, string type, int doors)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public override bool Equals(object obj)
        {
            Car car = obj as Car;
                
            return (car != null)
                && (this.model == car.model)
                && (this.price == car.price)
                && (this.engine == car.engine)
                && (this.type == car.type)
                && (this.doors == car.doors);


        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"tulostetaan Car-luokan kenttien arvot:" +
                $" {this.engine}, " +
                $"{this.type}," +
                $" {this.doors}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {this.engine}, {this.type}, {this.doors}";
        }
    }
}
