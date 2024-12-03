using System;
using System.Data;
using MySql.Data.MySqlClient;


// get MySQL Package: dotnet add package MySql.Data --version 9.1.0

namespace BarbaraMarte.Week09
{
    public class SearchCountryByCode
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
                        string query = "SELECT * FROM country WHERE code like @code;";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@code", "A");
                        int count = 1;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.Write(reader.GetString("name") + " ");
                                Console.Write(reader.GetString("code") + " ");
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