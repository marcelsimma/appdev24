using System;
using MySqlX.XDevAPI.CRUD;
using MySql.Data.MySqlClient;

namespace BerkantAkinci.Week10
{
    public class Initialise
    {
        public static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=mondial
            ";

        public static void InitialiseZoo(string zooName, int foundingYear)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"INSERT INTO zoo (ZooName, FoundingYear)
                                    Values (@zooName, @foundingYear);";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@zooName", zooName);
                    command.Parameters.AddWithValue("@foundingYear", foundingYear);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reader.GetString(zooName);
                            reader.GetInt32(foundingYear);
                        }
                    }
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }


        public static void InitialiseEnclosure()
        {

        }
    }
}
