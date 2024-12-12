using System;

namespace FlorianBaier.Week10.ZooPart3
{

    public class Enclosure
    {
        public string Name { get; set; }
        private List<Animal> Animals { get; set; }
        public Enclosure(string name)
        {
            Name = name;
            Animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void DeleteAnimal(string animalName, Zoo zoo)
        {
            Animal animalToRemove = Animals.Find(a => a.Name.Equals(animalName, StringComparison.OrdinalIgnoreCase));
            if (animalToRemove != null)
            {
                Animals.Remove(animalToRemove);
                Console.WriteLine($"Animal '{animalName}' removed from {Name}.");
                zoo.UpdateTotalFoodCost();
            }
            else
            {
                Console.WriteLine($"Animal '{animalName}' not found in {Name}.");
            }
        }
        public double CalculateEnclosureFoodCost()
        {
            double totalCost = 0;
            foreach (var animal in Animals)
            {
                totalCost += animal.CalculateFoodCost();
            }
            return totalCost;
        }
        public void DisplayEnclosureFoodCost()
        {
            Console.WriteLine($"Enclosure: {Name}");
            foreach (var animal in Animals)
            {
                animal.DisplayMenu();
                Console.WriteLine();
            }
        }
        public void StructureInfo()
        {
            Console.WriteLine($"|   ├── Enclosure: {Name}");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"|   │   ├── Animal: {animal.Name}, {animal.Species}");
            }
        }
        public List<Animal> GetAnimals()
        {
            return Animals;
        }

    }
}