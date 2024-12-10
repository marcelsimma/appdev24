/*using System;
using MySql.Data.MySqlClient;



namespace FlorianBaier.Week09
{

    class CountriesAndProvinces
    {
       public static void Start()
        {
            string connectionString = "";

            // Liest die Verbindungseinstellungen aus einer Textdatei
            using (StreamReader str = new StreamReader("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt"))
            {
                connectionString = str.ReadToEnd();
            }

            bool check = true;
            string input = "";
            List<string> inputs = new List<string>(); // List der Länderkürzel
            int count = 0;

            // Abfrage nach Länderkürzeln, bis "Stop" eingegeben wird
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

                    // Abfrage für jedes Land
                    foreach (string inp in inputs)
                    {
                        string query = @$"
                            SELECT 
                                country.Name, 
                                country.Continent, 
                                country.Capital 
                            FROM 
                                mondial.country 
                            WHERE 
                                country.code = '{inp}';
                        ";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string name = reader.GetString("Name");
                                    string continent = reader.GetString("Continent");
                                    string capital = reader.GetString("Capital");
                                    
                                    // Erstellen eines neuen Country-Objekts
                                    Country country = new Country(capital, name, continent);
                                    Console.WriteLine(country.ToString());

                                    // Provinzen des Landes abfragen
                                    string query2 = @$"
                                        SELECT 
                                            province.Name, 
                                            province.Capital, 
                                            province.Population 
                                        FROM 
                                            mondial.province 
                                        WHERE 
                                            province.country = '{inp}';
                                    ";

                                    using (MySqlCommand provinceCommand = new MySqlCommand(query2, connection))
                                    {
                                        using (MySqlDataReader provinceReader = provinceCommand.ExecuteReader())
                                        {
                                            while (provinceReader.Read())
                                            {
                                                string provinceName = provinceReader.GetString("Name");
                                                string provinceCapital = provinceReader.GetString("Capital");
                                                int population = provinceReader.GetInt32("Population");

                                                // Erstellen eines neuen Province-Objekts und Hinzufügen zum Land
                                                Province province = new Province(population, provinceCapital, provinceName);
                                                country.AddProvince(province);
                                            }
                                        }
                                    }

                                    // Gesamtbevölkerung und Provinzen anzeigen
                                    Console.WriteLine($"Total Population: {country.GetTotalPopulation()}");
                                    country.DisplayProvinces();
                                    Console.WriteLine();
                                }
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
}*/
//unvollständig wird gefixed