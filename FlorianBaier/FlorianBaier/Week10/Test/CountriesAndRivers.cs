using System;
using MySql.Data.MySqlClient;

namespace FlorianBaier.Week10.Test
{
    public class InitialiseFile
    {
        public static void Start()
        {
            string connectionString = "";
            using (StreamReader str = new StreamReader("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt"))
            {
                connectionString = str.ReadToEnd();
            }

            Console.WriteLine("Bitte gib ein Länderkürzel ein:");
            string code = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(code))
            {
                Console.WriteLine("Ungültige Eingabe, das Länderkürzel darf nicht leer sein.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    
                    List<River> rivers = new List<River>();
                    int totalLength = 0;

                    string query = @"
                        SELECT DISTINCT country.Code, river.Name, river.Length
                        FROM country
                        JOIN geo_river ON country.Code = geo_river.Country
                        JOIN river ON geo_river.River = river.Name
                        WHERE country.Code = @countryCode
                        ORDER BY river.Length DESC";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@countryCode", code);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool found = false;
                        Console.WriteLine($"\nFlüsse in {code}:");
                        Console.WriteLine(new string('-', 25));
                        while (reader.Read())
                        {
                            found = true;
                            string riverName = reader.GetString("Name");
                            int riverLength = reader.GetInt32("Length");

                            River river = new River(riverName, riverLength);
                            rivers.Add(river);
                            totalLength += riverLength;
                        }

                        if (!found)
                        {
                            Console.WriteLine($"Keine Flüsse für das Länderkürzel '{code}' gefunden.");
                        }
                    }

                    if (rivers.Count == 0)
                    {
                        Console.WriteLine("Keine Flüsse gefunden.");
                    }
                    else
                    {
                        foreach (var river in rivers)
                        {
                             Console.WriteLine($"{river.Name,-15} {river.Length,5} km");
                        }
                        Console.WriteLine(new string('-', 25));
                        Console.WriteLine($"\nGesamtlänge:     {totalLength} km");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }
    }
}