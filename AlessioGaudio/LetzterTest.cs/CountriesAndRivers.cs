using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AlessioGaudio.Week09
{
    public class CountriesAndRivers
    {
        private static string code = "D";

        public static void Start()
        {
            string databaseConnectionString = @"
                server=127.0.0.1;
                uid=root;
                pwd=RamseS1234!;
                database=mondial;
            ";

            List<(string Name, double Length)> rivers = new List<(string Name, double Length)>();

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT DISTINCT river.Name AS river_name, river.Length AS river_length
                        FROM river
                        JOIN geo_river ON river.Name = geo_river.River
                        JOIN country ON country.Code = geo_river.Country 
                        WHERE country.Code = 'D'
                        ORDER BY river.Length DESC;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", code);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString("river_name");
                            double length = reader.IsDBNull(reader.GetOrdinal("river_length")) ? 0 : reader.GetDouble("river_length");
                            rivers.Add((name, length));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Fehler: " + ex.Message);
                }
            }

            PrintRivers(rivers);
        }

        private static void PrintRivers(List<(string Name, double Length)> rivers)
        {
            Console.WriteLine($"Flüsse in \"{code}\"");
            Console.WriteLine(new string('-', 40));

            double totalLength = 0;

            foreach (var river in rivers)
            {
                Console.WriteLine($"{river.Name,-25} {river.Length,10:F2} km");
                totalLength += river.Length;
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"Gesamtlänge: {totalLength,25:F2} km");
        }
    }
}
