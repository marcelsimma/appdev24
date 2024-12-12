using System;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week10.Test
{
    public class CountriesAndRivers
    {
        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=QRUP369_purq;
            database=mondial";

            Console.WriteLine("Tippe ein Länderkürzel ein, für welches du alle Flüsse suchen möchtest!");

            while (true)
            {
                string input = Console.ReadLine();

                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string queryOne = @"SELECT DISTINCT geo_river.River AS RiverName, river.Length AS RiverLength
                            FROM mondial.country
                            JOIN geo_river ON country.Code = geo_river.Country
                            JOIN river ON geo_river.River = river.Name
                            WHERE country.Code = @code
                            ORDER BY river.Length DESC;";

                        MySqlCommand command = new MySqlCommand(queryOne, connection);
                        command.Parameters.AddWithValue("@code", input);

                        Country country = new Country(input);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string riverName = reader.GetString("RiverName");
                                double riverLength = reader.GetDouble("RiverLength");

                                country.SearchAndAddRivers(new River(riverName, riverLength));
                            }
                        }

                        if (country.Rivers.Count > 0)
                        {
                            Console.Write($"\nFlüsse in {country.CountryCode}\n--------------------------------\n");
                            foreach (River river in country.Rivers)
                            {
                                Console.WriteLine($"{river.Rivername,-20}{river.Riverlength,7:F2} km");
                            }
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine(country.CalculateRiverSum());
                        }
                        else
                        {
                            Console.WriteLine($"Es wurden keine Flüsse für das Länderkürzel {input} gefunden!");
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
}