using System;
using MySql.Data.MySqlClient;


namespace FlorianBaier.Week09
{

    class EUMember
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
                        connection.Open();
                        string query = @$"SELECT country.name, country.code, country.Population
                                            FROM country, ismember
                                            WHERE ismember.country = country.code
                                            AND ismember.Type = 'member'
                                            AND ismember.Organization LIKE 'EU';
                                        ";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        // command.Parameters.AddWithValue("@code", "A");   is for the placeholder
                        int count = 1;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.Write(reader.GetString("name") + " ");
                                Console.Write(reader.GetString("code") + " ");
                                Console.WriteLine(reader.GetUInt32("population") + " ");
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
