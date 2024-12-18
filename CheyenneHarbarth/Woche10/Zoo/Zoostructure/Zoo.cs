using System;
using System.Dynamic;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using CheyenneHarbarth.Zoo.Zoostructure.Animals;
using CheyenneHarbarth.Zoo.Zoostructure.Foods;
using CheyenneHarbarth.Zoo.Zoostructure.Worker;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    internal class Zoo
    {
        private string Zooname;
        internal string _Zooname
        {
            get => Zooname;
            set => Zooname = value;
        }

        private DateTime FoundingYear;
        internal DateTime _FoundingYear
        {
            get => FoundingYear;
            set => FoundingYear = value;
        }
        internal List<Enclosure> Zoostructure = new List<Enclosure>();

        internal Dictionary<Food, double> FoodConsumption = new Dictionary<Food, double>();

        internal List<Zookeeper> Zookeepers = new List<Zookeeper>();

        internal Zoo(string zooname, DateTime foundingyear)
        {
            Zooname = zooname;
            FoundingYear = foundingyear;
        }

        internal void PrintZoo()
        //Umschreiben zum Auslesen der Datenbank
        {
            Console.WriteLine($"\n|--- Zoo: {Zooname}, gegründet {FoundingYear.ToString("d")}");
            if (Zoostructure.Count > 0)
            {
                foreach (Enclosure enclosure in Zoostructure)
                {
                    Console.WriteLine("|    |--- Gehege: " + enclosure._Enclosurename);
                    if (enclosure.Animals.Count > 0)
                    {
                        foreach (Animal animal in enclosure.Animals)
                        {
                            Console.WriteLine("|         |--- " + animal.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("|         |--- (leer)");
                    }
                    //Futter muss in der Ausgabe ausgegeben werden
                    //Arbeiter müssen ebenfalls in der Ausgabe ausgegeben werden
                }
            }
            else
            {
                Console.WriteLine("Es sind noch keine Gehege vorhanden!");
            }
            Console.WriteLine();
        }

        internal void AddEnclosure(Enclosure enclosure)
        {
            Zoostructure.Add(enclosure);
        }

        internal void RemoveEnclosure(string enclosurename)
        {
            foreach (Enclosure enclosure in Zoostructure)
            {
                if (enclosure._Enclosurename == enclosurename)
                {
                    Zoostructure.Remove(enclosure);
                    break;
                }
            }
        }

        internal void AddZooworker(Zookeeper zookeeper)
        {
            Zookeepers.Add(zookeeper);
        }

        internal void RemoveZooworker(int zookeeperID)
        {
            foreach (Zookeeper zooworker in Zookeepers)
            {
                if (zooworker._KeeperID == zookeeperID)
                {
                    Zookeepers.Remove(zooworker);
                    break;
                }
            }
        }

        //sinnlos
        internal void CalculateFoodConsumption()
        {
            foreach (Enclosure enclosure in Zoostructure)
            {
                foreach (Animal animal in enclosure.Animals)
                {
                    foreach (KeyValuePair<Food, double> Feed in animal.Requirement)
                    {
                        if (FoodConsumption.ContainsKey(Feed.Key))
                        {
                            FoodConsumption[Feed.Key] += Feed.Value;
                        }
                        else
                        {
                            FoodConsumption[Feed.Key] = Feed.Value;
                        }
                    }
                }
            }

            Console.WriteLine("\nFutterbedarf\n-------------------------");
            foreach (KeyValuePair<Food, double> Feed in FoodConsumption)
            {
                Console.WriteLine($"{Feed.Key._Foodname,-15}{Feed.Value,6:F1} {Feed.Key._Measurement,-3}");
            }
            Console.WriteLine();
        }

        internal void CalculateFoodBill(Dictionary<Food, double> foodconsumption)
        {
            double Sum = 0;
            double TempResult;

            Console.WriteLine("\nFutterbedarf\n-----------------------------------------");
            foreach (KeyValuePair<Food, double> Feed in foodconsumption)
            {
                TempResult = Feed.Value * Feed.Key._PricePerMeasurement;
                Console.WriteLine($"{Feed.Key._Foodname,-18}{Feed.Value,6:F1} {Feed.Key._Measurement,-3}{TempResult,10:F2} €");
                Sum += TempResult;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Summe {Sum,32:F2} €");
            Console.WriteLine();
        }
    }
}