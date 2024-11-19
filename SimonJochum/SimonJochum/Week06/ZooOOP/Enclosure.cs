using System;

namespace SimonJochum.Week06.Zoo
{
    public class Enclosure
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Enclosure(string name)
        {
            Name = name;
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public bool RemoveAnimal(string animalName)
        {
            Animal animal = Animals.Find(a => a.Name == animalName);
            if (animal != null)
            {
                Animals.Remove(animal);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string result = $"├── Gehege: {Name}\n";
            foreach (var animal in Animals)
            {
                result += animal.ToString();
            }
            return result;
        }
    }
}
