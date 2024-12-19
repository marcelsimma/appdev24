
using MySql.Data.MySqlClient;

namespace BarbaraMarte.Week09
{
    class EUMember
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
                        connection.Open();
                        string query = @$"
                        SELECT country.Code, country.name, Country.population 
                        FROM country, ismember
                        WHERE ismember.Country = Country.code
                        AND ismember.Type = 'member'
                        AND ismember.Organization LIKE 'EU'
                        ;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        // command.Parameters.AddWithValue("@code", "A");   is for the placeholder
                        int count = 1;
                        using (MySqlDataReader reader = command.ExecuteReader())        // command to insert data in the data bank ExecuteNonQuery
                        {
                            while (reader.Read())
                            {
                                Console.Write(reader.GetString("code") + "   ");
                                Console.Write(reader.GetString("name") + "   ");
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