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

        private int EnclosureNr;
        internal int _EnclosureNr
        {
            get => EnclosureNr;
            set => EnclosureNr = value;
        }

        internal List<Animal> Animals = new List<Animal>();

        internal Enclosure(int enclosurenr, string enclosurename)
        {
            Enclosurename = enclosurename;
            EnclosureNr = enclosurenr;
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