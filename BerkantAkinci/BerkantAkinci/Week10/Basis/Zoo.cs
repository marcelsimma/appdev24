using System;
using Org.BouncyCastle.Asn1.Icao;

namespace BerkantAkinci.Week10
{
    public class Zoo
    {
        public string ZooName;

        public int FoundingYear;

        public List<Enclosure> EnclosureList = new List<Enclosure>();

        public Dictionary<AnimalFood, double> demandList;

        public Zoo(string zooName, int foundingYear)
        {
            ZooName = zooName;
            FoundingYear = foundingYear;
            demandList = new Dictionary<AnimalFood, double>();
        }

        public void PrintAll()
        {
            foreach (Enclosure enclosure in EnclosureList)
            {
                foreach (Animal animal in enclosure.Animals)
                {
                    foreach (KeyValuePair<AnimalFood, double> animalfood in animal.animalFoodList)
                    {
                        if(demandList.ContainsKey(animalfood.Key.FoodName))
                        {
                            demandList.Add(animalfood.Key, animalfood.Value);
                        }
                    }
                }
            }

            foreach (KeyValuePair<AnimalFood, double> demandlist in demandList)
            {
                System.Console.WriteLine($"{demandlist.Key}, {demandlist.Value}");
            }
        }

        public void AddEnclosure(Enclosure EnclosureName)
        {
            EnclosureList.Add(EnclosureName);
        }

        public void RemoveEnclosure(Enclosure EnclosureName)
        {
            EnclosureList.Remove(EnclosureName);
        }

        public void ZooStructure()
        {
            Console.WriteLine($"\n|---- Zoo: {ZooName}, gegründet {FoundingYear}");
            if (EnclosureList.Count > 0)
            {

                foreach (Enclosure enclosure in EnclosureList)
                {
                    int count = 0;

                    Console.Write($"|     |---- Gehege: {enclosure.EnclosureName}, die zugehörigen sind ");
                    foreach (ZooWorker workers in enclosure.WorkersList)
                    {
                        if (count == 0)
                        {
                            Console.Write($"{workers.WorkerName}");
                            count++;
                        }
                        else
                        {
                            if (count > 0)
                            {
                                Console.Write($", {workers.WorkerName}");
                                count++;
                            }
                        }
                    }

                    System.Console.WriteLine();
                    if (enclosure.Animals.Count > 0)
                    {
                        foreach (Animal animals in enclosure.Animals)
                        {
                            Console.WriteLine("|           |---- " + animals.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("|           |---- (leer)");
                    }
                }
            }
            else
            {
                Console.WriteLine("Es sind noch keine Gehege vorhanden!");
            }
        }
    }
}