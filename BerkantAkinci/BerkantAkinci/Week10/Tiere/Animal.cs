using System;

namespace BerkantAkinci.Week10
{
    public class Animal
    {
        public string AnimalName;
        public string Species;
        public Dictionary<AnimalFood, double> animalFoodList = new Dictionary<AnimalFood, double>();

        public Animal(string animalName, string species)
        {
            AnimalName = animalName;
            Species = species;
        }

        public void AddFood(AnimalFood animalFood, double amount)
        {
            animalFoodList.Add(animalFood, amount);
        }

        public void PrintFood()
        {
            System.Console.WriteLine($"{AnimalName}, {Species}:");
            foreach (KeyValuePair<AnimalFood, double> food in animalFoodList)
            {
                double price = food.Key.UnitPrice * food.Value;
                System.Console.WriteLine($"{food.Key.FoodName}, {food.Value} {food.Key.Unit}, {Math.Round(price, 2)} €");
            }
            System.Console.WriteLine();
        }

        public override string ToString()
        {
            return String.Format(AnimalName + ", " + Species);
        }
    }
}