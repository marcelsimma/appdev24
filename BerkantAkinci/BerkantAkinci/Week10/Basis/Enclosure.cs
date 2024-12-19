using System;

namespace BerkantAkinci.Week10
{
    public class Enclosure
    {
        public string EnclosureName;

        public List<Animal> Animals;
        public List<ZooWorker> WorkersList;

        public Enclosure(string enclosureName)
        {
            EnclosureName = enclosureName;
            Animals = new List<Animal>();
            WorkersList = new List<ZooWorker>();
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
            WorkersList.Add(zooWorker);
        }

        public void RemoveWorker(ZooWorker zooWorker)
        {
           WorkersList.Remove(zooWorker);
        }
    }
}