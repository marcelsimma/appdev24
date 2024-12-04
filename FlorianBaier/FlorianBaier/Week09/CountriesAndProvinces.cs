using System;
using MySql.Data.MySqlClient;
//unvollständig


namespace FlorianBaier.Week09
{

    class CountriesAndProvinces
    {
        public static void Start()
        {
            using (StreamReader streamReader = new StreamReader("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt"))
            {
                // string input = streamReader.ReadLine() ?? "";
                string databaseConnectionString = streamReader.ReadToEnd();

                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        System.Console.WriteLine("Enter a Country code:");
                        string input = Console.ReadLine() ?? "";
                        connection.Open();
                        string query = @$"
                        SELECT DISTINCT Country.code, country.name, country.population, province.name, province.capital, province.population
                        FROM Country, Province
                        WHERE Country.code = province.country
                        AND country.code
                        like '{input}'
                        ORDER BY country.code ASC
                        ;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        // command.Parameters.AddWithValue("@code", "A");   is for the placeholder
                        int count = 1;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.Write(reader.GetString("name") + " ");
                                Console.Write(reader.GetString("code") + " ");
                                Console.Write(reader.GetUInt32("population") + " ");
                                Console.Write(reader.GetString("name") + " ");
                                Console.Write(reader.GetString("capital") + " ");
                                Console.WriteLine(reader.GetUInt32("population"));
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
}