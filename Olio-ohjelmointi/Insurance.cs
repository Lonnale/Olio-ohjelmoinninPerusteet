using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinvakuutukset
{
    class Insurance : IComparable<Insurance>
    {
        private String species;
        private String name;
        private bool neutered;
        private double fee;

        

        public Insurance(String animal, String name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }

        public string Species { get => species; set => species = value; }
        public string Name { get => name; set => name = value; }
        public bool Neutered { get => neutered; set => neutered = value; }
        public double Fee { get => fee; set => fee = value; }

        public int CompareTo(Insurance other)
        {
            if (other != null)
            {
                return this.name.CompareTo(other.Name);
            }
            else
            {
                throw new ArgumentException("Ei mitään hajua mitä tähän tulee ");
            }
        }

        public String GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override String ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }

    }
}
