using System;
namespace JulianStroehle.Week10
{
    internal class Enclosure
    {
        internal string Name;
        internal int ID;
        internal List<Animal> Animals;
        internal Enclosure(string name, int id)
        {
            Name = name;
            ID = id;
            Animals = new List<Animal>();
        }
        internal string GetInfo()
        {
            bool empty = true;
            string returnValue = string.Format("{0} Enclosure: {1}", ID, Name);
            foreach (Animal animal in Animals)
            {
                returnValue += "\n│     └── ";
                returnValue += ID + "." + animal.GetInfo();
                empty = false;
            }
            if (empty)
            {
                returnValue += "\n│     └── (Empty)";
            }
            return returnValue;
        }
        internal void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        internal void RemoveAnimal(int id)
        {
            Animals.RemoveAt(id);
        }
    }
}