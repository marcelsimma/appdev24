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

        public void SimulateDay()
        {
            var random = new Random();

            foreach (var animal in _animals.Where(a => a.IsAlive).ToList())
            {
                if (random.NextDouble() < 0.4)
                {
                    var potentialTargets = _animals.Where(a => a != animal && a.IsAlive).ToList();
                    if (potentialTargets.Any())
                    {
                        var target = potentialTargets[random.Next(potentialTargets.Count)];
                        animal.Bite(target);
                    }
                }
            }

            var deadAnimals = _animals.Where(a => !a.IsAlive).ToList();
            foreach (var deadAnimal in deadAnimals)
            {
                Console.WriteLine($"{deadAnimal.Name} ({deadAnimal.Species}) wird aus dem Gehege {Name} entfernt.");
                _animals.Remove(deadAnimal);
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