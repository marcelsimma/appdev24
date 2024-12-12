using System;

namespace FlorianBaier.Week10.ZooPart2
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
    }
}