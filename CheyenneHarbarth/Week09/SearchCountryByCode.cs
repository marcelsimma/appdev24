using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

namespace CheyenneHarbarth.Week09
{
    public class SearchCountryByCode
    {
        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=QRUP369_purq;
            database=mondial";

            while (true)
            {
                Console.WriteLine("Gib ein Landeskürzel ein, dass du suchen möchtest!");
                string input = Console.ReadLine();

                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = @"
                        SELECT country.Name AS Countryname, country.Population AS CountryPopulation, province.Name AS Provincename, province.Capital 
                        FROM country
                        JOIN province ON country.Code = province.Country
                        WHERE Code = @code;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@code", input);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Dictionary<string, string> ProvincesInCountry = new Dictionary<string, string>();

                            if (reader.HasRows)                     //sucht nach dem vorgegebene Wert und liefert einen bool zurück
                            {
                                while (reader.Read())
                                {
                                    string Province = reader.GetString("Provincename");
                                    string ProvinceCapital = reader.GetString("Capital");

                                    if (Province is not null)
                                    {
                                        ProvincesInCountry.Add(Province, ProvinceCapital);
                                    }
                                }
                                Console.Write($"Land: {reader.GetString("Countryname"),-15} | Bevölkerung: {reader.GetInt32("CountryPopulation"),-15}\n");
                                Console.WriteLine("\nProvinzen:      | Hauptstadt: ");
                                Console.WriteLine("--------------------------------");
                                foreach (KeyValuePair<string, string> pic in ProvincesInCountry)
                                {
                                    Console.Write($"{pic.Key,-15} | {pic.Value,-15}\n");
                                }
                                break;
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
    }
}