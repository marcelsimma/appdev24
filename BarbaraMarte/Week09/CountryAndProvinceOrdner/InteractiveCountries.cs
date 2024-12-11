using BarbaraMarte.Week02;
using MySql.Data.MySqlClient;
namespace BarbaraMarte.Week09.CountryAndProvince
{
    class InteractiveCountriesStart
    {
        public static void Start()
        {
            string connectingString = "";
            using (StreamReader streamReader = new StreamReader("C:/AttendingList1/SqlId.txt"))
            {
                connectingString = streamReader.ReadToEnd();
            }
            bool running = true;
            string input = "";
            List<string> newInput = new List<string>();
            int count = 0;

            do
            {
                System.Console.WriteLine("Please enter a Country code.\nIf you want to Print out your Input press E");
                input = (Console.ReadLine() ?? "").ToUpper();
                if (input == "E")
                {
                    running = false;
                }
                else
                {
                    newInput.Add(input);
                }
            } while (running == true);
            using (MySqlConnection connection = new MySqlConnection(connectingString))
            {
                try
                {
                    connection.Open();
                    System.Console.WriteLine("Program works till here");
                    do
                    {
                        count++;
                        foreach (string inPut in newInput)
                        {
                            string query1 = @$"
                        SELECT DISTINCT
                        Name, 
                        Continent,
                        Capital
                        
                        FROM Country, encompasses
                        WHERE country.code = encompasses.Country
                        AND country.code = '{inPut}';";

                            using (MySqlCommand command = new MySqlCommand(query1, connection))
                            {
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string name = reader.GetString("Name");
                                        string continent = reader.GetString("Continent");
                                        string capital = reader.GetString("Capital");
                                        Country country = new Country(name, capital, continent);
                                        System.Console.WriteLine(country.ToString());
                                    }
                                }
                            }
                            string query2 = @$"
                            SELECT
                            Name, 
                            Capital,
                            Population
                            FROM mondial.province
                            WHERE province.country = '{inPut}';
                            ";
                            using (MySqlCommand command = new MySqlCommand(query2, connection))
                            {
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string name = reader.GetString("Name");
                                        string capital = reader.GetString("Capital");
                                        int population = reader.GetInt32("Population");
                                        Province province = new Province(name, capital, population);
                                        Country.AddProvinces(province);
                                    }
                                }
                            }
                            Country.GetPopulation();
                            Country.GetProvinces();
                            Console.WriteLine();
                        }

                    } while (newInput.Count == count - 1);
                }
                catch (MySqlException ex)
                {
                    System.Console.WriteLine("Something is wrong " + ex.Message);
                }
            }

        }
    }




    class InteractiveCountries
    {
        public static void Start()
        {
            bool running = true;
            while (running == true)
            {
                using (StreamReader streamReader = new StreamReader("C:/AttendingList1/SqlId.txt"))
                {
                    string databaseConnectionString = streamReader.ReadToEnd();
                    using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                    {
                        try
                        {
                            System.Console.WriteLine("Enter a Country code:");
                            string input = Console.ReadLine() ?? "";
                            connection.Open();
                            string query1 = @$"
                        SELECT DISTINCT 

                        Country.code AS CountryCode, 
                        country.name AS CountryName, 
                        Country.capital AS CountryCapital,
                        province.name AS ProvinceName, 

                        encompasses.continent AS EncompassesContinent
                        FROM Country, encompasses
                        WHERE country.code = encompasses.Country
                        AND country.code = '{input}'
                        ORDER BY country.code ASC
                        ;";
                            string query2 = @$"
                        province.name AS ProvinceName, 
                        province.capital AS ProvinceCapital, 
                        province.population AS ProvincePopulation

                        FROM Country
                        LEFT JOIN Province ON Country.Code = Province.country                        
                        AND country.code = '{input}'
                        ";
                            MySqlCommand command = new MySqlCommand(query1, connection);
                            int population = 0;
                            int count = 1;
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                Country country = new Country("CountryName", "CountryCapital", "EncompassesContinent");
                                // System.Console.WriteLine(country.CountPopulation());

                                Province province = new Province("ProvinceName", "ProvinceCapital", population);
                                System.Console.WriteLine($"ProvincePopulation    {province.Population}");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }
                    }
                };
                System.Console.WriteLine("Dou you want to look up an other country? Yes or No");
                string inputYes = Console.ReadLine() ?? "";
                if (inputYes != "Yes")
                {
                    running = false;
                }

            }

        }
    }
}