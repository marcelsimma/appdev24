using BarbaraMarte.Week02;

namespace BarbaraMarte.Zoo.Part3
{
    class ZooInfo
    {
        public string _ZooName { get; private set; }
        public DateTime _FoundingYear { get; private set; }
        private List<Enclosure> EnclosureList { get; set; }
        private List<(string foodName, string unit, double quantity, double totalCost)> _totalFood = new List<(string foodName, string unit, double quantity, double totalCost)>();

        public ZooInfo(string zooName, DateTime foundingYear)
        {
            _ZooName = zooName;
            _FoundingYear = foundingYear;
            EnclosureList = new List<Enclosure>();
        }
        public void AddEnclosure(Enclosure enclosure)
        {
            int id = EnclosureList.Count + 1;
            enclosure._ID = id;
            EnclosureList.Add(enclosure);
        }
        public void DeleteEnclosure(Enclosure enclosure)
        {
            EnclosureList.Remove(enclosure);
        }

        public void UpdateFoodRequirements()
        {
            var _AnimalFoodPrint = new Dictionary<AnimalFood, double>();
            foreach (var enclosureList in EnclosureList)    // EnclosureList, AnimalList, FoodList
            {
                foreach (var animal in enclosureList._AnimalList)
                {
                    foreach (var food in animal._AnimalFood)
                    {
                        if (_AnimalFoodPrint.ContainsKey(food.Key))
                        {
                            _AnimalFoodPrint[food.Key] += food.Value;
                        }
                        else
                        {
                            _AnimalFoodPrint[food.Key] = food.Value;
                        }

                    }
                }
            }
            _totalFood.Clear();
            foreach (var entry in _AnimalFoodPrint)
            {
                AnimalFood animalFood = entry.Key;
                double quantity = entry.Value;
                double cost1 = animalFood.CalculateCost(quantity);

                _totalFood.Add((animalFood._NameOfFood, animalFood._FoodUnit, quantity, cost1));
            }
        }
        public void PrintFoodRequirements()
        {
            UpdateFoodRequirements();

            System.Console.WriteLine("Food use");
            System.Console.WriteLine("------------------------------------------");
            double totalCost = 0;

            foreach (var entry in _totalFood)
            {
                System.Console.WriteLine($"{entry.foodName,-12} {entry.quantity,10:F2} {entry.unit,4:F2} {entry.totalCost,8:F2} Euro");
                totalCost += entry.totalCost;
            }
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine($"Total cost: {totalCost,25:F2} Euro");
        }
        public void StructureInfo()
        {
            System.Console.WriteLine($"├── Zoo {_ZooName}, founded in the Year {_FoundingYear}");
            foreach (var enclosure in EnclosureList)
            {
                System.Console.WriteLine($"│    ├── Enclosure: {enclosure._EnclosureType}");
                foreach (var animal in enclosure._AnimalList)
                {
                    System.Console.WriteLine($"│         ├── Animal Name: {animal._AnimalName}, Species: {animal._AnimalSpecies}");
                }
            }
            System.Console.WriteLine("..........................................................");
            PrintFoodRequirements();
            // System.Console.WriteLine($"Enclosure food Count: {_FoodEnclosureCount,6}\nAnimal food Cont: {_FoodAnimalCount,10}\nTotal food count: {_FoodCountTotal,10}");
        }
    }
}