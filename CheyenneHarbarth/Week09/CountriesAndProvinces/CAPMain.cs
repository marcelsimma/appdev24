using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week09.CountriesAndProvinces
{
    public class CAPMain
    {
        public static void Start()
        {
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=QRUP369_purq;
            database=mondial";

            Queue<string> CountryCodes = new Queue<string>();
            Console.WriteLine("Tippe die Länderkürzel ein, die du suchen möchtest! Wenn du fertig bist, tippe Stop!");

            while (true)
            {
                string Input = Console.ReadLine();
                
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        string QueryOne = @"
                        SELECT country.Code
                        FROM country
                        WHERE country.Code = @code";

                        MySqlCommand Command = new MySqlCommand(QueryOne, connection);
                        Command.Parameters.AddWithValue("@code", Input);
                        using (MySqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Input == "Stop")
                            {
                                WorkCodes(CountryCodes, Reader, Command, Input);
                                break;
                            }
                            else
                            {
                                if (Reader.HasRows)
                                {
                                        CountryCodes.Enqueue(Input);
                                }
                                else
                                {
                                    Console.Write("Das ist kein gültiges Länderkürzel! ");
                                }
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
        /* using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
        {
            string query = @"
                        ";
        } */
        public static void WorkCodes(Queue<string> CountryCodes, MySqlDataReader reader, MySqlCommand command, string input)
        {
            while (CountryCodes.Count > 0)
            {
                foreach (string cc in CountryCodes)
                {
                    while (reader.Read())
                    {
                        string QueryTwo = @"
                            SELECT country.Name AS CountryName, country.Capital AS CountryCapital, encompasses.Continent
                            FROM country
                            JOIN encompasses ON country.Code = encompasses.Country
                            WHERE country.Code = @code;

                            SELECT province.Name AS Provincename, province.Capital, province.Population
                            FROM province
                            WHERE province.Country = @code;

                            SELECT SUM(province.Population) AS Einwohnerzahl
                            FROM province
                            WHERE province.Country = @code;";

                        command.Parameters.AddWithValue("@code", CountryCodes);

                        Console.Write(new Country(reader.GetString("CountryName"), reader.GetString("CountryCapital"), reader.GetString("Continent")).ToString());
                        
                        string Province = reader.GetString("Provincename");

                        while(Province is not null)
                        {
                            //Objektname??.SearchAndAddProvinces();
                        }
                        

                        CountryCodes.Dequeue();
                    }
                }
            }
        }
    }
}