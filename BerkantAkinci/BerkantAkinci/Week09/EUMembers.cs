using System;
using MySql.Data.MySqlClient;


namespace BerkantAkinci.Week09
{
    public class EUMembers
    {
        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"SELECT country.Name AS Country, country.Code, country.Population 
                                    FROM ismember
                                    JOIN country ON ismember.Country = country.Code
                                    WHERE ismember.Organization = 'EU' AND ismember.Type = 'member'
                                    ORDER BY country.Name ASC";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 1;

                        while (reader.Read())
                        {
                            Console.Write(@"{0,3}. {1,-20}", i, reader.GetString("country"));
                            Console.Write(@"{0,-10}", reader.GetString("code"));
                            Console.WriteLine(@"{0,10}", reader.GetInt32("population"));
                            i++;
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
