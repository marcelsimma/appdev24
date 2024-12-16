using System;
using Org.BouncyCastle.Asn1.Icao;
using ZstdSharp.Unsafe;

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
                        if (demandList.ContainsKey(animalfood.Key))
                        {
                            demandList[animalfood.Key] += animalfood.Value;
                        }

                        else
                        {
                            demandList[animalfood.Key] = animalfood.Value;
                        }
                    }
                }
            }
            System.Console.WriteLine("Futterliste:");
            System.Console.WriteLine("-------------------------------------------------");

            double sum = 0;
            double sumAll = 0;


            foreach (KeyValuePair<AnimalFood, double> food in demandList)
            {
                sum = food.Value * food.Key.UnitPrice;
                sumAll += sum;


                System.Console.WriteLine($"{food.Key.FoodName,-15} {food.Value,6:F2} {food.Key.Unit,-4} {sum,10:F2} €");
            }
            System.Console.WriteLine("-------------------------------------------------");
            System.Console.WriteLine($"{"Gesamtbetrag: ",-30}{sumAll,8:F2} €");
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