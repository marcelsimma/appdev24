using System;

namespace FlorianBaier.Week10.ZooPart2
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

        public void DeleteAnimal(string animalName)
        {
            Animal animalToRemove = Animals.Find(a => a.Name.Equals(animalName, StringComparison.OrdinalIgnoreCase));
            if (animalToRemove != null)
            {
                Animals.Remove(animalToRemove);
                Console.WriteLine($"Animal '{animalName}' removed from {Name}.");
            }
            else
            {
                Console.WriteLine($"Animal '{animalName}' not found in {Name}.");
            }
        }
        public void DisplayAnimals()
        {
            if (Animals.Count == 0)
            {
                Console.WriteLine("│     ├── (leer)");
            }
            else
            {
                foreach (var animal in Animals)
                {
                    Console.WriteLine($"│     ├── {animal.Name}, {animal.Species}");
                }
            }
        }
    }

}
