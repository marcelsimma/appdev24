using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Zoo
    {
        private string _name { get; set; }
        private DateTime _foundingYear { get; set; }
        private List<Enclosure> _enclosures { get; set; } = new List<Enclosure>();
        private List<(string FoodName, string Unit, double Quantity, double TotalCost)> _totalFood
        = new List<(string FoodName, string Unit, double Quantity, double TotalCost)>();
        private List<Zookeeper> _totalZookeepers = new List<Zookeeper>();

        public Zoo(string name, DateTime foundingYear)
        {
            _name = name;
            _foundingYear = foundingYear;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _enclosures.Add(enclosure);
        }

        public void RemoveEnclosure(string enclosureName)
        {
            Enclosure enclosure = _enclosures.Find(enclosure => enclosure.Name == enclosureName);
            if (enclosure != null)
            {
                _enclosures.Remove(enclosure);
                Console.WriteLine("Gehege entfernt.");
            }
            else
            {
                Console.WriteLine("Gehege nicht gefunden!");
            }
        }

        public Enclosure GetEnclosure(string enclosureName)
        {
            return _enclosures.Find(enclosure => enclosure.Name == enclosureName);
        }

        public string PrintZoo()
        {
            string result = $"Zoo: {_name}, gegründet {_foundingYear.Year}\n";
            foreach (var zookeeper in _totalZookeepers)
            {
                result += zookeeper.GetName();

                if (zookeeper.Enclosures.Any())
                {
                    foreach (var enclosure in zookeeper.Enclosures)
                    {
                        result += enclosure.GetName();
                    }
                }
                else
                {
                    result += "Keine Gehege zugeordnet.\n";
                }
            }
            return result;
        }
        public void UpdateFoodRequirements()
        {
            var foodRequirements = new Dictionary<Food, double>();

            foreach (var enclosure in _enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    foreach (var entry in animal.FoodRequirements)
                    {
                        if (foodRequirements.ContainsKey(entry.Key))
                        {
                            foodRequirements[entry.Key] += entry.Value;
                        }
                        else
                        {
                            foodRequirements[entry.Key] = entry.Value;
                        }
                    }
                }
            }

            _totalFood.Clear();
            foreach (var entry in foodRequirements)
            {
                Food food = entry.Key;
                double quantity = entry.Value;
                double cost = food.CalculateCost(quantity);

                _totalFood.Add((food.Name, food.Unit, quantity, cost));
            }
        }

        public void PrintFoodRequirements()
        {
            UpdateFoodRequirements();

            Console.WriteLine("Futterbedarf");
            Console.WriteLine("--------------------------------------------");
            double totalCost = 0;

            foreach (var entry in _totalFood)
            {
                Console.WriteLine($"{entry.FoodName,-12} {entry.Quantity,15:0.00} {entry.Unit,-5} {entry.TotalCost,6:0.00} €");
                totalCost += entry.TotalCost;
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{"Summe",-12} {totalCost,28:0.00} €");
        }

        public void AddZookeeper(Zookeeper zookeeper)
        {
            _totalZookeepers.Add(zookeeper);
        }
    }
}