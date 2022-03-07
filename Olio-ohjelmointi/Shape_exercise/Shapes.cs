using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi.Shape_exercise
{
    class Shapes
    {
        protected string color;
        protected string type;

        public Shapes()
        {
            this.color = string.Empty;
            this.type = string.Empty;
        }

        public Shapes(string color, string type)
        {
            this.color = color;
            this.type = type;
        }

       // abstract public double GetArea();

        public virtual string GetColor()
        {
            return this.color;
        }

    }
}
