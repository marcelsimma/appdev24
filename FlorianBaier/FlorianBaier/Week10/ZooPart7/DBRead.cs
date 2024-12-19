using System;
using MySql.Data.MySqlClient;

namespace FlorianBaier.Week10.ZooPart7
{
    public class DBRead
    {
        public static void Start()
        {
            /*string connectionString = "C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connection to database successful.");

                ReadZoos(connection);
                ReadEnclosures(connection);
                ReadAnimals(connection);
                ReadFood(connection);
                ReadZookeepers(connection);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Connection to database closed.");
                }
            }*/
            string connectionString = ReadConnectionStringFromFile("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt");

            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Error: Connection string is empty or could not be read.");
                return;
            }

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection to database successful.");

                ReadZoos(connection);
                ReadEnclosures(connection);
                ReadAnimals(connection);
                ReadFood(connection);
                ReadZookeepers(connection);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Connection to database closed.");
                }
            }
        }

        private static string ReadConnectionStringFromFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath).Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading connection string from file: " + ex.Message);
                return string.Empty;
            }
        }
        public static void ReadZoos(MySqlConnection connection)
        {
            string query = @"
                SELECT zoo.Name AS ZooName, enclosure.Name AS EnclosureName
                FROM zoo
                LEFT JOIN enclosure ON zoo.ZooID = enclosure.ZooID
                ORDER BY zoo.Name, enclosure.Name;
            ";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("\nZoos and their Enclosures:");
                while (reader.Read())
                {
                    string zooName = reader.GetString("ZooName");
                    string enclosureName = reader.IsDBNull(reader.GetOrdinal("EnclosureName")) ? "No enclosure" : reader.GetString("EnclosureName");

                    Console.WriteLine($"{zooName} - {enclosureName}");
                }
            }
        }

        public static void ReadEnclosures(MySqlConnection connection)
        {
            string query = @"
                SELECT enclosure.Name AS EnclosureName, zoo.Name AS ZooName
                FROM enclosure
                LEFT JOIN zoo ON enclosure.ZooID = zoo.ZooID
                ORDER BY enclosure.Name;
            ";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("\nEnclosures:");
                while (reader.Read())
                {
                    string enclosureName = reader.GetString("EnclosureName");
                    string zooName = reader.IsDBNull(reader.GetOrdinal("ZooName")) ? "No zoo" : reader.GetString("ZooName");

                    Console.WriteLine($"{enclosureName} - {zooName}");
                }
            }
        }
        public static void ReadAnimals(MySqlConnection connection)
        {
            string query = @"
                SELECT animal.Name AS AnimalName, animal.Species AS AnimalSpecies, enclosure.Name AS EnclosureName
                FROM animal
                LEFT JOIN animal_food ON animal.AnimalID = animal_food.AnimalID
                LEFT JOIN enclosure ON animal.EnclosureID = enclosure.EnclosureID
                ORDER BY animal.Name;
            ";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("\nAnimals and their Enclosures:");
                while (reader.Read())
                {
                    string animalName = reader.GetString("AnimalName");
                    string animalSpecies = reader.GetString("AnimalSpecies");
                    string enclosureName = reader.IsDBNull(reader.GetOrdinal("EnclosureName")) ? "No enclosure" : reader.GetString("EnclosureName");

                    Console.WriteLine($"{animalName} ({animalSpecies}) - Enclosure: {enclosureName}");
                }
            }
        }

        public static void ReadFood(MySqlConnection connection)
        {
            string query = @"SELECT Name, UnitPrice, Unit FROM food ORDER BY Name;";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("\nFood Items:");
                while (reader.Read())
                {
                    string foodName = reader.GetString("Name");
                    double unitPrice = reader.GetDouble("UnitPrice");
                    string unit = reader.GetString("Unit");

                    Console.WriteLine($"{foodName} - Price: {unitPrice} {unit}");
                }
            }
        }

        public static void ReadZookeepers(MySqlConnection connection)
        {
            string query = @"
                SELECT zookeeper.Name AS ZookeeperName, enclosure.Name AS EnclosureName
                FROM zookeeper
                LEFT JOIN enclosure_zookeeper ON zookeeper.ZookeeperID = enclosure_zookeeper.ZookeeperID
                LEFT JOIN enclosure ON enclosure_zookeeper.EnclosureID = enclosure.EnclosureID
                ORDER BY zookeeper.Name;
            ";

            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("\nZookeepers and their Enclosures:");
                while (reader.Read())
                {
                    string zookeeperName = reader.GetString("ZookeeperName");
                    string enclosureName = reader.IsDBNull(reader.GetOrdinal("EnclosureName")) ? "No enclosure" : reader.GetString("EnclosureName");

                    Console.WriteLine($"{zookeeperName} - Enclosure: {enclosureName}");
                }
            }
        }
    }
}