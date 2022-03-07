using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Shape_exercise
{
    class Triangle : Shapes
    {
        private double length;
        private double width;
        private double jako;

        public Triangle()
        {
            this.width = 0;
            this.length = 0;
            this.jako = 2;
        }

        public Triangle(double length, double width, string color)
        {
            this.length = length;
            this.width = width;
            this.color = color;
            this.type = "TRIANGLE";
        }
        public override double GetArea()
        {
            
            return this.width * this.length / this.jako;
        }

    }
}
