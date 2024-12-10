// get MySQL Package: dotnet add package MySql.Data --version 9.1.0

using System;
using MySql.Data.MySqlClient;


namespace LucasSchiemann.Week10;


    public class MysqlConnectExample
    {

        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=.L|mbcid31208.;
            database=mondial
            ";

            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    string query = "SELECT * FROM country WHERE code like @code;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@code", "A%");

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString("name") + reader.GetString("country.population"));
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
