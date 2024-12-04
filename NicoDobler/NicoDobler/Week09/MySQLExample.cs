
    // get MySQL Package: dotnet add package MySql.Data --version 9.1.0

using System;
using MySql.Data.MySqlClient;


namespace NicoDobler.Week09
{

    public class MySQLExample
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Mald4122!;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT Organization , organization.name AS continent, country.name,country.population
FROM ismember,country, Organization
WHERE isMember.organization = Organization.abbreviation
AND Country.code = ismember.country
AND Organization = 'EU' 
AND Type = 'member'
Order by Country.population DESC;
";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            Console.Write(reader.GetString("organization"));
                            Console.Write(" ");
                            Console.Write(reader.GetString("name"));
                            Console.Write(" ");
                            Console.Write(reader.GetString("continent"));
                            Console.Write(" ");
                            Console.WriteLine(reader.GetInt32("population"));

                          


                         
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
