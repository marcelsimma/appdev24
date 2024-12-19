using System;
using MySqlX.XDevAPI.CRUD;
using MySql.Data.MySqlClient;
using BerkantAkinci.Week06.Zoo;
using System.Runtime.InteropServices.Marshalling;
using System.Data;

namespace BerkantAkinci.Week10
{
    public class ReadInitialise
    {
        public static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=zoo
            ";

        public static void ReadZoo()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT * FROM zoo";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Console.Write(reader.GetString("zooName"));
                            System.Console.Write(", ");
                            System.Console.WriteLine(reader.GetInt32("foundingYear"));
                        }
                        System.Console.WriteLine();
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void ReadEnclosure()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT * FROM enclosure;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Console.Write(reader.GetString("enclosureName"));
                            System.Console.Write(", ");
                            System.Console.WriteLine(reader.GetString("zooName"));
                        }
                        System.Console.WriteLine();
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void ReadAnimal()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT * FROM animal;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Console.Write(reader.GetString("animalName"));
                            System.Console.Write(", ");
                            System.Console.WriteLine(reader.GetString("species"));
                        }
                        System.Console.WriteLine();
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void ReadWorker()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT *
                                    FROM zooworker;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Console.Write(reader.GetInt32("workerID"));
                            System.Console.Write(", ");
                            System.Console.Write(reader.GetString("workerName"));
                            System.Console.Write(", ");
                            System.Console.WriteLine(reader.GetString("zooName"));

                        }
                        System.Console.WriteLine();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public static void ReadAnimalFood()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT * FROM animalfood;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Console.Write(reader.GetString("foodName"));
                            System.Console.Write(", ");
                            System.Console.Write(reader.GetDouble("unitPrice"));
                            System.Console.Write(" ");
                            System.Console.WriteLine(reader.GetString("unit"));

                        }
                        System.Console.WriteLine();
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
