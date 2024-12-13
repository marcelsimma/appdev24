using System;
using MySql.Data.MySqlClient;
using CheyenneHarbarth.Zoo.Zoostructure.Animals;
using CheyenneHarbarth.Zoo.Zoostructure.Foods;
using Org.BouncyCastle.Tls;
using CheyenneHarbarth.Zoo.Zoostructure.Worker;

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
                        CreateZookeeper("Riccardo Ceccon", connection);
                    }
                    catch (MySqlException ex)
                    {
                        Console.Write(ex.Message);
                    }
                }
                break;
            }
        }
        internal static void CreateZoo(string zooname, int foundingyear, MySqlConnection connection)
        {
            Zoo MyZoo = new Zoo(zooname, foundingyear);

            string query = @"INSERT INTO zoo
                VALUES (@Zooname, @FoundingYear);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Zooname", zooname);
            command.Parameters.AddWithValue("@FoundingYear", foundingyear);

            command.ExecuteNonQuery();

            Console.WriteLine("\nDer Zoo wurde erstellt!");
        }
        internal static void CreateEnclosure(string enclosurename, MySqlConnection connection)
        {
            string queryQuestion = @"SELECT Zooname
                FROM zoo;";

            MySqlCommand command = new MySqlCommand(queryQuestion, connection);
            List<string> Zoos = new List<string>();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zoos.Add(reader.GetString("Zooname"));
                }
            }

            Console.WriteLine("\nZu welchem Zoo gehört das neue Gehege?");

            foreach (string zoo in Zoos)
            {
                Console.WriteLine(zoo);
            }

            string zooname = Console.ReadLine();

            Enclosure enclosure = new Enclosure(enclosurename);

            string query = @"INSERT INTO enclosure(Area, Zooname)
                VALUES (@Area, @Zooname);";

            MySqlCommand commandEnclosure = new MySqlCommand(query, connection);
            commandEnclosure.Parameters.AddWithValue("@Area", enclosurename);
            commandEnclosure.Parameters.AddWithValue("@Zooname", zooname);

            commandEnclosure.ExecuteNonQuery();

            Console.WriteLine("\nDas Gehege wurde erstellt!");
        }
        internal static void CreateFood(string foodname, string measurement, double pricepermeas, MySqlConnection connection)
        {
            Food food = new Food(foodname, measurement, pricepermeas);

            string query = @"INSERT INTO food (Foodname, Price, Measurement)
                VALUES (@Foodname, @Price, @Measurement);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Foodname", foodname);
            command.Parameters.AddWithValue("@Price", pricepermeas);
            command.Parameters.AddWithValue("@Measurement", measurement);

            command.ExecuteNonQuery();

            Console.WriteLine("\nDas Futter wurde erstellt!");
        }

        internal static void CreateAnimal(string animalname, string animalrace, Food food, float amount, MySqlConnection connection)
        {
            string queryQuestion = @"SELECT EnclosureNr, Area
                FROM enclosure;";

            MySqlCommand command = new MySqlCommand(queryQuestion, connection);
            Dictionary<int, Enclosure> enclosures = new Dictionary<int, Enclosure>();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    enclosures.Add(reader.GetInt32("EnclosureNr"), new Enclosure(reader.GetString("Area")));
                }
            }

            Console.WriteLine("\nIn welchem Gehege lebt das Tier? Bitte gib die Gehegenummer an!");

            foreach (KeyValuePair<int, Enclosure> habitat in enclosures)
            {
                Console.WriteLine($"{habitat.Key,-4} | {habitat.Value}");
            }
            int enclosurenr = Convert.ToInt32(Console.ReadLine());

            Animal animal = new Animal(animalname, animalrace, food, amount);

            string query = @"INSERT INTO animal
                VALUES (@Animalname, @Animalrace, @Habitat);
                
                INSERT INTO foodlist
                VALUES (@Animalname, @Food, @Amount)";

            MySqlCommand commandAnimal = new MySqlCommand(query, connection);
            commandAnimal.Parameters.AddWithValue("@Animalname", animalname);
            commandAnimal.Parameters.AddWithValue("@Animalrace", animalrace);
            commandAnimal.Parameters.AddWithValue("@Habitat", enclosurenr);
            commandAnimal.Parameters.AddWithValue("@Food", food._Foodname);
            commandAnimal.Parameters.AddWithValue("@Amount", amount);

            commandAnimal.ExecuteNonQuery();

            Console.WriteLine("Ein neues Tier ist im Zoo eingezogen!");
        }
        internal static void CreateZookeeper(string keepername, MySqlConnection connection)
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
Jungle.AddAnimal(animal6);

MyZoo.PrintZoo();

MyZoo.CalculateFoodConsumption();
MyZoo.CalculateFoodBill(MyZoo.FoodConsumption); */