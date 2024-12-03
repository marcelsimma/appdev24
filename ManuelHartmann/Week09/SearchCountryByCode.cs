// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;


namespace ManuelHartmann.Week09.SearchCountryByCode
{
    public class Program
    {
        static void Main(string[] args)
        {
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
                    string query = @"SELECT *
                                    FROM country
                                    WHERE country.Code like @platzhalter;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@platzhalter", $"{respond}%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Console.Clear();
                        Console.WriteLine("{0,-8} | {1,-20} | {2,-25}",
                                             "Code", "Name", "Population"); // Überschrift
                        Console.WriteLine(new string('-', 45)); // Trenner

                        while (reader.Read())
                        {
                            Console.WriteLine("{0,-8} | {1,-20} | {2,-25}",
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