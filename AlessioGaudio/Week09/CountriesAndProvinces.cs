using System;
using MySql.Data.MySqlClient;

namespace SearchCountryByCodeApp
{
    public class SearchCountryByCode
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

                   
                    string query = @"
                    USE mondial;
SELECT country.code , country.population, province.name, province.capital
FROM country, province
WHERE province.country = country.code
AND country.code = @code";
                    

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
                                    ? 0 : reader.GetInt32("Einwohnerzahl");
                                
                                Console.WriteLine($"Land: {countryName}");
                                Console.WriteLine($"Einwohnerzahl: {population}\n");
                                Console.WriteLine("Provinzen und Hauptstädte:");
                                countryFound = true;
                            }

                            string province = reader.IsDBNull(reader.GetOrdinal("Provinz")) 
                                ? "Keine Provinz" 
                                : reader.GetString("Provinz");

                            string capital = reader.IsDBNull(reader.GetOrdinal("Hauptstadt")) 
                                ? "Keine Hauptstadt" 
                                : reader.GetString("Hauptstadt");

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
