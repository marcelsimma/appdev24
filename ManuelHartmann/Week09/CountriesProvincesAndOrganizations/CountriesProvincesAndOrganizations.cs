// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace ManuelHartmann.Week09.CountriesProvincesAndOrganizations
{
    public class Program
    {
        static void Main(string[] args)
        {
            // BenutzerInput
            Console.WriteLine("Please give me a country.Code");
            string respond = Console.ReadLine();
            respond = respond.ToUpper();

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
                    /* 'country' ist in diesem Fall das Linke im 'left-Join', wobei immer eine Ebene weiter nach Oben
                       gejoint wird. Mit ON wird dann die zu erfuellende Join-Bedinung abgefragt.                         */
                    string query = @"SELECT * FROM 
                                    -- Beziehung country und ismember
                                    country INNER JOIN ismember ON country.code = ismember.country 
                                    -- Beziehung ismember und organization
                                    INNER JOIN organization ON ismember.Organization = organization.Abbreviation
                                    -- Beziehung country und encompasses
                                    INNER JOIN encompasses ON country.code = encompasses.Country
                                    -- Zusätzliche Filter
                                    WHERE country.Code = @platzhalter AND ismember.Organization = 'NATO' AND ismember.Organization = 'EU' AND encompasses.Continent = 'Europe'
                                    OR country.Code = @platzhalter AND ismember.Organization = 'NATO'
                                    OR country.Code = @platzhalter AND encompasses.Continent = 'Europe' AND ismember.Organization = 'EU'
                                    ORDER BY country.Code";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@platzhalter", respond);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.Clear();
                        // Ausgabe Header.
                        Console.WriteLine("{0,-8} | {1,-20} | {2,-15} | {3,-13} | {4,-10}",
                                             "Code", "Name", "Population", "Organization", "Continent"); // Überschrift
                        Console.WriteLine(new string('-', 80)); // Trenner

                        while (reader.Read())
                        {
                            // Welche ListenElemente sollen aus den Oben abgefragten Tabellen ausgegeben werden.
                            Console.WriteLine("{0,-8} | {1,-20} | {2,-15} | {3,-13} | {4,-10}",
                                reader.GetString("Code"),
                                reader.GetString("Name"),
                                reader.GetInt64("Population"),
                                reader.GetString("Organization"),
                                reader.GetString("Continent"));
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