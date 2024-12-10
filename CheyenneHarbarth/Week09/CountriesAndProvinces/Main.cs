using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week09.CountriesAndProvinces
{
    public class CAPMain
    {
        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=QRUP369_purq;
            database=mondial";

            // Queue for storing country codes
            Queue<string> CountryCodes = new Queue<string>();

            // Prompt user to input country codes
            Console.WriteLine("Tippe die Länderkürzel ein, die du suchen möchtest! Wenn du fertig bist, tippe Stop!");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    WorkCodes(CountryCodes, databaseConnectionString);
                    break;
                }

                // Verify if input is a valid country code
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string queryOne = @"
                        SELECT country.Code
                        FROM country
                        WHERE country.Code = @code";

                        MySqlCommand command = new MySqlCommand(queryOne, connection);
                        command.Parameters.AddWithValue("@code", input);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                CountryCodes.Enqueue(input);
                            }
                            else
                            {
                                Console.Write("Das ist kein gültiges Länderkürzel! ");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.Write(ex.Message);
                    }
                }
            }
        }

        public static void WorkCodes(Queue<string> countryCodes, string dbConnectionString)
        {
            while (countryCodes.Count > 0)
            {
                string code = countryCodes.Dequeue();
                using (MySqlConnection connection = new MySqlConnection(dbConnectionString))
                {
                    try
                    {
                        connection.Open();
                        string queryTwo = @"
                            SELECT country.Name AS CountryName, country.Capital AS CountryCapital, encompasses.Continent
                            FROM country
                            JOIN encompasses ON country.Code = encompasses.Country
                            WHERE country.Code = @code;

                            SELECT province.Name, province.Capital, province.Population
                            FROM province
                            WHERE province.Country = @code
                            
                            ";

                        MySqlCommand command = new MySqlCommand(queryTwo, connection);
                        command.Parameters.AddWithValue("@code", code);

                        Country country = null;

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Read country data
                                while (reader.Read())
                                {
                                    string countryName = reader.GetString("CountryName");
                                    string countryCapital = reader.GetString("CountryCapital");
                                    string continent = reader.GetString("Continent");

                                    country = new Country(countryName, countryCapital, continent);
                                }

                                // Read provinces data
                                if (reader.NextResult())
                                {
                                    while (reader.Read())
                                    {
                                        string provinceName = reader.GetString("Name");
                                        string provinceCapital = reader.GetString("Capital");
                                        int provincePopulation = reader.GetInt32("Population");

                                        country.SearchAndAddProvinces(new Province(provinceName, provinceCapital, provincePopulation));
                                    }
                                }
                            }
                        }

                        // Output country and its provinces
                        if (country != null)
                        {
                            Console.WriteLine(country);
                            foreach (var province in country.Provinces)
                            {
                                Console.WriteLine(province);
                            }
                            //Console.WriteLine($"Gesamte Einwohnerzahl: {country.CountPopulation()}");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
