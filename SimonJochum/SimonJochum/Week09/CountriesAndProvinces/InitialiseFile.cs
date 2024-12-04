using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week09.CountriesAndProvinces
{
    public class InitialiseFile
    {
        public static void Start()
        {

            string connectionString = "";
            using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
            {
                connectionString = str.ReadToEnd();
            }
            bool check = true;
            string input = "";
            List<string> inputs = new List<string>();
            int count = 0;
            do
            {
                Console.WriteLine("Bitte gib ein Länderkürzel ein, oder tippe 'Stop' um die Ausgabe zu starten.");
                input = Console.ReadLine();
                 if (input == "Stop")
                {
                    check = false;
                }
                else
                {
                    inputs.Add(input);
                }
            }
            while (check);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    do
                    {
                        count++;
                        foreach (string inp in inputs)
                        {
                            string query = @$"SELECT 
                                                Name, 
                                                Continent, 
                                                Capital 
                                            FROM 
                                                mondial.country 
                                            JOIN 
                                                encompasses 
                                            ON 
                                                country.code = encompasses.country 
                                            WHERE 
                                                code = '{inp}';";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string name = reader.GetString("Name");
                                        string continent = reader.GetString("Continent");
                                        string capital = reader.GetString("Capital");
                                        Country newCountry = new Country(name, capital, continent);
                                        Console.Write(newCountry.ToString());
                                    }
                                }
                            }
                            string query2 = @$"SELECT 
                                                Name, 
                                                Capital, 
                                                Population
                                            FROM 
                                                mondial.province 
                                            WHERE 
                                                province.country = '{inp}';";

                            using (MySqlCommand command = new MySqlCommand(query2, connection))
                            {
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string name = reader.GetString("Name");
                                        string capital = reader.GetString("Capital");
                                        int population = reader.GetInt32("Population");
                                        Province newProvince = new Province(name, capital, population);
                                        Country.AddProvinces(newProvince);
                                    }
                                }
                            }
                            Country.GetPopulation();
                            Country.GetProvinces();
                            Console.WriteLine();
                        }
                    }
                    while (inputs.Count == count - 1);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }
    }
}