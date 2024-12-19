using System.Collections.Generic;

namespace JonasWehinger.Models
{
    public class State
    {
        public string Name { get; set; }
        public string CapitalCityName { get; set; }
        public string Continent { get; set; }
        public List<Province> Provinces { get; set; } = new List<Province>();

        public int GetTotalPopulation()
        {
            int totalPopulation = 0;
            foreach (var province in Provinces)
            {
                totalPopulation += province.Population;
            }
            return totalPopulation;
        }

        public void PrintStateInfo()
        {
            Console.WriteLine($"Staat: {Name}");
            Console.WriteLine($"Hauptstadt: {CapitalCityName}");
            Console.WriteLine($"Kontinent: {Continent}");
            Console.WriteLine($"Gesamtbevölkerung: {GetTotalPopulation()}");
            Console.WriteLine("Provinzen:");
            foreach (var province in Provinces)
            {
                Console.WriteLine($"  - Name: {province.Name}, Hauptstadt: {province.CapitalCityName}, Bevölkerung: {province.Population}");
            }
            Console.WriteLine();
        }
    }
}
