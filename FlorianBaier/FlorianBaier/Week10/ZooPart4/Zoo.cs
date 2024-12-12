using System;

namespace FlorianBaier.Week10.ZooPart4
{

    public class Zoo
    {
        public string Name { get; set; }
        public DateTime FoundingYear { get; set; }
        private List<Enclosure> Enclosures { get; set; }
        private List<Zookeeper> Zookeepers { get; set; }
        private double TotalFoodCost { get; set; }

        public Zoo(string name, DateTime foundingYear)
        {
            Name = name;
            FoundingYear = foundingYear;
            Enclosures = new List<Enclosure>();
            Zookeepers = new List<Zookeeper>();
            TotalFoodCost = 0.0;
        }

        public void AddEnclosure(Enclosure zooEnclosure)
        {
            Enclosures.Add(zooEnclosure);
            UpdateTotalFoodCost();
        }

        public void DeleteEnclosure(string enclosureName)
        {
            Enclosure enclosureToRemove = Enclosures.Find(e => e.Name.Equals(enclosureName, StringComparison.OrdinalIgnoreCase));
            if (enclosureToRemove != null)
            {
                Enclosures.Remove(enclosureToRemove);
                Console.WriteLine($"Enclosure '{enclosureName}' removed.");
                UpdateTotalFoodCost();
            }
            else
            {
                Console.WriteLine($"Enclosure '{enclosureName}' not found.");
            }
        }
        public void UpdateTotalFoodCost()
        {
            double totalCost = 0;
            foreach (var enclosure in Enclosures)
            {
                totalCost += enclosure.CalculateEnclosureFoodCost();
            }
            TotalFoodCost = totalCost;
        }
        public void DisplayZooFoodCost()
        {
            Console.WriteLine($"Food cost for Zoo: {Name} (Founded: {FoundingYear})");
            double totalCost = 0;

            Console.WriteLine("\nFutterbedarf für den Zoo:");
            Console.WriteLine(new string('-', 115));
            Console.WriteLine($"{"Enclosure",-20} {"Animal",-20} {"Food",-20} {"Amount",-10} {"Unit",-10} {"Cost (€/Unit)",-15} {"Total Cost (€)",-15}");
            Console.WriteLine(new string('-', 115));

            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.GetAnimals())
                {
                    foreach (var food in animal.GetMenu())
                    {
                        double totalFoodCost = food.Value * food.Key.UnitPrice;
                        totalCost += totalFoodCost;

                        Console.WriteLine($"{enclosure.Name,-20} {animal.Name,-20} {food.Key.Name,-20} {food.Value,-10} {food.Key.Unit,-10} {food.Key.UnitPrice,10:C2} {totalFoodCost,15:C2}");
                    }
                }
            }

            Console.WriteLine("\nZusammenfassung der Futtermittel für den Zoo:");
            Console.WriteLine(new string('-', 115));
            Console.WriteLine($"{"Food",-20} {"Amount",-10} {"Unit",-10} {"Cost (€/Unit)",-15} {"Total Cost (€)",-15}");
            Console.WriteLine(new string('-', 115));

            var groupedFood = new Dictionary<string, (double totalAmount, Food food)>();

            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.GetAnimals())
                {
                    foreach (var food in animal.GetMenu())
                    {
                        if (groupedFood.ContainsKey(food.Key.Name))
                        {
                            groupedFood[food.Key.Name] = (groupedFood[food.Key.Name].totalAmount + food.Value, food.Key);
                        }
                        else
                        {
                            groupedFood[food.Key.Name] = (food.Value, food.Key);
                        }
                    }
                }
            }


            foreach (var entry in groupedFood)
            {
                double totalFoodCost = entry.Value.totalAmount * entry.Value.food.UnitPrice;
                Console.WriteLine($"{entry.Value.food.Name,-20} {entry.Value.totalAmount,-10} {entry.Value.food.Unit,-10} {entry.Value.food.UnitPrice,10:C2} {totalFoodCost,15:C2}");
            }

            Console.WriteLine(new string('-', 115));
            Console.WriteLine($"{"Total Zoo Food Cost",-95} {totalCost,15:C2}");
        }
        public double GetTotalFoodCost()
        {
            return TotalFoodCost;
        }
        public void AddKeeper(Zookeeper zookeeper)
        {
            Zookeepers.Add(zookeeper);
        }
        public void StructureInfo()
        {
            Console.WriteLine($"├── Zoo: {Name}, gegründet {FoundingYear}");
            foreach (var enclosure in Enclosures)
            {
                enclosure.StructureInfo();
            }
            foreach (var zookeeper in Zookeepers)
            {
                zookeeper.DisplayInfo();
            }
        }
    }
}