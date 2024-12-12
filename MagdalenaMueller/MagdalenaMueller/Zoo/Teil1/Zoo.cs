using System;

namespace MagdalenaMueller.Zoo
{
    public class Zoo
    {
        internal string ZooName;
        internal string Foundingyear;
        internal List<Cage> cages;
        internal List<ZooKeeper> Zookeepers;

        public Zoo(string zooName, string foundingYear)
        {
            ZooName = zooName;
            Foundingyear = foundingYear;
            cages = new List<Cage>();
            Zookeepers = new List<ZooKeeper>();
        }

        

        public static void WriteZoo(Zoo zoo)
        {
            Console.WriteLine($"│---Zoo: {zoo.ZooName} Gründung: {zoo.Foundingyear}");
            Console.WriteLine("├───┬───────────────────────────────────────────");

            foreach (var cagename in Cage.listOfCages)
            {
                Console.WriteLine($"│   │---Gehege: {cagename.Key.CageName}");
                Console.WriteLine("├───┼───┬───────────────────────────────────────");

                if (cagename.Value.Count == 0) 
                {
                    Console.WriteLine($"│   │   │ (leer)");
                }
                foreach (var animal in cagename.Value)
                {
                    Console.WriteLine($"│   │   │ {animal.AnimalName}, {animal.Genus}");
                }
                Console.WriteLine("├───┼───────────────────────────────────────────");
            }
        }

        public static void WriteFoodRequirements()
        {
            Dictionary<Food,double> foodRequrements = Animal.foodZoo;
            
            double sum = 0;

            Console.WriteLine("-------------------------+--------");
            foreach(var food in foodRequrements)
            {
                Console.WriteLine($"{food.Key.FoodName,-15} {food.Value,-4} {food.Key.Unit,-3} | {food.Value * food.Key.PricePerUnit}");
                sum += food.Value*food.Key.PricePerUnit;
            }
            Console.WriteLine("-------------------------+--------");
            Console.WriteLine($"Summe:                   | {sum}");
        }
    }
}