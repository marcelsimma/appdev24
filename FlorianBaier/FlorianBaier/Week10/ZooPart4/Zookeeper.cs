using System;
using System.Collections.Generic;

namespace FlorianBaier.Week10.ZooPart4
{
    public class Zookeeper
    {
        public string Name { get; set; }
        public List<Enclosure> Enclosures { get; set; }

        public Zookeeper(string name)
        {
            Name = name;
            Enclosures = new List<Enclosure>();
        }

        public void AssignToEnclosure(Enclosure enclosure)
        {
            if (!Enclosures.Contains(enclosure))
            {
                Enclosures.Add(enclosure);
                Console.WriteLine($"Zookeeper {Name} assigned to the enclosure {enclosure.Name}.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Zookeeper: {Name}");
            Console.WriteLine("Responsible Enclosures:");
            foreach (var enclosure in Enclosures)
            {
                Console.WriteLine($"  - {enclosure.Name}");
            }
        }

        public List<Enclosure> GetEnclosures()
        {
            return Enclosures;
        }
    }
}