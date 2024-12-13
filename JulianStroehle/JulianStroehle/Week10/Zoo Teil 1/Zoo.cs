using System;
namespace JulianStroehle.Week10
{
    internal class Zoo
    {
        internal string Name;
        internal DateTime FoundingYear;
        internal List<Enclosure> Enclosures;
        internal List<Zookeeper> Zookeepers;
        internal Zoo(string name, DateTime foundingYear)
        {
            Name = name;
            FoundingYear = foundingYear;
            Enclosures = new List<Enclosure>();
            Zookeepers = new List<Zookeeper>();
        }
        internal void AddKeeper(Zookeeper keeper)
        {
            Zookeepers.Add(keeper);
        }
        internal void RemoveKeeper(int id)
        {
            Zookeepers.RemoveAt(id-1);
        }
        internal void AddEnclosure(Enclosure enclosure)
        {
            Enclosures.Add(enclosure);
        }
        internal void RemoveEnclosure(int id)
        {
            Enclosures.RemoveAt(id-1);
        }
        internal string GetZooInfo()
        {
            double sumPrice = 0;
            string returnValue = string.Format("┌── Zoo: {0}, Founded: {1}", Name, FoundingYear.ToString("yyyy"));
            foreach (Enclosure enclosure in Enclosures)
            {
                returnValue += "\n│  ├── ";
                if (enclosure.ID == Enclosures.Count)
                {
                    returnValue += "\r│  └── ";
                }
                returnValue += enclosure.GetInfo();
                foreach (Animal animal in enclosure.Animals)
                {
                    foreach (Food food in animal.SumFood.Keys)
                    {
                        sumPrice += food.GetPrice(animal.SumFood[food]);
                    }
                }
            }
            returnValue += "\n└" + new string('─', 46);
            returnValue += "\n" + string.Format("{0,-19}", "Sum of price for food:") + string.Format("{0,24}", Math.Round(sumPrice, 2) + " €");
            return returnValue;

        }
    }
}