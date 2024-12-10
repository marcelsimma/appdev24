using System;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace MagdalenaMueller.Week09
{
    public class SearchCountryByCode
    {
        public static List<int> countryPopulation = new List<int>();
        public static Dictionary<string, List<string>> provinces = new Dictionary<string, List<string>>();
        public static void Start()
        {
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

                    Console.WriteLine("Länderkürzel: ");
                    string? input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Ungültiger country code");
                        return;
                    }

                    string query = "SELECT country.name as country_name, province.name as province_name, province.Population as province_population " +
                                   "FROM country, province WHERE country.code = province.country AND country.code = @code;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", $"{input}");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string countryName = reader.GetString("country_name");
                            string provinceName = reader.GetString("province_name");
                            int provincePopulation = reader.GetInt32("province_population");

                            if (provinces.ContainsKey(countryName))
                            {
                                provinces[countryName].Add(provinceName);
                                countryPopulation.Add(provincePopulation);
                            }
                            else
                            {
                                provinces.Add(countryName, new List<string>());
                                provinces[countryName].Add(provinceName);
                                countryPopulation.Add(provincePopulation);
                            }

                        }
                    }

                    int counter = 1;

                    Console.WriteLine("┌─────┬──────────────────────┬──────────────────────────┬─────────────────────┐");
                    Console.WriteLine("│ Num │ Country Name         │ Province Name            │ Population          │");
                    Console.WriteLine("├─────┼──────────────────────┼──────────────────────────┼─────────────────────┤");

                    foreach (var country in provinces)
                    {
                        string countryName = country.Key;
                        List<string> provinceNames = country.Value; 

                        for (int i = 0; i < provinceNames.Count; i++)
                        {
                            string provinceName = provinceNames[i];

                            if (counter - 1 < countryPopulation.Count)
                            {
                                int population = countryPopulation[counter - 1]; 
                                Console.WriteLine($"│ {counter,3} │ {countryName,-20} │ {provinceName,-24} │ {population,19:N0} │");
                            }
                            else
                            {
                                Console.WriteLine($"│ {counter,3} │ {countryName,-20} │ {provinceName,-24} │                null │");
                            }

                            counter++;
                        }
                    }

                    Console.WriteLine("└─────┴──────────────────────┴──────────────────────────┴─────────────────────┘");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }
    }
}

