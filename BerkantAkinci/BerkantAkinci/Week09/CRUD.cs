using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.CRUD;
using Org.BouncyCastle.Asn1;

namespace BerkantAkinci.Week09
{
    public class CRUD
    {
        static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=mondial
            ";

        List<string> entry = new List<string>();

        public static void Start()
        {
            All();
            CreateAndRead("A", "German");
            CreateAndRead("NA", "Creole");
            Insert();
            All();
            Update("Uzbek", "Uzbekler");
            Update("Turkish", "Turkce");
            Delete();
            All();
        }

        public static void All()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT *
                                    FROM language";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.Write(reader.GetString("country"));
                            System.Console.Write(", ");
                            Console.Write(reader.GetString("name"));
                            System.Console.Write(", ");
                            Console.WriteLine(reader.GetFloat("percentage"));
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);

                }
            }
        }

        public static List<string> CreateAndRead(string country, string name)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            List<string> entry = new List<string>();

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT * FROM language WHERE country = @country AND name = @name;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@country", country);
                    command.Parameters.AddWithValue("@name", name);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entry.Add(reader.GetString("country"));
                            entry.Add(reader.GetString("name"));
                            entry.Add(Convert.ToString(reader.GetFloat("percentage")));
                            System.Console.WriteLine(string.Join(", ", entry));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
            return entry;
        }

        public static void Insert()
        {
             // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO language (country, name, percentage)
                                        Values ('TUL', 'BEKS', '100');";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

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


        public static void Update(string set, string where)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"UPDATE language 
                                    SET name = @set
                                    WHERE name = @where";


                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@set", set);
                    command.Parameters.AddWithValue("@where", where);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        /*   while (reader.Read())
                          {

                          } */
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }


        public static void Delete()
        {
               // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"DELETE FROM language
                                    WHERE country = 'TUL' AND name = 'BEKS';";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

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
    }
}
