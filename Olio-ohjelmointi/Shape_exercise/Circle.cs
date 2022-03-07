using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Shape_exercise
{
    class Circle : Shapes
    {
        private double radius;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(string color, double radius) //: base(color, "CIRCLE")
        {
            this.radius = radius;
            this.color = color;
            this.type = "CIRCLE";
        }

      /* public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }
        */
    }
}
