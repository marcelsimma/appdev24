using MySql.Data.MySqlClient;

namespace BarbaraMarte.Week10.Test;

class CountriesAndRivers
{
    public static void Start()
    {
        using (StreamReader streamReader = new StreamReader("C:/AttendingList1/SqlId.txt"))
        {
            // string input = streamReader.ReadLine() ?? "";
            string databaseConnectionString = streamReader.ReadToEnd();

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @$"
                        SELECT DISTINCT mondial.geo_river.river AS River, river.length AS RiverLength, geo_river.country AS Country
                        FROM geo_river, river
                        WHERE geo_river.River = river.Name
                        AND geo_river.country LIKE 'A'
                        ORDER BY river.Length
                        DESC                       
                        ;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    // command.Parameters.AddWithValue("@code", "A");   is for the placeholder
                    int count = 1;
                    double riverLength = 0.0;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        System.Console.WriteLine();
                        Console.WriteLine($"Rivers in {reader.GetString("Country")}");
                        System.Console.WriteLine("----------------------------------");
                        while (reader.Read())
                        {
                            Console.Write($"{reader.GetString("River"),-16:F2}");
                            Console.WriteLine($"{reader.GetUInt32("RiverLength"),15:F2} km");
                            riverLength += reader.GetUInt32("RiverLength");
                            count++;
                        }
                        if (count == 1)
                        {
                            System.Console.WriteLine("Not found");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                System.Console.WriteLine();
                            }
                        }
                        System.Console.WriteLine("----------------------------------");
                        System.Console.WriteLine($"Total River length: {riverLength,11:F2} km");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        };
    }
}