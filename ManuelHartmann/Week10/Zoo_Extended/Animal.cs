using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week10.Zoo_Extended
{
    public class Animal
    {
        public string IdAnimal { get; private set; }
        public string NameAnimal { get; private set; }
        public string Species { get; private set; }
        public Dictionary<AnimalFood, double> MenuCard {  get; private set; }

        public Animal(string idAnimal, string nameAnimal, string species)
        {
            IdAnimal = idAnimal;
            NameAnimal = nameAnimal;
            Species = species;
            MenuCard = new Dictionary<AnimalFood, double>();
        }

        public override string ToString()
        {
            return

            String.Format(
            @"Animal: {0}, {1}"

            , NameAnimal, Species);
        }
    }
}
