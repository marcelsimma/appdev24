using System;
using MySqlX.XDevAPI.CRUD;
using MySql.Data.MySqlClient;
using BerkantAkinci.Week06.Zoo;
using System.Runtime.InteropServices.Marshalling;
using System.Data;

namespace BerkantAkinci.Week10
{
    public class CreateInitialise
    {
        public static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=zoo
            ";

        public static void CreateZoo(string zooName, int foundingYear)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO zoo (ZooName, FoundingYear)
                                    Values (@zooName, @foundingYear);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@zooName", zooName);
                    command.Parameters.AddWithValue("@foundingYear", foundingYear);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void CreateEnclosure(string enclosureName, string zooName)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO enclosure (EnclosureName, ZooName)
                                    Values (@enclosureName, @zooName);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@enclosureName", enclosureName);
                    command.Parameters.AddWithValue("@zooName", zooName);
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void CreateAnimal(string animalName, string species, int enclosureID)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO animal (AnimalName, Species, EnclosureID)
                                    Values (@animalName, @species, @enclosureID);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@animalName", animalName);
                    command.Parameters.AddWithValue("@species", species);
                    command.Parameters.AddWithValue("@enclosureID", enclosureID);
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void CreateWorker(string workerID, string workerName, string zooName)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO zooworker (WorkerID, WorkerName, ZooName)
                                    Values (@workerID, @workerName, @zooName);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@workerID", workerID);
                    command.Parameters.AddWithValue("@workerName", workerName);
                    command.Parameters.AddWithValue("@zooName", zooName);
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void CreateAnimalFood(string foodName, string unit, double unitPrice)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO animalfood (FoodName, Unit, UnitPrice)
                                    Values (@foodName, @unit, @unitPrice);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@foodName", foodName);
                    command.Parameters.AddWithValue("@unit", unit);
                    command.Parameters.AddWithValue("@unitPrice", unitPrice);
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void CreateAllFood(int animalID, int animalFoodID, double amount)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO allfood (AnimalID, AnimalFoodID, Amount)
                                    Values (@animalID, @animalFoodID, @amount);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@animalID", animalID);
                    command.Parameters.AddWithValue("@animalFoodID", animalFoodID);
                    command.Parameters.AddWithValue("@amount", amount);
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void CreateCarelist(int workerID, int enclsoureID)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO carelist (WorkerID, EnclosureID)
                                    Values (@workerID, @enclosureID)";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@workerID", workerID);
                    command.Parameters.AddWithValue("@enclosureID", enclsoureID);
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
