using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Shape_exercise
{
    
    class Rectangle : Shapes
    {
        private double length;
        private double width;

        public Rectangle()
        {
            this.length = 0;
            this.width = 0;
        }

        public Rectangle(double length, double width, string color)
        {
            this.length = length;
            this.width = width;
            this.color = color;
            this.type = "RECTANGLE";
        }

        public override double GetArea()
        {
            return this.width * this.length;
        }
    }
}
