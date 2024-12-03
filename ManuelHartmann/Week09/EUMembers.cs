// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'


using System;
using MySql.Data.MySqlClient;


namespace ManuelHartmann.Week09.EUMembers
{
    public class EUMembers
    {

        static void Main(string[] args)
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=root;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query =
                    @"SELECT encompasses.Continent, country.Code, country.Name, country.Population
                    FROM country, encompasses
                    WHERE country.Code = encompasses.Country AND encompasses.Continent = 'Europe'
                    ORDER BY country.Name;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    //// Variablen austauschen
                    //command.Parameters.AddWithValue("@platzhalter", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.Write(reader.GetString("Continent"));
                            Console.Write(" | " + reader.GetString("Code"));
                            Console.Write(" | " + reader.GetString("Name"));
                            Console.Write(" | " + reader.GetInt64("Population") + "\n");
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