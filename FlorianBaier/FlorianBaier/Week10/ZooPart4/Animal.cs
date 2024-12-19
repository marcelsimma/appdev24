using System;

namespace FlorianBaier.Week10.ZooPart4
{

    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Dictionary<Food, double> Menu { get; set; }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
            Menu = new Dictionary<Food, double>();

        }
        public void AddFood(Food food, double amount)
        {
            if (Menu.ContainsKey(food))
            {
                Menu[food] += amount;
            }
            else
            {
                Menu.Add(food, amount);
            }
        }
        public double CalculateFoodCost()
        {
            double totalCost = 0;
            foreach (var entry in Menu)
            {
                totalCost += entry.Value * entry.Key.UnitPrice;
            }
            return totalCost;
        }
        public void DisplayMenu()
        {
            Console.WriteLine($"{Name} ({Species}) Food Menu:");
            foreach (var entry in Menu)
            {
                Console.WriteLine($"{entry.Key.Name}: {entry.Value} {entry.Key.Unit} (Cost: {entry.Value * entry.Key.UnitPrice} €)");
            }
        }
        public Dictionary<Food, double> GetMenu()
        {
            return Menu;
        }
    }
}