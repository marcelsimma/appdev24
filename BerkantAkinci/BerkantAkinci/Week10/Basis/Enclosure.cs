using System;

namespace BerkantAkinci.Week10
{
    public class Enclosure
    {
        public string EnclosureName;

        public List<Animal> Animals = new List<Animal>();
        public List<ZooWorker> Workers = new List<ZooWorker>();

        public Enclosure(string enclosureName)
        {
            EnclosureName = enclosureName;
        }

        public void AddAnimal(Animal AnimalName)
        {
            Animals.Add(AnimalName);
        }

        public void RemoveAnimal(Animal AnimalName)
        {
            Animals.Remove(AnimalName);
        }

        public void AddWorker(ZooWorker zooWorker)
        {
            Workers.Add(zooWorker);
        }

        public void RemoveWorker(ZooWorker zooWorker)
        {
            Workers.Remove(zooWorker);
        }
    }
}