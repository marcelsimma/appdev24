using System;
using System.Diagnostics.Metrics;
using MySql.Data.MySqlClient;

namespace MagdalenaMueller.Week09
{
    public class EUmembers
    {
        public static void StartEUmembers()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=10GoldeneHunde;
            database=mondial
            ";

            int counter = 1;
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT ismember.Organization , country.name, country.code, country.Population from ismember, country where ismember.organization = @code and ismember.country = country.code and ismember.type = 'member';";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@code", "EU");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            Console.Write( counter +". "+ reader.GetString("Organization") + ", ");
                            Console.Write(reader.GetString("name") + ", ");
                            Console.Write(reader.GetString("code") + ", ");
                            Console.WriteLine(reader.GetInt32("Population"));
                            counter++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Fehler");
                }
            }
        }
    }
}