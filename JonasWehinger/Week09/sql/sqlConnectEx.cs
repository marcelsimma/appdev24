// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System;
using System.Diagnostics.Metrics;
using MySql.Data.MySqlClient;


namespace JonasWehinger.Week09
{

    public class MysqlConnectExample
    {

        public static void Start()
        {
            
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            
            database=mondial
            ";

            
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    
                    string query = @"SELECT Organization , organization.name AS NameOfUnion, country.name,country.population
                                    FROM ismember,country, Organization
                                    WHERE isMember.organization = Organization.abbreviation
                                    AND Country.code = ismember.country
                                    AND Organization = 'EU' 
                                    AND Type = 'member'
                                    
                                    Order by Country.name;";

                    
                    MySqlCommand command = new MySqlCommand(query, connection);

                

                    
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int c = 0;
                        while (reader.Read())
                        {
                            
                            c++;
                            if(c <10)
                            {
                                Console.Write($"0{c}.{reader.GetString("Organization"),   -10}");
                            }
                            else 
                            {
                                Console.Write($"{c}.{reader.GetString("Organization"),   -10}");
                            }
                            Console.Write($"{reader.GetString("NameOfUnion"),   -10}");
                            Console.Write($"{reader.GetString("name"),   +20}");
                            Console.Write($"{reader.GetInt32("population"),   +10}");
                            Console.WriteLine();
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