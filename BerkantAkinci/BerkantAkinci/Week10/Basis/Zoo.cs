using System;
using Org.BouncyCastle.Asn1.Icao;
using ZstdSharp.Unsafe;

namespace BerkantAkinci.Week10
{
    public class Zoo
    {
        public string ZooName;
        public List<ZooWorker> WorkersList = new List<ZooWorker>();
        public List<Animal> Animals;
        public int FoundingYear;
        public List<Enclosure> EnclosureList;
        public Dictionary<AnimalFood, double> DemandList;
        public List<AnimalDoctor> DoctorList;

        public Zoo(string zooName, int foundingYear)
        {
            ZooName = zooName;
            FoundingYear = foundingYear;
            DemandList = new Dictionary<AnimalFood, double>();
            EnclosureList = new List<Enclosure>();
            DoctorList = new List<AnimalDoctor>();
            Animals = new List<Animal>();

        }

        public void PrintAll()
        {
            foreach (Enclosure enclosure in EnclosureList)
            {
                foreach (Animal animal in enclosure.Animals)
                {
                    foreach (KeyValuePair<AnimalFood, double> animalfood in animal.animalFoodList)
                    {
                        if (DemandList.ContainsKey(animalfood.Key))
                        {
                            DemandList[animalfood.Key] += animalfood.Value;
                        }

                        else
                        {
                            DemandList[animalfood.Key] = animalfood.Value;
                        }
                    }
                }
            }
            System.Console.WriteLine("Futterliste:");
            System.Console.WriteLine("-------------------------------------------");

            double sum = 0;
            double sumAll = 0;

            foreach (KeyValuePair<AnimalFood, double> food in DemandList)
            {
                sum = food.Value * food.Key.UnitPrice;
                sumAll += sum;

                System.Console.WriteLine($"{food.Key.FoodName,-15} {food.Value,6:F2} {food.Key.Unit,-4} {sum,10:F2} €");
            }
            System.Console.WriteLine("-------------------------------------------");
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

        public void AddZooWorker(ZooWorker zooWorker)
        {
            WorkersList.Add(zooWorker);
        }

        public void RemoveZooWorker(ZooWorker zooWorker)
        {
            WorkersList.Remove(zooWorker);
        }

        public void AddDoctor(AnimalDoctor animalDoctor)
        {
            DoctorList.Add(animalDoctor);
        }

        public void RemoveDoctor(AnimalDoctor animalDoctor)
        {
            DoctorList.Remove(animalDoctor);
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
                        if (count != 0)
                        {
                            Console.Write($", ");
                        }
                        Console.Write($"{workers.WorkerName}");

                        count++;
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

        public void PrintSimulation1()
        {
            foreach (Enclosure enclosure in EnclosureList)
            {
                System.Console.WriteLine($"{enclosure.EnclosureName}:");

                foreach (ZooWorker zooworker in enclosure.WorkersList)
                {
                    foreach (Animal animal in enclosure.Animals)
                    {
                        foreach (KeyValuePair<AnimalFood, double> food in animal.animalFoodList)
                        {
                            System.Console.WriteLine($"{zooworker.WorkerName} füttert {animal.Species} ({animal.AnimalName}) mit {food.Value} {food.Key.Unit} {food.Key.FoodName}");
                        }
                    }
                }
                System.Console.WriteLine();
            }
        }

        public void HealthAndBite()
        {
            foreach (Enclosure enclosure in EnclosureList)
            {
                System.Console.WriteLine($"{enclosure.EnclosureName}:");

                foreach (Animal animal in enclosure.Animals)
                {
                    double restHealth = animal.Health - animal.Bite;
                    System.Console.WriteLine($"{animal.AnimalName} ({animal.Species}) wurde gebissen, ihr/sein restliches Leben beträgt {restHealth}.");


                }
                System.Console.WriteLine();
            }
        }

        public void DoctorHelp()
        {
            foreach (AnimalDoctor animalDoctor in DoctorList)
            {
                foreach (Enclosure enclosure in animalDoctor.EnclosureList)
                {
                    foreach (Animal animal in enclosure.Animals)
                    {
                        double restHealth = animal.Health - animal.Bite;
                        double newHealth = restHealth * 1.01;

                    

                        System.Console.Write($"{animalDoctor.DoctorName} geht zum Gehege ");
                        System.Console.Write($"'{enclosure.EnclosureName}' und heilt das Tier , ");
                        System.Console.WriteLine($"{animal.AnimalName} ({animal.Species}) von {restHealth} auf {newHealth}");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}