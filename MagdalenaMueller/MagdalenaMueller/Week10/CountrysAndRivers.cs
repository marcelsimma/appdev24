using System;
using MySql.Data.MySqlClient;

namespace MagdalenaMueller.Weeek10
{
    public class CountrysAndRivers
    {
        public static Dictionary<string,float> riversWithLength;
        public static void Start()
        {
            GetData();
            WriteCountrysAndRivers();
        }
        public static void GetData()
        {
            riversWithLength = new Dictionary<string, float>();

            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=10GoldeneHunde;
            database=mondial
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT river.name AS river, river.length As length "+
                                    "FROM river "+
                                    "JOIN geo_river ON river.name = geo_river.river "+
                                    "JOIN province ON geo_river.country = province.country "+
                                    "JOIN country ON province.country = country.code "+
                                    "WHERE river.length IS NOT NULL "+
                                    "And country.code = @code " +
                                    "ORDER BY river.length DESC;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", "A");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            riversWithLength.Add(reader.GetString("river"),reader.GetFloat("length"));
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void WriteCountrysAndRivers()
        {
            float sum = 0f;
            Console.WriteLine("Flüsse in A");
            Console.WriteLine("---------------------------");
            foreach(var river in riversWithLength)
            {
                Console.WriteLine($"{river.Key,-15} {river.Value,-5} km");
                sum += river.Value;
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Gesamtlänge: {sum,7} km");
        }
    }
}