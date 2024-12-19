using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace BerkantAkinci.ATest
{
    public class Country
    {

        public string Code;
        public Dictionary<string, double> riversAndLength;

        public Country(string code)
        {
            Code = code;
            riversAndLength = new Dictionary<string, double>();
            GetRiversAndLengthFromDB(code);
        }

        public void GetRiversAndLengthFromDB(string code)
        {

            using (MySqlConnection connection = new MySqlConnection(CountriesAndRivers.DatabaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"
                    SELECT DISTINCT geo_river.Country, river.Name, river.Length
                    FROM geo_river
                    JOIN river ON geo_river.River = river.Name
                    WHERE geo_river.Country = @code
                    ORDER BY river.Length DESC;
                    ";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", code);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            riversAndLength.Add(reader.GetString("Name"), reader.GetDouble("Length"));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public void PrintRiversAndLength()
        {
            double sumLength = riversAndLength.Values.Sum();
            System.Console.WriteLine($"Flüsse in {Code}");
            System.Console.WriteLine("-----------------------------------------------");

            foreach (KeyValuePair<string, double> riverAndLength in riversAndLength)
            {
                System.Console.WriteLine($"{riverAndLength.Key,-30}{riverAndLength.Value,10:F2} km");
            }
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine($"{"Gesamtlänge:",-30} {sumLength,9:F2} km");
        }
    }
}