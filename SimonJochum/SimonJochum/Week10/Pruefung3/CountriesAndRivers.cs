using System;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week10.Pruefung3
{
    public class CountriesAndRivers
    {
        private static Dictionary<string, double> riversAndLength = new Dictionary<string, double>();
        private static double totalLength = 0;
        private static string connectionString = "";
        private static char code = 'A';
        public static void Start()
        {
            QueryToDB();
            PrintList();
        }

        public static void QueryToDB()
        {
            using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
            {
                connectionString = str.ReadToEnd();
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"SELECT DISTINCT 
                                        (geo_river.River), 
                                        river.Length 
                                    FROM 
                                        geo_river, 
                                        encompasses, 
                                        river 
                                    WHERE 
                                        encompasses.Country = '{code}' 
                                    AND 
                                        geo_river.Country = encompasses.Country 
                                    AND 
                                        river.Name = geo_river.River 
                                    ORDER BY
                                        river.Length
                                    DESC;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string river = reader.GetString("River");
                                double length = reader.GetDouble("Length");
                                riversAndLength.Add(river, length);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }

        public static void PrintList()
        {
            Console.WriteLine($"Hier sind alle Flüsse von '{code}'\n" + new string('-', 21));
            foreach (var entry in riversAndLength)
            {
                Console.WriteLine($"{entry.Key, -10}  {entry.Value,5} km");
                totalLength += entry.Value;
            }
            Console.WriteLine(new string('-', 21));
            Console.WriteLine($"Gesamtlänge: {totalLength, 1} km");
        }
    }
}