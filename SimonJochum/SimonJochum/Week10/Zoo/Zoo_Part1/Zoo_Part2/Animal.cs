using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{

    public class Animal
    {
        private string _name { get; set; }
        private string _species { get; set; }
        private Dictionary<Food, double> _foodRequirements { get; set; } = new Dictionary<Food, double>();

        public Animal(string name, string species, Dictionary<Food, double> foodRequirements)
        {
            _name = name;
            _species = species;
            _foodRequirements = foodRequirements;
        }

        public string Name => _name;
        public string Species => _species;
        public Dictionary<Food, double> FoodRequirements => _foodRequirements;

        public string GetName()
        {
            return $"│   ├── {_name}, Gattung: {_species}\n";
        }

        public double CalculateTotalFoodCost()
        {
            double totalCost = 0;

            foreach (var entry in _foodRequirements)
            {
                Food food = entry.Key;
                double quantity = entry.Value;
                totalCost += food.CalculateCost(quantity);
            }

            return totalCost;
        }
    }
}