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
            StringBuilder MenuCardDetails = new StringBuilder();
            if (MenuCard.Count == 0)
            {
                MenuCardDetails.AppendLine($"|       |-- (leer)");
            }
            // Ausgabe Dictionary.
            foreach (var menu in MenuCard)
            {
                MenuCardDetails.AppendLine($"DailyNeeds: {menu.Key.NameFood}: {menu.Value} {menu.Key.Unit}");
            }

            return

            String.Format(
            @"Animal: {0}, {1} -> {2}"

            , NameAnimal, Species, MenuCardDetails.ToString());
        }
    }
}
