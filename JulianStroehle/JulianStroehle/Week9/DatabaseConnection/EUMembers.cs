using System;
using MySql.Data.MySqlClient;
namespace JulianStroehle.Week9
{
    internal class EUMembers
    {
        static StreamReader str = new StreamReader("C:/Users/JUSR/Desktop/-/PW.txt");
        static string databaseConnectionString = $"server=localhost;userid=root;password={str.ReadLine()};database=mondial";
        internal static void Start()
        {
            using (MySqlConnection conn = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    conn.Open();
                    string query =  "SELECT * FROM country JOIN ismember ON country.Code = ismember.Country WHERE ismember.Organization = 'EU'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Console.Write(rdr.GetString("Name") + " " + rdr.GetString("Code") + " " + rdr.GetInt32("Population"));
                            Console.WriteLine();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}