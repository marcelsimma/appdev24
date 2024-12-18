using System;
namespace JulianStroehle.Week10
{
    internal class Zoo: IOutput
    {
        internal int ZooID;
        internal string Name;
        internal DateTime FoundingYear;
        internal List<Enclosure> Enclosures;
        internal List<Zookeeper> Zookeepers;
        internal List<Food> Foods;
        internal Zoo(int id, string name, DateTime foundingYear)
        {
            ZooID = id;
            Name = name;
            FoundingYear = foundingYear;
            Enclosures = new List<Enclosure>();
            Zookeepers = new List<Zookeeper>();
            Foods = new List<Food>();
        }
        internal void AddKeeper(Zookeeper keeper)
        {
            Zookeepers.Add(keeper);
        }
        internal void RemoveKeeper(int id)
        {
            Zookeepers.RemoveAt(id - 1);
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }
        internal void RemoveEnclosure(int id)
        {
            Enclosures.RemoveAt(id - 1);
        }
        internal void AddFood(Food food)
        {
            Foods.Add(food);
        }
        internal void RemoveFood(int id)
        {
            Foods.RemoveAt(id - 1);
        }
        public string GetInfo()
        {
            double sumPrice = 0;
            string returnValue = string.Format("┌── Zoo: {0}, Founded: {1}", Name, FoundingYear.ToString("yyyy"));
            foreach (Zookeeper zookeeper in Zookeepers)
            {
                foreach (Enclosure enclosure in zookeeper.EnclosureList)
                {
                    returnValue += "\n│  └── " + enclosure.GetInfo() + $", Keeper: {zookeeper.FirstName} {zookeeper.LastName}" + enclosure.GetAnimalsInfo();
                    foreach (Animal animal in enclosure.Animals)
                    {
                        foreach (Food food in animal.SumFood.Keys)
                        {
                            sumPrice += food.GetPrice(animal.SumFood[food]);
                        }
                    }
                }
            }
            returnValue += "\n└" + new string('─', 46);
            returnValue += "\n" + string.Format("{0,-19}", "Sum of price for food:") + string.Format("{0,24}", Math.Round(sumPrice, 2) + " €");
            return returnValue;
        }
        public string GetIDs()
        {
            string returnValue = "";
            foreach (Enclosure enclosure in Enclosures)
            {
                returnValue += "\n\n" + enclosure.Name + " " + enclosure.ID + "\n" + enclosure.GetIDs();
            }
            return returnValue;
        }

    }
}