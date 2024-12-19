using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Zoo
    {
        private string _name { get; set; }
        private DateTime _foundingYear { get; set; }
        private List<Enclosure> _enclosures { get; set; } = new List<Enclosure>();
        private List<Food> _foods;
        private List<(string FoodName, string Unit, double Quantity, double TotalCost)> _totalFood
        = new List<(string FoodName, string Unit, double Quantity, double TotalCost)>();
        private List<Zookeeper> _totalZookeepers { get; set; } = new List<Zookeeper>();

        public List<Zookeeper> TotalZookeepers => _totalZookeepers;
        public List<Food> Foods => _foods;
        public List<Enclosure> Enclosures => _enclosures;

        public Zoo(string name, DateTime foundingYear)
        {
            _name = name;
            _foundingYear = foundingYear;
            _foods = new List<Food>();
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

        public void AddFood(Food food)
        {
            _foods.Add(food);
        }

        public Enclosure GetEnclosure(string enclosureName)
        {
            return _enclosures.Find(enclosure => enclosure.Name == enclosureName);
        }

        public Zookeeper GetZookeeper(string zookeeperName)
        {
            return _totalZookeepers.Find(zookeeper => zookeeper.Name == zookeeperName);
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

        public void SimulateDay()
        {
            bool running = true;
            Console.WriteLine($"Beginne die Tagessimulation für den Zoo {_name}.");
            while (running)
            {
                HashSet<string> visitedEnclosures = new HashSet<string>();

                foreach (var zookeeper in _totalZookeepers)
                {
                    zookeeper.SimulateDay(visitedEnclosures);
                }

                foreach (var enclosure in _enclosures)
                {
                    enclosure.SimulateDay();
                }

                Console.WriteLine("Möchtest du noch einen Tag simulieren? Ja/Nein");
                string choice = Console.ReadLine().ToLower();
                if (choice == "nein")
                {
                    running = false;
                }
            }
            Console.WriteLine("Tagessimulation abgeschlossen.");
        }
    }
}