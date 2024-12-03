// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using MySql.Data.MySqlClient;


namespace ManuelHartmann.Week09
{

    public class MysqlConnectExample
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=Abcd1234!;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = "SELECT * FROM country WHERE code like @platzhalter;";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@platzhalter", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Jetzt wird von der Tabelle 'country' die Spalte 'name' ausgegeben, welche mit 'A' beginnnen.
                            Console.WriteLine(reader.GetString("name"));
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