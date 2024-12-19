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

                        /* foreach (Enclosure enclosure in MyZoo.Zoostructure)
                        {
                            foreach (Animal animal in enclosure.Animals)
                            {
                                animal.PrintAnimalAndFood();
                            }
                        } */

                        foreach (Zookeeper zookeeper in MyZoo.Zookeepers)
                        {
                            zookeeper.PrintResponsibleList();
                        }

                        MyZoo.CalculateFoodBill(MyZoo.FoodConsumption);

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
                        string Area = reader.GetString("Area");
                        int EnclosureNr = reader.GetInt32("EnclosureNr");

                        MyZoo.Zoostructure.Add(new Enclosure(EnclosureNr, Area));
                    }

                }
                //Futter auslesen
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string Foodname = reader.GetString("Foodname");
                        double Price = reader.GetDouble("Price");
                        string Measurement = reader.GetString("Measurement");
                        int InventoryNr = reader.GetInt32("InventoryNr");
                        double Amount = reader.GetDouble("Amount");

                        MyZoo.FoodConsumption.Add(new Food(Foodname, Price, Measurement, InventoryNr), Amount);
                    }
                }
                //Tiere auslesen
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string Animalname = reader.GetString("Animalname");
                        string Animalrace = reader.GetString("Animalrace");
                        int Habitat = reader.GetInt32("Habitat");
                        string Area = reader.GetString("EnclosureName");

                        foreach (Enclosure enclosure in MyZoo.Zoostructure)
                        {
                            if (enclosure._EnclosureNr == Habitat)
                            {
                                enclosure.Animals.Add(new Animal(Animalname, Animalrace));
                            }
                        }
                    }
                }
                //Futter auslesen und bei Tieren speichern
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        string Animalname = reader.GetString("Animalname");
                        int FoodNr = reader.GetInt32("FoodNr");
                        string Foodname = reader.GetString("Foodname");
                        double Amount = reader.GetDouble("Amount");
                        double Price = reader.GetDouble("Price");
                        string Measurement = reader.GetString("Measurement");

                        foreach (Enclosure enclosure in MyZoo.Zoostructure)
                        {
                            foreach (Animal animal in enclosure.Animals)
                            {
                                if (Animalname == animal._Animalname)
                                {
                                    animal.AddFood(new Food(Foodname, Price, Measurement, FoodNr), Amount);
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
                        int KeeperID = reader.GetInt32("KeeperID");
                        string Firstname = reader.GetString("Firstname");
                        string Lastname = reader.GetString("Lastname");
                        int EnclosureNr = reader.GetInt32("EnclosureNr");
                        string Area = reader.GetString("Area");

                        MyZoo.Zookeepers.Add(new Zookeeper(KeeperID, Firstname, Lastname));
                        foreach (Zookeeper zookeeper in MyZoo.Zookeepers)
                        {
                            if (KeeperID == zookeeper._KeeperID)
                            {
                                zookeeper.ResponsibleEnclosures.Add(new Enclosure(EnclosureNr, Area));
                            }
                        }
                    }
                }
            }
            return MyZoo;
        }
    }
}

/* internal static Enclosure ReadEnclosure(Zoo MyZoo, string enclosurename, MySqlConnection connection)
        {
            Enclosure enclosure = null;

            string getEnclosureQuery = @"SELECT Area
                FROM enclosure
                WHERE Zooname = @zooname AND Area = @Area";

            MySqlCommand getEnclosurecommand = new MySqlCommand(getEnclosureQuery, connection);
            getEnclosurecommand.Parameters.AddWithValue("@zooname", MyZoo._Zooname);
            getEnclosurecommand.Parameters.AddWithValue("@Area", enclosurename);

            using (MySqlDataReader reader = getEnclosurecommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    //enclosure = new Enclosure(reader.GetString("Area"));
                }
            }
            return enclosure;
        }

        internal static Food ReadFood(string foodname, MySqlConnection connection)
        {
            Food food = null;

            string getEnclosureQuery = @"SELECT Foodname, Price, Measurement
                FROM food
                WHERE Foodname LIKE @foodname;";

            MySqlCommand getEnclosurecommand = new MySqlCommand(getEnclosureQuery, connection);
            getEnclosurecommand.Parameters.AddWithValue("@foodname", foodname);

            using (MySqlDataReader reader = getEnclosurecommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    //food = new Food(reader.GetString("Foodname"), reader.GetDouble("Price"), reader.GetString("Measurement"));
                }
            }
            return food;
        }

        internal static Animal ReadAnimal(string animalname, Food food, MySqlConnection connection)
        {
            Animal animal = null;

            string getAnimalQuery = @"SELECT animal.Animalname AS Name, animal.Animalrace AS Race, animal.Habitat, foodlist.Amount AS Amount
                FROM animal
                JOIN foodlist ON animal.Animalname = foodlist.Animalname
                WHERE Animalname LIKE @animalname;";

            MySqlCommand getAnimalcommand = new MySqlCommand(getAnimalQuery, connection);
            getAnimalcommand.Parameters.AddWithValue("@Animalname", animalname);

            using (MySqlDataReader reader = getAnimalcommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    //animal = new Animal(reader.GetString("Name"), reader.GetString("Race"), food, reader.GetDouble("Amount"));
                }
            }
            return animal;
        }
        internal static void ReadZookeeper(string keepername, MySqlConnection connection)
        {
            string getzoonameQuery = @"SELECT Zooname
                FROM zoo;";
            MySqlCommand getzoonamecommand = new MySqlCommand(getzoonameQuery, connection);
            List<string> Zoos = new List<string>();

            using (MySqlDataReader reader = getzoonamecommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zoos.Add(reader.GetString("Zooname"));
                }
            }

            Console.WriteLine("\nIn welchem Zoo arbeitet der neue Zoowärter?");
            foreach (string zoo in Zoos)
            {
                Console.WriteLine(zoo);
            }
            string zooname = Console.ReadLine();

            //Gehege abfragen
            string getenclosurenrQuery = @"SELECT EnclosureNr, Area
                    FROM enclosure;";
            MySqlCommand getenclosurenrcommand = new MySqlCommand(getenclosurenrQuery, connection);
            Dictionary<int, string> enclosures = new Dictionary<int, string>();

            using (MySqlDataReader reader = getenclosurenrcommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    enclosures.Add(reader.GetInt32("EnclosureNr"), reader.GetString("Area"));
                }
            }

            Console.WriteLine("\nIn welchem Gehege arbeitet der neue Zoowärter? Bitte gib die Gehegenummer an!");
            foreach (KeyValuePair<int, string> habitat in enclosures)
            {
                Console.WriteLine($"{habitat.Key,-4} | {habitat.Value}");
            }
            int enclosurenr = Convert.ToInt32(Console.ReadLine());
            string[] Fullname = keepername.Split(" ");

            string query = @"INSERT INTO zookeeper (Firstname, Lastname, Workplace)
                VALUES (@Firstname, @Lastname, @Workplace);
                ";

            MySqlCommand InsertZookeepercommand = new MySqlCommand(query, connection);
            InsertZookeepercommand.Parameters.AddWithValue("@Firstname", Fullname[0]);
            InsertZookeepercommand.Parameters.AddWithValue("@Lastname", Fullname[1]);
            InsertZookeepercommand.Parameters.AddWithValue("@Workplace", zooname);
            InsertZookeepercommand.ExecuteNonQuery();

            string getKeeperIDQuery = @"SELECT KeeperID
                FROM zookeeper
                WHERE Firstname = @Firstname AND Lastname = @Lastname;";

            MySqlCommand getKeeperIDcommand = new MySqlCommand(getKeeperIDQuery, connection);
            getKeeperIDcommand.Parameters.AddWithValue("@Firstname", Fullname[0]);
            getKeeperIDcommand.Parameters.AddWithValue("@Lastname", Fullname[1]);
            int tempID = 0;

            using (MySqlDataReader reader = getKeeperIDcommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    tempID = reader.GetInt32("KeeperID");
                }
            }

            string insertcarelistQuery = @"INSERT INTO carelist (KeeperID, EnclosureNr)
                VALUES (@KeeperID, @EnclosureNr);";
            MySqlCommand insertcarelistcommand = new MySqlCommand(insertcarelistQuery, connection);
            insertcarelistcommand.Parameters.AddWithValue("@KeeperID", tempID);
            insertcarelistcommand.Parameters.AddWithValue("@EnclosureNr", enclosurenr);
            insertcarelistcommand.ExecuteNonQuery();

            Console.WriteLine("\nEin neuer Zoowärter wurde angestellt!");
        } */

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