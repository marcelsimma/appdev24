
    // get MySQL Package: dotnet add package MySql.Data --version 9.1.0

using System;
using System.Diagnostics.Metrics;
using MySql.Data.MySqlClient;


namespace NicoDobler.Week09
{

    public class EUMember
    {

        public static void Start()
        {
            // Verbindungsinformatio/j=i
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
                    string query = @"SELECT  country.code, Organization , organization.name AS continent, country.name, country.population
FROM ismember,country, Organization
WHERE isMember.organization = Organization.abbreviation
AND Country.code = ismember.country
AND Organization = 'EU' 
AND Type = 'member'
Order by name ASC;


";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        int counter = 0;

                        while (reader.Read())
                        { 
                            
                 counter++;  
Console.WriteLine("{0,3}. {1,-10} {2,-20} {3,10}",  
                  counter,                    
                  reader.GetString("code"),   
                  reader.GetString("name"),   
                  reader.GetInt32("population")); 

                          
                          


                         
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
