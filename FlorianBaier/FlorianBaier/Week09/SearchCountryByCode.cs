using MySql.Data.MySqlClient;

namespace FlorianBaier.Week09
{
    public class SearchCountryByCode
    {
        public static void Start()
        {
            using (StreamReader streamReader = new StreamReader("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt"))
            {
                // string input = streamReader.ReadLine() ?? "";
                string databaseConnectionString = streamReader.ReadToEnd();

                {

                    while (true)
                    {
                        Console.WriteLine("Use the Countrycode to search for results");
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
                                        Console.Write($"Country: {reader.GetString("Countryname"),-15} | Population: {reader.GetInt32("CountryPopulation"),-15}\n");
                                        Console.WriteLine("\nProvince:       | Capital: ");
                                        Console.WriteLine("--------------------------------");
                                        foreach (KeyValuePair<string, string> pic in ProvincesInCountry)
                                        {
                                            Console.Write($"{pic.Key,-15} | {pic.Value,-15}\n");
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("No valid Countrycode!");
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
    }
}
