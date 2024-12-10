using System;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace BerkantAkinci.Week09
{
    public class MainCountryProvinces
    {
        public static void PrintMain()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=BAULAN;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();
                    // Datenbank Abfrage erstellen
                    string query = @"SELECT DISTINCT country.Name AS countryName, encompasses.Continent, country.Capital AS countryCapital, country.Population AS TotalPopulation, city.Province, city.Name AS city, city.Population AS cityPopulation
                                    FROM country
                                    JOIN encompasses ON country.Code = encompasses.Country
                                    JOIN city ON country.Code = city.Country
                                    WHERE country.Name = @code
                                    ORDER BY city.Province ASC";

                    List<string> inputs = new List<string>();
                    string input;

                    do
                    {
                        bool found = false;
                        // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                        MySqlCommand command = new MySqlCommand(query, connection);
                        System.Console.WriteLine("Geben Sie ein Ländername ein:");
                        input = Console.ReadLine();
                        System.Console.WriteLine();
                        command.Parameters.AddWithValue("@code", input);
                        inputs.Add(input);
                        int cityPopulation = 0;

                        // Resultate lesen
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                if (count == 0 && reader.GetString("countryName") == input)
                                {
                                    string countryName = reader.GetString("countryName");
                                    string countryCapital = reader.GetString("continent");
                                    string continent = reader.GetString("countryCapital");
                                    int totalPopulation = reader.GetInt32("totalPopulation");
                                    Country newCountry = new Country(countryName, countryCapital, continent, totalPopulation);
                                    Console.WriteLine(newCountry.ToString());

                                    found = true;
                                    count++;
                                }
                                if (input == reader.GetString("countryName"))
                                {
                                    string province = reader.GetString("province");
                                    string city = reader.GetString("city");

                                    if (reader.IsDBNull(reader.GetOrdinal("cityPopulation")))
                                    {
                                        System.Console.Write("- ");
                                        Console.Write(province = reader.GetString("province"));
                                        System.Console.Write(", ");
                                        Console.Write(city = reader.GetString("city"));
                                        System.Console.Write(", ");
                                        System.Console.WriteLine("- kein Eintrag -");
                                    }

                                    else
                                    {
                                        cityPopulation = reader.GetInt32("cityPopulation");
                                    }

                                    //int cityPopulation = reader.GetInt32("cityPopulation");
                                    Province newProvince = new Province(province, city, cityPopulation);
                                    Country.AddProvinces(newProvince);
                                    System.Console.WriteLine(newProvince.ToString());

                                }

                            }
                        }
                        if (!found)
                        {
                            System.Console.WriteLine("Dies ist kein Land, Groß - und Kleinschreibung auch beachten und auf Englisch.");
                        }


                        System.Console.WriteLine();
                    } while (input != "fertig");
                }

                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }


        }
    }
}