using System;
using MySql.Data.MySqlClient;
namespace JulianStroehle.Week9.CountriesAndProvincesAsync
{
    internal class CountriesAndProvincesAsync
    {
        static StreamReader str = new StreamReader("C:/Users/JUSR/Desktop/-/PW.txt");
        static string databaseConnectionString = $"server=localhost;userid=root;password={str.ReadLine()};database=mondial";
        internal static async Task Start()
        {
            using (MySqlConnection conn = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    conn.Open();
                    var userInput = Input();
                    var loading = Load(conn, userInput.ToString());
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static async Task<string> Input()
        {
            Console.WriteLine("Insert country code or type (LOWER CASE) \'e\' to exit");
            return Console.ReadLine();
        }
        static async Task Load(MySqlConnection conn, string input)
        {
            do
            {
                string query = "SELECT country.Name AS A, country.Code AS B, country.Capital AS C, encompasses.Continent AS D, province.Name AS F, province.Capital AS G, province.Population AS H, province.Country AS I, ismember.Organization AS J FROM country, encompasses, province, ismember WHERE (ismember.Organization = 'EU' OR ismember.Organization = 'NATO') AND country.Code = ismember.Country AND country.Code = encompasses.Country AND country.Code = province.Country AND Code LIKE @code ORDER BY B";
                List<CountryAsync> countries = new List<CountryAsync>();
                List<ProvinceAsync> provinces = new List<ProvinceAsync>();
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
                        string countryOrganization = rdr.GetString("J");
                        CountryAsync country = new CountryAsync(countryName, countryCode, countryCapital, countryContinent, countryOrganization);
                        countries.Add(country);
                        string provinceName = rdr.GetString("F");
                        string provinceCapital = rdr.GetString("G");
                        int provincePopulation = rdr.GetInt32("H");
                        string provinceCountry = rdr.GetString("I");
                        ProvinceAsync province = new ProvinceAsync(provinceName, provinceCapital, provincePopulation, provinceCountry, countryContinent);
                        provinces.Add(province);
                    }
                    CountryAsync temp = new CountryAsync("test", "test", "test", "test", "test");
                    for (int i = countries.Count - 1; i >= 0; i--)
                    {
                        if (i - 1 >= 0 && countries[i].Code == countries[i - 1].Code && countries[i].Organization == countries[i - 1].Organization)
                        {
                            countries[i] = temp;
                        }
                        else if (i - 1 >= 0 && countries[i].Code == countries[i - 1].Code && countries[i].Organization != countries[i - 1].Organization)
                        {
                            countries[i] = temp;
                            countries[i - 1].Organization = "NATO & EU";
                        }
                        for (int j = 0; j < provinces.Count; j++)
                        {
                            if (provinces[j].Country == countries[i].Code)
                            {
                                provinces[j].Organization = countries[i].Organization;
                            }
                            if (j + 1 < provinces.Count && provinces[j].Name == provinces[j + 1].Name)
                            {
                                provinces.RemoveAt(j);
                                j--;
                            }
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
                    Print(countries);
                }
            }
            while (input != "e");
            Console.Clear();
        }
        static void Print(List<CountryAsync> countries)
        {
            int count = 1;
            bool wrote = false;
            Console.Write("┌" + new string('─', 9) + "┬" + new string('─', 35) + "┬" + new string('─', 27) + "┬" + new string('─', 25) + "┬" + new string('─', 17) + "┬" + new string('─', 13) + "┐");
            Console.WriteLine("\n│" + string.Format("{0,-17}", $"\x1b[3m{"  Nr.  "}\x1b[0m") + "│" + string.Format("{0,-43}", "  " + $"\x1b[3m{"Name"}\x1b[0m") + "│" + string.Format("{0,-35}", "  " + $"\x1b[3m{"Capital"}\x1b[0m") + "│" + string.Format("{0,-33}", "  " + $"\x1b[3m{"Continent"}\x1b[0m") + "│" + string.Format("{0,-25}", "  " + $"\x1b[3m{"Organization"}\x1b[0m") + "│" + string.Format("{0,-21}", "  " + $"\x1b[3m{"Population"}\x1b[0m") + "│");
            Console.Write("├" + new string('─', 9) + "┼" + new string('─', 35) + "┼" + new string('─', 27) + "┼" + new string('─', 25) + "┼" + new string('─', 17) + "┼" + new string('─', 13) + "┤");
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries[i].ToString(count));
                Console.Write("│" + new string(' ', 9) + "│" + new string(' ', 35) + "│" + new string(' ', 27) + "│" + new string(' ', 25) + "│" + new string(' ', 17) + "│" + new string(' ', 13) + "│");
                wrote = true;
                int count2 = 1;
                for (int j = 0; j < countries[i].Provinces.Count; j++)
                {
                    Console.Write(countries[i].Provinces[j].ToString(count, count2));
                    count2++;
                }
                Console.Write("\n├" + new string('─', 9) + "┼" + new string('─', 35) + "┼" + new string('─', 27) + "┼" + new string('─', 25) + "┼" + new string('─', 17) + "┼" + new string('─', 13) + "┤");
                count++;
            }
            Console.WriteLine("\r└" + new string('─', 9) + "┴" + new string('─', 35) + "┴" + new string('─', 27) + "┴" + new string('─', 25) + "┴" + new string('─', 17) + "┴" + new string('─', 13) + "┘");
            if (!wrote)
            {
                Console.WriteLine("Error, no country matches your input");
            }
        }
    }
}