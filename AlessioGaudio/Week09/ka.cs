// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;


namespace MarcelSimma.Week09
{

    public class MysqlConnectExample
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            
                    USE mondial;
SELECT country.code , country.population, province.name, province.capital
FROM country, province
WHERE province.country = country.code
AND country.code = @code";
            

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT * FROM country WHERE code like @code;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.Write(reader.GetString("name"));
                             Console.Write(reader.GetString("name"));
                              Console.Write(reader.GetString("name"));
                               Console.Write(reader.GetString("name"));
                             Console.Write(reader.GetString("name"));
                              Console.Write(reader.GetString("name"));
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