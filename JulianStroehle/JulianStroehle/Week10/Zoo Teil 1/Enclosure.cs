using System;
namespace JulianStroehle.Week10
{
    internal class Enclosure: IOutput
    {
        internal string Name;
        internal int ID;
        internal List<Animal> Animals;
        internal int deletedAnimals { get; set; } = 0;

        internal Enclosure(string name, int id)
        {
            Name = name;
            ID = id;
            Animals = new List<Animal>();
        }
        public string GetInfo()
        {
            string returnValue = string.Format("Enclosure: {0}", Name);
            return returnValue;
        }
        internal string GetAnimalsInfo()
        {
            bool empty = true;
            string returnValue = "";
            foreach (Animal animal in Animals)
            {
                returnValue += "\n│     └── ";
                returnValue += animal.GetInfo();
                empty = false;
            }
            if (empty)
            {
                returnValue += "\n│     └── (Empty)";
            }
            return returnValue;
        }
        public string GetIDs()
        {
            string returnValue = "┌" + new string('─', 5) + "┬" + new string('─', 22) + "┐";
            foreach (Animal animal in Animals)
            {
                returnValue += "\n│" + string.Format("{0,5}",animal.GetIDs() + " ") + "│" + string.Format("{0,-22}", " " + animal.Type + " " + animal.Name) + "│";
            }
            returnValue += "\n└" + new string('─', 5) + "┴" + new string('─', 22) + "┘";
            return returnValue;
        }
        internal void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        internal void RemoveAnimal(int id)
        {
            bool removed = false;
            foreach (Animal animal in Animals)
            {
                if (animal.ID == id)
                {
                    removed = Animals.Remove(animal);
                    break;
                }
            }
            if (!removed)
            {
                RemoveAnimal(id);
            }
        }
    }
}