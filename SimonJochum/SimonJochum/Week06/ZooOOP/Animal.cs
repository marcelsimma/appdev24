using System;

namespace SimonJochum.Week06.Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public override string ToString()
        {
            return $"│   ├── Tier: {Name}, Gattung: {Species}\n";
        }
    }
}