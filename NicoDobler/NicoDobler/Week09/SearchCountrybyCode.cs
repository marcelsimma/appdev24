
// get MySQL Package: dotnet add package MySql.Data --version 9.1.0

using System;
using MySql.Data.MySqlClient;


namespace NicoDobler.Week09
{

    public class SearchCountrybyCode
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Mald4122!;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"USE mondial;
SELECT country.code , country.population, province.name, province.capital
FROM country
INNER JOIN province ON country.code = province.country
AND country.code = @code

";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    Console.WriteLine("Länderkürzel: ");
                    string input = Console.ReadLine();
                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", input);

                    Dictionary<string, string> provinces = new Dictionary<string, string>();

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        Console.Write(reader.GetString("code"));
                        Console.Write(" ");
                        Console.WriteLine(reader.GetInt32("population"));

                        do
                        {
                            provinces.Add(reader.GetString("name"), reader.GetString("capital"));
                        } while (reader.Read());

                        foreach (KeyValuePair<string, string> p in provinces)
                        {

                            Console.Write(" ");
                            Console.Write(p.Key);
                            Console.Write(" ");
                            Console.WriteLine(p.Value);
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
