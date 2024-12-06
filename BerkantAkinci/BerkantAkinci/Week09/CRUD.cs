using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;

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


        public static void Start()
        {
            CreateAndRead("AMSA", "Samaon");


        }

        public static void CreateAndRead(string country, string name)
        {
            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT * FROM language WHERE country like @code AND @name;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@code", country);
                    command.Parameters.AddWithValue("@name", name);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString("country"));
                            Console.WriteLine(reader.GetString("name"));
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


        public static void Update()
        {


        }

        public static void Delete()
        {

        }
    }
}