using System;
using MySql.Data.MySqlClient;

namespace BerkantAkinci.Week09.CountriesAndMountains
{
    public class Country
    {

        public string Code;
        public List<string> mountains;

        public Country(string code)
        {
            Code = code;
            mountains = new List<string>();
            GetMountainsFromDB(code);
        }

        public void GetMountainsFromDB(string code)
        {

            using (MySqlConnection connection = new MySqlConnection(CountriesAndMountains.DatabaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"
                    SELECT DISTINCT geo_mountain.Mountain 
                    FROM geo_mountain
                    WHERE geo_mountain.Country = @code;
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
                            mountains.Add(reader.GetString("Mountain"));
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);

                }
            }

        }

        public void PrintMountains() {
            foreach(string mountain in mountains) {
                System.Console.WriteLine(mountain);
            }
        }
    }
}