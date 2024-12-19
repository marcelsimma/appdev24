using System;
using System.Runtime.InteropServices.Marshalling;
using CheyenneHarbarth.Zoo.Zoostructure.Animals;
using Mysqlx.Crud;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    internal class Enclosure
    {
        private string _enclosureName;
        internal string EnclosureName
        {
            get => _enclosureName;
            set => _enclosureName = value;
        }

        private int _enclosureNr;
        internal int EnclosureNr
        {
            get => _enclosureNr;
            set => _enclosureNr = value;
        }

        internal List<Animal> animals;

        internal Enclosure(int enclosureNr, string enclosureName)
        {
            _enclosureName = enclosureName;
            _enclosureNr = enclosureNr;
            animals = new List<Animal>();
        }

        internal Enclosure()
        {
            _enclosureName = Console.ReadLine();
        }

        internal void AddAnimal(Animal animalName)
        {

            animals.Add(animalName);
        }

        internal void RemoveAnimal(string animalName)
        {
            foreach (Animal animal in animals)
            {
                if (animal.AnimalName == animalName)
                {
                    animals.Remove(animal);
                    break;
                }
            }
        }
    }
}