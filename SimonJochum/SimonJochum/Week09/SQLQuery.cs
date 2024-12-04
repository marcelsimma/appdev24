using System;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week09
{
    public class SQLQuery
    {
        public static void Start()
        {
            EUMembers();
            // SearchCountryByCode();
        }

        public static void EUMembers()
        {
            using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
            {
                string connectionString = str.ReadToEnd();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Connection established");

                        string query = @"SELECT DISTINCT
                                    country.name AS Country,
                                    country.code AS Code, 
                                    country.population AS Population
                                    FROM 
                                    ismember 
                                    JOIN 
                                    country ON ismember.country = country.code 
                                    JOIN 
                                    city ON country.capital = city.name
                                    WHERE 
                                    ismember.organization = 'EU'
                                    AND ismember.type = 'member';";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string country = reader.GetString("Country");
                                    string code = reader.GetString("Code");
                                    int population = reader.GetInt32("Population");
                                    Console.WriteLine($"Country = {country} Code = {code} Population: {population}");
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Fehler: {ex.Message}");
                    }
                }
            }
        }

        public static void SearchCountryByCode()
        {
            using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
            {
                string connectionString = str.ReadToEnd();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Connection established");
                        Console.WriteLine("Bitte einen Länderkürzel eingeben, um den Namen und die Bevölkerungszahl zu bekommen:");
                        string input = Console.ReadLine();

                        string query = @$"SELECT country.name, country.population 
                                  FROM mondial.country 
                                  WHERE code = '{input}';";

                        bool countryFound = false;

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string country = reader.GetString("name");
                                    int population = reader.GetInt32("population");
                                    Console.WriteLine($"Country: {country}, Population: {population}");
                                    countryFound = true;
                                }
                            }
                        }

                        if (!countryFound)
                        {
                            Console.WriteLine("Kein Land mit dem eingegebenen Kürzel gefunden.");
                            return;
                        }

                        Console.WriteLine("Abfrage der Provinzen und deren Hauptstädte...");
                        string query2 = @$"SELECT province.name AS province_name, province.capital 
                                   FROM mondial.province 
                                   WHERE province.country = '{input}';";

                        Dictionary<string, string> provinces = new Dictionary<string, string>();

                        using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                        {
                            using (MySqlDataReader reader2 = command2.ExecuteReader())
                            {
                                while (reader2.Read())
                                {
                                    string provinceName = reader2.GetString(reader2.GetOrdinal("province_name"));
                                    string capital = reader2.GetString(reader2.GetOrdinal("capital"));
                                    provinces.Add(provinceName, capital);
                                }
                            }
                        }

                        Console.WriteLine("Provinzen und ihre Hauptstädte:");
                        foreach (var province in provinces)
                        {
                            Console.WriteLine($"Provinz: {province.Key}, Hauptstadt: {province.Value}");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Fehler: {ex.Message}");
                    }
                }
            }
        }
    }
}