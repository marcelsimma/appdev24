using System;
using System.Data;
using MySql.Data.MySqlClient;


// get MySQL Package: dotnet add package MySql.Data --version 9.1.0

namespace BarbaraMarte.Week09
{
    public class CountriesAndProvinces
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
                        System.Console.WriteLine("Enter a Country code:");
                        string input = Console.ReadLine() ?? "";
                        connection.Open();
                        string query = @$"
                        SELECT DISTINCT 
                        Country.code AS CountryCode, 
                        country.name AS CountryName, 
                        country.population AS CountryPopulation, 
                        province.name AS ProvinceName, 
                        province.capital AS ProvinceCapital, 
                        province.population AS ProvincePopulation
                        FROM Country
                        LEFT JOIN Province ON Country.Code = Province.country                        
                        AND country.code = '{input}'
                        ORDER BY country.code ASC
                        ;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        // command.Parameters.AddWithValue("@code", "A");   is for the placeholder
                        int count = 1;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // List<string>
                            if (reader.HasRows)
                            {
                                reader.Read();
                                Console.WriteLine($"     | {reader.GetString("CountryName"),-15} | {reader.GetString("CountryCode"),-15} | {reader.GetUInt32("CountryPopulation"),10}");
                                System.Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine($"{count,3}. | {reader.GetString("ProvinceName"),-15} | {reader.GetString("ProvinceCapital"),-15} | {reader.GetUInt32("ProvincePopulation"),10}");
                                while (reader.Read())
                                {
                                    count++;
                                    Console.WriteLine($"{count,3}. | {reader.GetString("ProvinceName"),-15} | {reader.GetString("ProvinceCapital"),-15} | {reader.GetUInt32("ProvincePopulation"),10}");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Wrong Input");
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