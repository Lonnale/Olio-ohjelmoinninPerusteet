using Palautus2.VehicleExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palautus2
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleExample();
        }
        static void VehicleExample()
        {
            Vehicle vehicle = new Vehicle("Toyota", "Corolla", 1990, 25000);
            vehicle.PrintInformation();
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine($"tulosta tiedot: {vehicle.PrintInformation()}");


            Car car = new Car(2000,"Farkku",4);
            Car car2 = new Car(2500, "Coupe", 2);
            car.PrintInformation();
            Console.WriteLine(Equals(car, car2));
            Console.WriteLine($"tulosta tiedot: {car.PrintInformation()}");

            Truck truck = new Truck(20,50);
            truck.PrintInformation();
            truck.CalculateConsumption();
            Console.WriteLine($"tulosta tiedot: {truck.PrintInformation()}");
            Console.WriteLine($"tulosta tiedot: {truck.CalculateConsumption()}");
        }
    }
}
