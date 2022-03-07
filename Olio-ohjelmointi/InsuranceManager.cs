using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinvakuutukset
{
    class InsuranceManager
    {

        public int dog_neutered = 50;
        public int dog_unneutered = 80;
        public int cat_neutered = 40;
        public int cat_unneutered = 60;
        public int bird_neutered = 0;
        public int bird_unneutered = 0;
        public int reptile_neutered = 0;
        public int reptile_unneutered = 0;

        List<Insurance> insurances;

        public InsuranceManager()
        {
            insurances = new List<Insurance>();
        }

        internal void PrintInsurances()
        {
            Console.WriteLine("Vakuutuksia on yhteensä näin monta kappaletta: "+ insurances.Count);
            Console.WriteLine("Vakuutukset");
            insurances.ForEach(Print);
        }

        private void Print(Insurance obj)
        {
            Console.WriteLine(obj.ToString());
        }

        internal void FindInsurances(string species, bool isNeutered)
        {
            Console.WriteLine("Vakuutukset löytyivät");
            insurances.Sort();
            foreach (Insurance insurance in insurances)
            {
                if (insurance.Species.Equals(species) && insurance.Neutered.Equals(isNeutered))
                {
                    Console.WriteLine(insurance.Species + ":" + insurance.Name + ", vakuutusmaksut ovat " + insurance.Fee +" Euroa");
                }
            }
        }

        public void AddInsurance(string animal, string name, bool isNeutered)
        {
            Insurance i = new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered));

            insurances.Add(i);
        }

        public double GetFee(String species, bool isNeutered)
        {
            if (species.Equals("Dog") && isNeutered)
            {
                return dog_neutered;
            }
            else if (species.Equals("Dog") && !isNeutered)
            {
                return dog_unneutered;
            }
            else if (species.Equals("Cat") && !isNeutered)
            {
                return cat_neutered;
            }
            else if (species.Equals("Cat") && !isNeutered)
            {
                return cat_unneutered;
            }
            else if (species.Equals("Bird") && isNeutered)
            {
                return bird_neutered;
            }
            else if (species.Equals("Bird") && !isNeutered)
            {
                return bird_unneutered;
            }
            else if (species.Equals("Reptile") && isNeutered)
            {
                return reptile_neutered;
            }
            else if (species.Equals("Reptile") && !isNeutered)
            {
                return reptile_unneutered;
            }
            else
            {
                return 0;
            }

        }
    }
}
