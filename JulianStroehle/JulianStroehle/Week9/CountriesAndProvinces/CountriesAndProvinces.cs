using System;
using MySql.Data.MySqlClient;
namespace JulianStroehle.Week9.CountriesAndProvinces
{
    internal class CountriesAndProvinces
    {
        static StreamReader str = new StreamReader("C:/Users/JUSR/Desktop/-/PW.txt");
        static string databaseConnectionString = $"server=localhost;userid=root;password={str.ReadLine()};database=mondial";
        internal static void Start()
        {
            using (MySqlConnection conn = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    string input;
                    conn.Open();
                    do
                    {
                        string query = "SELECT country.Name AS A, country.Code AS B, country.Capital AS C, encompasses.Continent AS D, country.Population AS E, province.Name AS F, province.Capital AS G, province.Population AS H, province.Country AS I FROM country, encompasses, province WHERE country.Code = encompasses.Country AND country.Code = province.Country AND Code LIKE @code ORDER BY B";
                        Console.WriteLine("Insert country code or type \'e\' to exit");
                        List<Country> countries = new List<Country>();
                        List<Province> provinces = new List<Province>();
                        input = Console.ReadLine();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@code", input + "%");
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                string countryName = rdr.GetString("A");
                                string countryCode = rdr.GetString("B");
                                string countryCapital = rdr.GetString("C");
                                string countryContinent = rdr.GetString("D");
                                int countryPopulation = rdr.GetInt32("E");
                                Country country = new Country(countryName, countryCode, countryCapital, countryContinent, countryPopulation);
                                countries.Add(country);
                                string provinceName = rdr.GetString("F");
                                string provinceCapital = rdr.GetString("G");
                                int provincePopulation = rdr.GetInt32("H");
                                string provinceCountry = rdr.GetString("I");
                                Province province = new Province(provinceName, provinceCapital, provincePopulation, provinceCountry, countryContinent);
                                provinces.Add(province);
                            }
                            Country temp = new Country("test", "test", "test", "test", 1);
                            for (int i = countries.Count - 1; i >= 0; i--)
                            {
                                if (i - 1 >= 0 && countries[i].Code == countries[i - 1].Code)
                                {
                                    countries[i] = temp;
                                }
                                for (int j = provinces.Count - 1; j >= 0; j--)
                                {
                                    if (provinces[j].Country == countries[i].Code)
                                    {
                                        countries[i].Provinces.Add(provinces[j]);
                                    }
                                }
                            }
                            for (int i = countries.Count - 1; i >= 0; i--)
                            {
                                if (countries[i].Code == "test")
                                {
                                    countries.RemoveAt(i);
                                }
                            }
                            int count = 1;
                            bool wrote = false;
                            Console.Write("┌" + new string('─', 8) + "┬" + new string('─', 30) + "┬" + new string('─', 22) + "┬" + new string('─', 25) + "┬" + new string('─', 13) + "┐");
                            Console.WriteLine("\n│" + string.Format("{0,-16}", $"\x1b[3m{"  Nr.  "}\x1b[0m") + "│" + string.Format("{0,-38}", "  " + $"\x1b[3m{"Name"}\x1b[0m") + "│" + string.Format("{0,-30}", "  " + $"\x1b[3m{"Capital"}\x1b[0m") + "│" + string.Format("{0,-33}", "  " + $"\x1b[3m{"Continent"}\x1b[0m") + "│" + string.Format("{0,-21}", "  " + $"\x1b[3m{"Population"}\x1b[0m") + "│");
                            Console.Write("├" + new string('─', 8) + "┼" + new string('─', 30) + "┼" + new string('─', 22) + "┼" + new string('─', 25) + "┼" + new string('─', 13) + "┤");
                            for (int i = 0; i < countries.Count; i++)
                            {
                                Console.WriteLine(countries[i].ToString(count));
                                Console.Write("│" + new string(' ', 8) + "│" + new string(' ', 30) + "│" + new string(' ', 22) + "│" + new string(' ', 25) + "│" + new string(' ', 13) + "│");
                                wrote = true;
                                int count2 = 1;
                                for (int j = 0; j < countries[i].Provinces.Count; j++)
                                {
                                    Console.Write(countries[i].Provinces[j].ToString(count, count2));
                                }
                                Console.Write("\n├" + new string('─', 8) + "┼" + new string('─', 30) + "┼" + new string('─', 22) + "┼" + new string('─', 25) + "┼" + new string('─', 13) + "┤");
                            }
                            Console.WriteLine("\r└" + new string('─', 8) + "┴" + new string('─', 30) + "┴" + new string('─', 22) + "┴" + new string('─', 25) + "┴" + new string('─', 13) + "┘");
                            if (!wrote)
                            {
                                Console.WriteLine("Error, no country matches your input");
                            }
                        }
                    }
                    while (input.ToLower() != "e");
                    Console.Clear();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}