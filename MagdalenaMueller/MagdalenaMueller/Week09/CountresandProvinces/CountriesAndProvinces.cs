using System;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;

namespace MagdalenaMueller.Week09
{
    public class CountriesAndProvinces
    {
        static Dictionary<string, Country> countrys = new Dictionary<string, Country>();
        static Dictionary<string, List<Province>> provinces = new Dictionary<string, List<Province>>();
        public static void Start()
        {
            bool again = true;

            while (again == true)
            {
                Console.WriteLine("Staat Hinzufügen(1)\nStaaten anzeigen(2)\nBundesländer anzeigen(3)");
                string? task = Console.ReadLine();

                switch (task)
                {
                    case "1":
                        AddCountry();
                        break;
                    case "2":
                        WriteCountrys();
                        break;
                    case "3":
                        WriteProvinces();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void AddCountry()
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

                    string query = "SELECT country.name as country_name, country.Population as country_Population, country.Capital as country_capital, continent.name as continent, province.name as province_name, province.Capital as province_capital, province.Population as province_population FROM country, province, encompasses, continent WHERE country.code = province.country AND country.code = @code And Country.code = encompasses.country and encompasses.Continent = continent.name;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", $"{input}");

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string countryName = reader.GetString("country_name");
                            string countryCapital = reader.GetString("country_capital");
                            string continent = reader.GetString("continent");
                            int countryPopulation = reader.GetInt32("country_Population");

                            string provinceName = reader.GetString("province_name");
                            string provinceCapital = reader.GetString("province_capital");
                            int provincePopulation = reader.GetInt32("province_population");


                            if (!countrys.ContainsKey(countryName))
                            {
                                Country country1 = new Country(countryName, countryCapital, continent, countryPopulation, new List<Province>());
                                countrys.Add(countryName, country1);
                            }

                            if (!countrys[countryName].ProvicesOfCountry.Any(p => p.NameOfProvince == provinceName))
                            {
                                Province province = new Province(countryName, provinceName, provinceCapital, provincePopulation);
                                if (!provinces.ContainsKey(countryName))
                                {
                                    provinces.Add(countryName, new List<Province>());
                                    provinces[countryName].Add(province);
                                    countrys[countryName].ProvicesOfCountry.Add(province);
                                }
                                else
                                {
                                    provinces[countryName].Add(province);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler in AddCountry: " + ex.Message);
                }
            }
        }
        public static void WriteCountrys()
        {
            int counter = 1;

            Console.WriteLine("┌──────┬──────────────────────┬──────────────────────────┬──────────────────────────┬─────────────────────┐");
            Console.WriteLine("│ Num  │ Country Name         │ Capital Name             │ Continent                │ Population          │");
            Console.WriteLine("├──────┼──────────────────────┼──────────────────────────┼──────────────────────────┼─────────────────────┤");


            foreach (var countrykey in countrys)
            {
                var country = countrykey.Value;

                Console.WriteLine($"│ {counter,3}. " + country.ToString());
                counter++;

            }

            Console.WriteLine("└──────┴──────────────────────┴──────────────────────────┴──────────────────────────┴─────────────────────┘");
        }
        public static void WriteProvinces()
        {
            int counter = 1;

            Console.WriteLine("┌──────┬──────────────────────┬──────────────────────────┬──────────────────────────┬─────────────────────┐");
            Console.WriteLine("│ Num  │ Country Name         │ Province Name            │ Capital Name             │ Population          │");
            Console.WriteLine("├──────┼──────────────────────┼──────────────────────────┼──────────────────────────┼─────────────────────┤");


            foreach (var country in provinces)
            {
                foreach (var province in country.Value)
                {
                    Console.WriteLine($"│ {counter,3}. " + province.ToString());
                    counter++;
                }
            }

            Console.WriteLine("└──────┴──────────────────────┴──────────────────────────┴──────────────────────────┴─────────────────────┘");
        }
    }
}