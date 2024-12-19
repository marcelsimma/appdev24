using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{

    public class Animal
    {
        private string _name { get; set; }
        private string _species { get; set; }
        private Dictionary<Food, double> _foodRequirements { get; set; } = new Dictionary<Food, double>();
        private double _health { get; set; } = 100;
        private double _biteStrength { get; set; }

        public Animal(string name, string species, Dictionary<Food, double> foodRequirements) //bis Aufgabe 7
        {
            _name = name;
            _species = species;
            _foodRequirements = foodRequirements;
        }

        public Animal(string name, string species) //für Aufgabe 8
        {
            _name = name;
            _species = species;
            _foodRequirements = new Dictionary<Food, double>();
        }

        public Animal(string name, string species, double biteStrength) //für Aufgabe 9
        {
            _name = name;
            _species = species;
            _foodRequirements = new Dictionary<Food, double>();
            _biteStrength = biteStrength;
        }

        public string Name => _name;
        public string Species => _species;
        public Dictionary<Food, double> FoodRequirements => _foodRequirements;
        public double BiteStrength => _biteStrength;
        public double Health => _health;
        public bool IsAlive => _health > 0;

        public void Bite(Animal target)
        {
            if (!IsAlive) return;

            Console.WriteLine($"{_name} ({_species}) beißt {target.Name} ({target.Species}) und verursacht {_biteStrength} Schaden.");
            target.TakeDamage(_biteStrength);
        }

        public void TakeDamage(double damage)
        {
            _health = Math.Max(0, _health - damage);
            if (_health == 0)
            {
                Console.WriteLine($"{_name} ({_species}) ist gestorben.");
            }
        }

        public string GetName()
        {
            return $"│   ├── {_name}, Gattung: {_species}, Gesundheit: {_health}\n";
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