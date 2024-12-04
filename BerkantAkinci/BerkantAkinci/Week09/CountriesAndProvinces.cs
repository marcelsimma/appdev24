using System;
using MySql.Data.MySqlClient;

namespace BerkantAkinci.Week09
{
    public class CountriesAndProvinces
    {
        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    // Datenbank Abfrage erstellen
                    string query = @"SELECT DISTINCT country.Name, encompasses.Continent, country.Capital, country.Population, city.Province, city.Name AS city, city.Population AS cityPopulation
                                    FROM country
                                    JOIN encompasses ON country.Code = encompasses.Country
                                    JOIN city ON country.Code = city.Country
                                    WHERE country.Name = @code
                                    ORDER BY city.Province ASC";

                    string input;

                    do
                    {
                        bool found = false;
                        // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                        MySqlCommand command = new MySqlCommand(query, connection);
                        System.Console.WriteLine("Geben Sie ein Ländername ein:");
                        input = Console.ReadLine();
                        System.Console.WriteLine();
                        command.Parameters.AddWithValue("@code", input);

                        // Resultate lesen
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                if (count == 0 && reader.GetString("name") == input)
                                {
                                    Console.Write(@"{0}, ", reader.GetString("name"));
                                    Console.Write(@"{0}, ", reader.GetString("continent"));
                                    Console.Write(@"{0}, ", reader.GetString("capital"));
                                    Console.WriteLine(@"{0} ", reader.GetInt32("population"));
                                    found = true;
                                    count++;
                                }
                                if (input == reader.GetString("name"))
                                {
                                    System.Console.Write(@"- {0}, ", reader.GetString("province"));
                                    System.Console.Write(@"{0}, ", reader.GetString("city"));

                                    if (reader.IsDBNull(reader.GetOrdinal("cityPopulation")))
                                    {
                                        System.Console.WriteLine("- kein Eintrag -");
                                    }

                                    else
                                    {
                                        Console.WriteLine(@"{0}", reader.GetInt32("cityPopulation"));
                                    }
                                }

                            }
                        }
                        if (!found)
                        {
                            System.Console.WriteLine("Dies ist kein Land, Groß - und Kleinschreibung auch beachten und auf Englisch.");
                        }

                        System.Console.WriteLine();
                    } while (input != "fertig");
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
