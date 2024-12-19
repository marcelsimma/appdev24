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
        private string _zooName;
        internal string ZooName
        {
            get => _zooName;
            set => _zooName = value;
        }

        private DateTime _foundingYear;
        internal DateTime FoundingYear
        {
            get => _foundingYear;
            set => _foundingYear = value;
        }
        internal List<Enclosure> zooStructure;

        internal Dictionary<Food, double> foodConsumption;

        internal List<Zookeeper> zooKeepers;

        internal Zoo(string zooName, DateTime foundingYear)
        {
            _zooName = zooName;
            _foundingYear = foundingYear;
            zooStructure = new List<Enclosure>();
            zooKeepers = new List<Zookeeper>();
            foodConsumption = new Dictionary<Food, double>();
        }

        internal void PrintZoo()
        //Umschreiben zum Auslesen der Datenbank
        {
            Console.WriteLine($"\n|--- Zoo: {ZooName}, gegründet {FoundingYear.ToString("d")}");
            if (zooStructure.Count > 0)
            {
                foreach (Enclosure enclosure in zooStructure)
                {
                    Console.WriteLine("|    |--- Gehege: " + enclosure.EnclosureName);
                    if (enclosure.animals.Count > 0)
                    {
                        foreach (Animal animal in enclosure.animals)
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

        internal void AddEnclosure(MySqlConnection connection)
        {
            Console.WriteLine("Wie heißt das neue Gehege?");
            zooStructure.Add(new Enclosure());

            int index = zooStructure.Count();

            string addEnclosureQuery = @"INSERT INTO enclosure (Area, Zooname)
                VALUES (@Area, @Zooname);";

            MySqlCommand addEnclosureCommand = new MySqlCommand(addEnclosureQuery, connection);
            addEnclosureCommand.Parameters.AddWithValue("Area", zooStructure.ElementAt(index - 1).EnclosureName);
            addEnclosureCommand.Parameters.AddWithValue("Zooname", ZooName);

            int newRows = addEnclosureCommand.ExecuteNonQuery();

            if (newRows > 0)
            {
                Console.WriteLine("\nDas Gehege wurde gebaut und in der DB erstellt!");
            }
        }

        internal void RemoveEnclosure(string enclosurename)
        {
            foreach (Enclosure enclosure in zooStructure)
            {
                if (enclosure.EnclosureName == enclosurename)
                {
                    zooStructure.Remove(enclosure);
                    break;
                }
            }
        }

        internal void AddZooworker(MySqlConnection connection)
        {
            Console.WriteLine("Wie heißt der neue Zoowärter? Vorname eingeben, Enter, Nachname eingeben");
            zooKeepers.Add(new Zookeeper());

            int index = zooKeepers.Count();

            string addZookeeperQuery = @"INSERT INTO zookeeper (Firstname, Lastname, Workplace)
                VALUES (@Firstname, @Lastname, @Workplace);";

            MySqlCommand addZookeeperCommand = new MySqlCommand(addZookeeperQuery, connection);
            addZookeeperCommand.Parameters.AddWithValue("Firstname", zooKeepers.ElementAt(index - 1).KeeperFirstname);
            addZookeeperCommand.Parameters.AddWithValue("Lastname", zooKeepers.ElementAt(index - 1).KeeperLastname);
            addZookeeperCommand.Parameters.AddWithValue("Workplace", ZooName);

            int newRows = addZookeeperCommand.ExecuteNonQuery();

            if (newRows > 0)
            {
                Console.WriteLine("\nEin neuer Zoowärter wurde eingestellt und in der DB erstellt!");
            }
        }

        internal void RemoveZooworker(int zookeeperID, MySqlConnection connection)
        {
            foreach (Zookeeper zooworker in zooKeepers)
            {
                if (zooworker.KeeperID == zookeeperID)
                {
                    zooKeepers.Remove(zooworker);
                    break;
                }
            }
        }

        //sinnlos
        internal void CalculateFoodConsumption()
        {
            foreach (Enclosure enclosure in zooStructure)
            {
                foreach (Animal animal in enclosure.animals)
                {
                    foreach (KeyValuePair<Food, double> feed in animal.requirement)
                    {
                        if (foodConsumption.ContainsKey(feed.Key))
                        {
                            foodConsumption[feed.Key] += feed.Value;
                        }
                        else
                        {
                            foodConsumption[feed.Key] = feed.Value;
                        }
                    }
                }
            }

            Console.WriteLine("\nFutterbedarf\n-------------------------");
            foreach (KeyValuePair<Food, double> feed in foodConsumption)
            {
                Console.WriteLine($"{feed.Key.FoodName,-15}{feed.Value,6:F1} {feed.Key.Measurement,-3}");
            }
            Console.WriteLine();
        }

        internal void CalculateFoodBill(Dictionary<Food, double> foodconsumption)
        {
            double sum = 0;
            double tempResult;

            Console.WriteLine("\nFutterbedarf\n-----------------------------------------");
            foreach (KeyValuePair<Food, double> feed in foodconsumption)
            {
                tempResult = feed.Value * feed.Key.PricePerMeasurement;
                Console.WriteLine($"{feed.Key.FoodName,-18}{feed.Value,6:F1} {feed.Key.Measurement,-3}{tempResult,10:F2} €");
                sum += tempResult;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Summe {sum,32:F2} €");
            Console.WriteLine();
        }
    }
}