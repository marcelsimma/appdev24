using System;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace BerkantAkinci.Week09
{
    public class SearchCountryByCode
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
                    string query = @"SELECT country.Name, country.Code, country.Population
                                    FROM country WHERE country.Code = @code;";  //Kommt da LIKE oder "="


                    string input;


                    do
                    {
                        bool found = false;
                        // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                        MySqlCommand command = new MySqlCommand(query, connection);
                        System.Console.WriteLine("Geben Sie ein Länderkürzel ein:"); //Wenn ich zeile 35-37 in die while schlafe packe funktionierts nicht
                        input = Console.ReadLine();
                        command.Parameters.AddWithValue("@code", input);

                        // Resultate lesen
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                if (input == reader.GetString("code"))
                                {
                                    Console.Write(@"{0,-20}", reader.GetString("name"));
                                    Console.Write(@"{0,-10}", reader.GetString("code"));
                                    Console.WriteLine(@"{0,10}", reader.GetInt32("population"));
                                    found = true;
                                }
                            }
                        }
                        if (!found)
                        {
                            System.Console.WriteLine("Dies ist kein Länderkürzel");
                        }
                        System.Console.WriteLine();
                    } while (input != "fertig");
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
