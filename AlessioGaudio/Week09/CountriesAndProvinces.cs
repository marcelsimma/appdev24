using System;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace AlessioGaudio.Week09
{
    public class CountriesAndProvinces
    {
        public static void Start()
        {
            Console.Write("Bitte Länderkürzel eingeben: ");
            string countryCode = Console.ReadLine()?.Trim().ToUpper();

            string connectionString = @"
                server=127.0.0.1;
                uid=root;
                pwd=RamseS1234!;
                database=mondial;
            ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL-Abfrage: Land, Provinzen und deren Hauptstädte
                    string query = @"
                        SELECT 
                            c.code AS Laenderkuerzel,
                            c.name AS Land,
                            c.population AS Einwohnerzahl,
                            p.name AS Provinz,
                            p.capital AS Provinzhauptstadt,
                            p.population AS ProvinzEinwohnerzahl
                        FROM country c
                        LEFT JOIN province p ON c.code = p.country
                        WHERE c.code = @code;
                    ";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", countryCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool countryFound = false;
                        Console.WriteLine("\nErgebnisse:\n");

                        while (reader.Read())
                        {
                            if (!countryFound)
                            {
                                string countryName = reader.GetString("Land");
                                int population = reader.IsDBNull(reader.GetOrdinal("Einwohnerzahl"))
                                    ? 0
                                    : reader.GetInt32("Einwohnerzahl");

                                Console.WriteLine($"Land: {countryName}");
                                Console.WriteLine($"Einwohnerzahl: {population}\n");
                                Console.WriteLine("Provinzen und Hauptstädte:");
                                countryFound = true;
                            }

                            string province = reader.IsDBNull(reader.GetOrdinal("Provinz"))
                                ? "Keine Provinz"
                                : reader.GetString("Provinz");

                            string capital = reader.IsDBNull(reader.GetOrdinal("Provinzhauptstadt"))
                                ? "Keine Hauptstadt"
                                : reader.GetString("Provinzhauptstadt");

                            Console.WriteLine($"Provinz: {province}, Hauptstadt: {capital}");
                        }

                        if (!countryFound)
                        {
                            Console.WriteLine("Kein Land mit diesem Länderkürzel gefunden.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Datenbankfehler: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein Fehler ist aufgetreten: " + ex.Message);
                }
            }
        }
    }
}
