// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;


namespace OliverBedogg.Week09
{

    public class CRUDsample
    {
        // Verbindungsinformation
        static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=root;
            database=Mondial
            ";

        public static void Start()
        {
            List<string> entry = read("AMSA", "Tongan");
            Console.WriteLine(string.Join("| ", entry));
            // read("AMSA", "Samoan");
            // read("AMSA", "English");
        }

        public static List<string> read(string code, string name)
        {
            List<string> entry = new List<string>();

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT * FROM language WHERE country = @code AND name = @name;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@name", name);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entry.Add(reader.GetString("country"));
                            entry.Add(reader.GetString("name"));
                            entry.Add(Convert.ToString(reader.GetFloat("percentage")));

                            // Alternative: new Language(country, name, percentage)

                            Console.WriteLine(string.Join(", ", entry));
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
    }
}