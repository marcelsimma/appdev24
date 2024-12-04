using System;
using MySql.Data.MySqlClient;

namespace AlessioGaudio.Week09
{
    public class SearchCountry
    {
        public static void Start()
        {
           
            string databaseConnectionString = @"
                server=127.0.0.1;
                uid=root;
                pwd=RamseS1234!;
                database=mondial;
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                  
                    string query = @"
                        SELECT c.name AS 'Land', c.population AS 'Einwohnerzahl', 
                               p.name AS 'Provinz', p.capital AS 'Hauptstadt'
                        FROM country c
                        INNER JOIN province p ON c.code = p.country
                        WHERE c.code = @code;
                    ";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    Console.Write("Länderkürzel: ");
                    string input = Console.ReadLine()?.Trim().ToUpper();

                    command.Parameters.AddWithValue("@code", input);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool hasResults = false;

                       
                        Console.WriteLine($"\n{"Land",-20} {"Einwohnerzahl",-15} {"Provinz",-20} {"Hauptstadt",-20}");
                        Console.WriteLine(new string('-', 75));

                        while (reader.Read())
                        {
                            hasResults = true;
                            string land = reader.GetString("Land");
                            int einwohnerzahl = reader.GetInt32("Einwohnerzahl");
                            string provinz = reader.GetString("Provinz");
                            string hauptstadt = reader.IsDBNull(reader.GetOrdinal("Hauptstadt")) 
                                ? "Keine Hauptstadt" 
                                : reader.GetString("Hauptstadt");

                            Console.WriteLine($"{land,-20} {einwohnerzahl,-15:N0} {provinz,-20} {hauptstadt,-20}");
                        }

                        if (!hasResults)
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
