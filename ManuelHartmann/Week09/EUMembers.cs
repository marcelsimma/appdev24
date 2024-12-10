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
                        // Überschrift
                        Console.WriteLine("{0,-15} | {1,-5} | {2,-25} | {3,10}",
                            "Continent", "Code", "Name", "Population");
                        // Trenner
                        Console.WriteLine(new string('-', 64));

                        while (reader.Read())
                        {
                            Console.WriteLine("{0,-15} | {1,-5} | {2,-25} | {3,10}",
                                reader.GetString("Continent"),
                                reader.GetString("Code"),
                                reader.GetString("Name"),
                                reader.GetInt64("Population"));
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