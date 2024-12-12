using System;
using System.Runtime.InteropServices.Marshalling;
using CheyenneHarbarth.Zoo.Zoostructure.Animals;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    internal class Enclosure
    {
        private string Enclosurename;
        internal string _Enclosurename
        {
            get => Enclosurename;
            set => Enclosurename = value;
        }

        internal List<Animal> Animals = new List<Animal>();

        internal Enclosure(string enclosurename)
        {
            Enclosurename = enclosurename;
        }
        internal void AddAnimal(Animal animalname)
        {

            Animals.Add(animalname);
        }

        internal void RemoveAnimal(string animalname)
        {
            foreach (Animal animal in Animals)
            {
                if (animal._Animalname == animalname)
                {
                    Animals.Remove(animal);
                    break;
                }
            }
        }
    }
}