using System;

namespace BerkantAkinci.Week10
{
    public class Enclosure
    {
        public string EnclosureName;
    

        public List<Animal> Animals = new List<Animal>();
        public List<ZooWorker> WorkersList = new List<ZooWorker>();

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
            WorkersList.Add(zooWorker);
        }

        public void RemoveWorker(ZooWorker zooWorker)
        {
           WorkersList.Remove(zooWorker);
        }
    }
}