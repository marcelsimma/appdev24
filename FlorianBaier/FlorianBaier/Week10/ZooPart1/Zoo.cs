using System;

namespace FlorianBaier.Week10.ZooPart1
{

    internal class Zoo
    {
        public string Name { get; set; }
        public string FoundingYear { get; set; }
        private List<Enclosure> Enclosures { get; set; }

        public Zoo(string name, string foundingYear)
        {
            Name = name;
            FoundingYear = foundingYear;
            Enclosures = new List<Enclosure>();
        }

        public void AddEnclosure(Enclosure zooEnclosure)
        {
            Enclosures.Add(zooEnclosure);
        }

        public void DeleteEnclosure(string enclosureName)
        {
            Enclosure enclosureToRemove = Enclosures.Find(e => e.Name.Equals(enclosureName, StringComparison.OrdinalIgnoreCase));
            if (enclosureToRemove != null)
            {
                Enclosures.Remove(enclosureToRemove);
                Console.WriteLine($"Enclosure '{enclosureName}' removed.");
            }
            else
            {
                Console.WriteLine($"Enclosure '{enclosureName}' not found.");
            }
        }
        public void StructureInfo()
        {
            Console.WriteLine($"├── Zoo: {Name}, gegründet {FoundingYear}");
            foreach (var enclosure in Enclosures)
            {
                Console.WriteLine($"│   ├── Gehege: {enclosure.Name}");
            }
        }
    }
}