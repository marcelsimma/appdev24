using System;

namespace SimonJochum.Week10.Zoo.Zoo_Part1
{
    public class Enclosure
    {
        private string _name { get; set; }
        private List<Animal> _animals { get; set; } = new List<Animal>();

        public Enclosure(string name)
        {
            _name = name;
        }
        public string Name => _name;
        public List<Animal> Animals => _animals;

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void RemoveAnimal(string animalName)
        {
            Animal animal = _animals.Find(animal => animal.Name == animalName);
            if (animal != null)
            {
                _animals.Remove(animal);
                Console.WriteLine("Tier entfernt.");
            }
            else
            {
                Console.WriteLine("Tier nicht gefunden!");
            }
        }

        public string GetName()
        {
            string result = $"├── Gehege: {Name}\n";
            foreach (var animal in _animals)
            {
                result += animal.GetName();
            }
            return result;
        }
    }
}