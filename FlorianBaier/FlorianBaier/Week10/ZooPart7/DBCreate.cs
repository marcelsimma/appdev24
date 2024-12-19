using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;

namespace FlorianBaier.Week10.ZooPart7
{
    public class DBCreate
    {
        public static void Start()
        {
            string connectionString = "";
            using (StreamReader str = new StreamReader("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt"))
            {
                connectionString = str.ReadToEnd();
            }

            while (true)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        CreateZoo("Tiergarten Schoenbrunn", 1970, connection);
                        CreateEnclosure("Elefantengehege", connection);
                        CreateEnclosure("Reptilienhaus", connection);
                        CreateEnclosure("Elefantenpark", connection);

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
            string query = @"INSERT INTO zoo (Name, FoundingYear)
                             VALUES (@Name, @FoundingYear);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", zooname);
            command.Parameters.AddWithValue("@FoundingYear", foundingyear);

            command.ExecuteNonQuery();

            Console.WriteLine("\nThe zoo was created!");
        }

        internal static void CreateEnclosure(string enclosurename, MySqlConnection connection)
        {
            string queryQuestion = @"SELECT Name FROM zoo;";

            MySqlCommand command = new MySqlCommand(queryQuestion, connection);
            List<string> Zoos = new List<string>();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zoos.Add(reader.GetString("Name"));
                }
            }

            Console.WriteLine("\nWhich zoo does the new enclosure belong to?");
            foreach (string zoo in Zoos)
            {
                Console.WriteLine($"Available zoos: {zoo}");
            }

            string zooname = Console.ReadLine();

            string query = @"INSERT INTO enclosure (Name)
                             VALUES (@Name);";

            MySqlCommand commandEnclosure = new MySqlCommand(query, connection);
            commandEnclosure.Parameters.AddWithValue("@Name", enclosurename);
            commandEnclosure.ExecuteNonQuery();

            Console.WriteLine("\nThe enclosure was created!");
        }

        internal static void CreateFood(string foodname, string measurement, double pricepermeas, MySqlConnection connection)
        {
            string query = @"INSERT INTO food (Name, UnitPrice, Unit)
                             VALUES (@Name, @UnitPrice, @Unit);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", foodname);
            command.Parameters.AddWithValue("@UnitPrice", pricepermeas);
            command.Parameters.AddWithValue("@Unit", measurement);

            command.ExecuteNonQuery();

            Console.WriteLine("\nThe food was created!");
        }

        internal static void CreateAnimal(string animalname, string animalrace, Food food, double amount, MySqlConnection connection)
        {
            string queryQuestion = @"SELECT EnclosureID, Name FROM enclosure;";

            MySqlCommand command = new MySqlCommand(queryQuestion, connection);
            Dictionary<int, string> enclosures = new Dictionary<int, string>();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    enclosures.Add(reader.GetInt32("EnclosureID"), reader.GetString("Name"));
                }
            }

            Console.WriteLine("\nWhat enclosure does the animal live in? Please enter the enclosure number!");
            foreach (KeyValuePair<int, string> habitat in enclosures)
            {
                Console.WriteLine($"{habitat.Key,-4} | {habitat.Value}");
            }
            int enclosurenr = Convert.ToInt32(Console.ReadLine());

            string query = @"INSERT INTO animal (Name, Species)
                             VALUES (@Name, @Species);";

            MySqlCommand commandAnimal = new MySqlCommand(query, connection);
            commandAnimal.Parameters.AddWithValue("@Name", animalname);
            commandAnimal.Parameters.AddWithValue("@Species", animalrace);
            commandAnimal.ExecuteNonQuery();

            // Get AnimalID
            string getAnimalIDQuery = @"SELECT AnimalID FROM animal WHERE Name = @Name;";
            MySqlCommand getAnimalIDCommand = new MySqlCommand(getAnimalIDQuery, connection);
            getAnimalIDCommand.Parameters.AddWithValue("@Name", animalname);
            int animalID = Convert.ToInt32(getAnimalIDCommand.ExecuteScalar());

            string insertFoodQuery = @"INSERT INTO animal_food (AnimalID, EAN, Amount, Unit)
                                       VALUES (@AnimalID, @EAN, @Amount, @Unit);";

            MySqlCommand insertFoodCommand = new MySqlCommand(insertFoodQuery, connection);
            insertFoodCommand.Parameters.AddWithValue("@AnimalID", animalID);
            insertFoodCommand.Parameters.AddWithValue("@EAN", food.EAN);
            insertFoodCommand.Parameters.AddWithValue("@Amount", amount);
            insertFoodCommand.Parameters.AddWithValue("@Unit", food.Unit);
            insertFoodCommand.ExecuteNonQuery();

            Console.WriteLine("A new animal has arrived at the zoo!");
        }

        internal static void CreateZookeeper(string keepername, MySqlConnection connection)
        {
            string getzoonameQuery = @"SELECT Name FROM zoo;";
            MySqlCommand getzoonamecommand = new MySqlCommand(getzoonameQuery, connection);
            List<string> Zoos = new List<string>();

            using (MySqlDataReader reader = getzoonamecommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zoos.Add(reader.GetString("Name"));
                }
            }

            Console.WriteLine("\nWhich zoo does the new zookeeper work at?");
            foreach (string zoo in Zoos)
            {
                Console.WriteLine(zoo);
            }
            string zooname = Console.ReadLine();

            string getenclosurenrQuery = @"SELECT EnclosureID, Name FROM enclosure;";
            MySqlCommand getenclosurenrcommand = new MySqlCommand(getenclosurenrQuery, connection);
            Dictionary<int, string> enclosures = new Dictionary<int, string>();

            using (MySqlDataReader reader = getenclosurenrcommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    enclosures.Add(reader.GetInt32("EnclosureID"), reader.GetString("Name"));
                }
            }

            Console.WriteLine("\nWhich enclosure does the new zookeeper work in? Please enter the enclosure number!");
            foreach (KeyValuePair<int, string> habitat in enclosures)
            {
                Console.WriteLine($"{habitat.Key,-4} | {habitat.Value}");
            }
            int enclosurenr = Convert.ToInt32(Console.ReadLine());

            string[] Fullname = keepername.Split(" ");
            string query = @"INSERT INTO zookeeper (Name)
                             VALUES (@Name);";

            MySqlCommand InsertZookeepercommand = new MySqlCommand(query, connection);
            InsertZookeepercommand.Parameters.AddWithValue("@Name", keepername);
            InsertZookeepercommand.ExecuteNonQuery();

            string getKeeperIDQuery = @"SELECT ZookeeperID FROM zookeeper WHERE Name = @Name;";
            MySqlCommand getKeeperIDcommand = new MySqlCommand(getKeeperIDQuery, connection);
            getKeeperIDcommand.Parameters.AddWithValue("@Name", keepername);
            int tempID = Convert.ToInt32(getKeeperIDcommand.ExecuteScalar());

            string insertcarelistQuery = @"INSERT INTO enclosure_zookeeper (ZookeeperID, EnclosureID)
                                          VALUES (@ZookeeperID, @EnclosureID);";

            MySqlCommand insertcarelistcommand = new MySqlCommand(insertcarelistQuery, connection);
            insertcarelistcommand.Parameters.AddWithValue("@ZookeeperID", tempID);
            insertcarelistcommand.Parameters.AddWithValue("@EnclosureID", enclosurenr);
            insertcarelistcommand.ExecuteNonQuery();

            Console.WriteLine("\nA new zookeeper has been hired!");
        }
    }
}
