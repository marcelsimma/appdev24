using System;
using MySql.Data.MySqlClient;
using CheyenneHarbarth.Zoo.Zoostructure.Animals;
using CheyenneHarbarth.Zoo.Zoostructure.Foods;
using Org.BouncyCastle.Tls;
using CheyenneHarbarth.Zoo.Zoostructure.Worker;
using CheyenneHarbarth.Week10.Zoo.Zoostructure;
using System.Data;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    public class ZooMain
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=QRUP369_purq;
            database=zoodatenbank";

            while (true)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        Zoo MyZoo = ReadZoo(connection);
                        MyZoo.PrintZoo();

                        MyZoo.AddEnclosure(connection);

                        MyZoo.PrintZoo();

                        /* foreach (Enclosure enclosure in MyZoo.Zoostructure)
                        {
                            foreach (Animal animal in enclosure.Animals)
                            {
                                animal.PrintAnimalAndFood();
                            }
                        }

                        foreach (Zookeeper zookeeper in MyZoo.Zookeepers)
                        {
                            zookeeper.PrintResponsibleList();
                        }

                        MyZoo.CalculateFoodBill(MyZoo.FoodConsumption); */

                        connection.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.Write(ex.Message);
                    }
                }
                break;
            }
        }

        //Aus Datenbank lesen und ein Zoo-Objekt erstellen
        internal static Zoo ReadZoo(MySqlConnection connection)
        {
            Zoo MyZoo = null;
            string query = @"SELECT Zooname , FoundingYear
                FROM zoo;
                
                SELECT EnclosureNr, Area
                FROM enclosure;
                
                SELECT InventoryNr, Foodname, Price, Measurement, SUM(foodlist.Amount) AS Amount
                FROM food
                JOIN foodlist ON food.InventoryNr = foodlist.FoodNr
                GROUP BY Foodname, Price, Measurement, InventoryNr;
                
                SELECT Animalname, Animalrace, Habitat, enclosure.Area AS EnclosureName
                FROM animal
                JOIN enclosure ON animal.Habitat = enclosure.EnclosureNr;
                
                SELECT Animalname, FoodNr, food.Foodname AS Foodname, Amount, Price, Measurement
                FROM zoodatenbank.foodlist
                JOIN food ON foodlist.FoodNr = food.InventoryNr;
                
                SELECT Firstname, Lastname, Workplace, carelist.KeeperID, carelist.EnclosureNr, enclosure.Area
                FROM zoodatenbank.zookeeper
                JOIN carelist ON zookeeper.KeeperID = carelist.KeeperID
                JOIN enclosure ON carelist.EnclosureNr = enclosure.EnclosureNr;";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MyZoo = new Zoo(reader.GetString("Zooname"), reader.GetDateTime("FoundingYear"));
                    }
                }
                //Gehege auslesen
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string area = reader.GetString("Area");
                        int enclosureNr = reader.GetInt32("EnclosureNr");                   //Namenskonvention für lokale Variablen: camelCase

                        MyZoo.zooStructure.Add(new Enclosure(enclosureNr, area));
                    }

                }
                //Futter auslesen
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string foodname = reader.GetString("Foodname");
                        double price = reader.GetDouble("Price");
                        string measurement = reader.GetString("Measurement");
                        int inventoryNr = reader.GetInt32("InventoryNr");
                        double amount = reader.GetDouble("Amount");

                        MyZoo.foodConsumption.Add(new Food(foodname, price, measurement, inventoryNr), amount);
                    }
                }
                //Tiere auslesen
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string animalName = reader.GetString("Animalname");
                        string animalRace = reader.GetString("Animalrace");
                        int habitat = reader.GetInt32("Habitat");

                        foreach (Enclosure enclosure in MyZoo.zooStructure)
                        {
                            if (enclosure.EnclosureNr == habitat)
                            {
                                enclosure.animals.Add(new Animal(animalName, animalRace));
                            }
                        }
                    }
                }
                //Futter auslesen und bei Tieren speichern
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string animalName = reader.GetString("Animalname");
                        int foodNr = reader.GetInt32("FoodNr");
                        string foodName = reader.GetString("Foodname");
                        double amount = reader.GetDouble("Amount");
                        double price = reader.GetDouble("Price");
                        string measurement = reader.GetString("Measurement");

                        foreach (Enclosure enclosure in MyZoo.zooStructure)
                        {
                            foreach (Animal animal in enclosure.animals)
                            {
                                if (animalName == animal.AnimalName)
                                {
                                    animal.AddFood(new Food(foodName, price, measurement, foodNr), amount);
                                }
                            }
                        }
                    }
                }
                //Zoowärter auslesen und im Zoo speichern
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        int keeperID = reader.GetInt32("KeeperID");
                        string firstName = reader.GetString("Firstname");
                        string lastName = reader.GetString("Lastname");
                        int enclosureNr = reader.GetInt32("EnclosureNr");
                        string area = reader.GetString("Area");

                        MyZoo.zooKeepers.Add(new Zookeeper(keeperID, firstName, lastName));
                        foreach (Zookeeper zookeeper in MyZoo.zooKeepers)
                        {
                            if (keeperID == zookeeper.KeeperID)
                            {
                                zookeeper.responsibleEnclosures.Add(new Enclosure(enclosureNr, area));
                            }
                        }
                    }
                }
            }
            return MyZoo;
        }
    }
}

/* Enclosure AlpineMeadow = new Enclosure("Alpenwiese: neutral, offen und hügelig");
Enclosure Icelake = new Enclosure("Eissee: sehr kalt");
Enclosure Marsh = new Enclosure("Ried: kalt, matschig");
Enclosure Forest = new Enclosure("Nadelwald: kalt, dicht bewaldet");
Enclosure Jungle = new Enclosure("Urwald: warm, dicht bewachsen");

MyZoo.AddEnclosure(AlpineMeadow);
MyZoo.AddEnclosure(Icelake);
MyZoo.AddEnclosure(Marsh);
MyZoo.AddEnclosure(Forest);
MyZoo.AddEnclosure(Jungle);

Food hay = new Food("Heu (2.Schnitt)", "kg", 0.25);
Food water = new Food("Wasser", "L", 0.18);
Food straw = new Food("Stroh", "kg", 0.15);
Food meat = new Food("Rohfleisch", "kg", 4.79);
Food seeds = new Food("Körner", "kg", 2.99);
Food fish = new Food("Makrele", "kg", 19.99);

Animal animal1 = new Animal("Betty", "Hochlandrind", hay, 10);
Animal animal2 = new Animal("Boo", "Hochlandrind", hay, 12);
Animal animal3 = new Animal("Pengi", "Kaiserpinguin", fish, 9);
Animal animal4 = new Animal("Woddle", "Zwergpinguin", fish, 5);
Animal animal5 = new Animal("Tigris", "Königstiger", meat, 15);
Animal animal6 = new Animal("Stripy", "Königstiger", meat, 13);

animal1.AddFood(water, 50);
animal2.AddFood(water, 56);
animal4.AddFood(water, 34);
animal5.AddFood(water, 42);
animal2.AddFood(straw, 5);

AlpineMeadow.AddAnimal(animal1);
AlpineMeadow.AddAnimal(animal2);
Icelake.AddAnimal(animal3);
Icelake.AddAnimal(animal4);
Jungle.AddAnimal(animal5);
Jungle.AddAnimal(animal6); */


//Methode wenn mehrer Zoos in der Datenbank sind
/* internal static Zoo CreateZooObject(MySqlConnection connection)
    {
        Dictionary<string, DateTime> Zoos = new Dictionary<string, DateTime>();
        string query = @"SELECT Zooname, FoundingYear
            FROM zoo;";

        MySqlCommand command = new MySqlCommand(query, connection);

        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Zoos.Add(reader.GetString("Zooname"), reader.GetDateTime("FoundingYear"));
            }
        }
        foreach (KeyValuePair<string, DateTime> zoos in Zoos)
        {
            Console.WriteLine($"{zoos.Key,-30} | Gründungsjahr: {zoos.Value,6}");
        }

        while (true)
        {
            Console.WriteLine("Mit welchem Zoo möchtest du arbeiten?");
            string input = Console.ReadLine();
            if (Zoos.ContainsKey(input))
            {
                Zoo MyZoo = new Zoo(input, Zoos[input]);
                return MyZoo;
            }
            else
            {
                Console.WriteLine("Bitte gib einen gültigen Zoonamen ein!");
            }
        }
    } */