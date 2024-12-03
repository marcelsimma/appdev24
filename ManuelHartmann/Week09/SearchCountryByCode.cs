// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;


namespace ManuelHartmann.Week09.SeachCountryByCode
{
    public class SeachCountryByCode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a country.Code");
            string respond = Console.ReadLine();

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
                    string query = @"SELECT country.Code, country.Name, country.Population 
                                    FROM country
                                    WHERE country.Code = @platzhalter;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@platzhalter", respond);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.Clear();
                        while (reader.Read())
                        {
                            Console.Write(reader.GetString("Code"));
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