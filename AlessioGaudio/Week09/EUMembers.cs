using System;
using MySql.Data.MySqlClient;

namespace AlessioGaudio.Week09
{
    public class MysqlConnectExample
    {
        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=RamseS1234!;
            database=mondial
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                   
                    string query = @"
                        SELECT Organization, organization.name AS NameOfUnion, country.name, country.population
                        FROM ismember, country, Organization
                        WHERE isMember.organization = Organization.abbreviation
                        AND Country.code = ismember.country
                        AND Organization = 'EU'
                        AND Type = 'member'
                        ORDER BY Country.name;
                    ";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                       
                        Console.ForegroundColor = ConsoleColor.Cyan;  
                        Console.WriteLine($"{ "Nr.",5} { "Organisation",15} { "Union Name ",20} { "Country Name",5} { "Population",15}");
                        Console.WriteLine(new string('-', 75));

                        int c = 0;
                        while (reader.Read())
                        {
                            c++;

                            // Nummerierung und farbige Ausgabe
                            Console.ForegroundColor = ConsoleColor.Blue;  // Farbe für die Nummer
                            Console.Write($"{c,5}");

                            Console.ForegroundColor = ConsoleColor.White;  // Farbe für Organisation
                            Console.Write($"{reader.GetString("Organization"),10}");

                            Console.ForegroundColor = ConsoleColor.Blue;  // Farbe für Union Name
                            Console.Write($"{reader.GetString("NameOfUnion"),27}");

                            Console.ForegroundColor = ConsoleColor.White;  // Standardfarbe für Ländername
                            Console.Write($"{reader.GetString("name"),25}");

                            // Farbe für Population
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"{reader.GetInt32("population"),15}");

                            Console.ResetColor();  // Zurücksetzen der Farbe für die nächste Zeile
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
