using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Car_exercise
{
    class Car
    {
        public string brand;
        public double speed;

        public Car()
        {
            this.brand = string.Empty;
            this.speed = 0;
        }

        public Car(string brand, double speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Automerkki: {this.brand} - Auton nopeus: {this.speed}");
        }
        
        public void AskData()
        {
            Console.WriteLine($"Mikä automerkki? {this.brand} - Paljonko nopeus? {this.speed}");
        }
        public void Brake()
        {
            double jarru = this.speed * 0.9;
            Console.WriteLine($"Käytit jarrua, uusi nopeus: {jarru}");
        }
        public void Accelerate()
        {

        }
    }
}
