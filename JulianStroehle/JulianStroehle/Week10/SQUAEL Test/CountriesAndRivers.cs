using System;
using MySql.Data.MySqlClient;
namespace JulianStroehle.Week10
{
    internal class CountriesAndRivers
    {
        static StreamReader _str = new StreamReader("C:/Users/JUSR/Desktop/-/PW.txt");
        static string _databaseConnectionString = $"server=localhost;userid=root;password={_str.ReadLine()};database=mondial";
        internal static void Start()
        {
            using (MySqlConnection conn = new MySqlConnection(_databaseConnectionString))
            {
                try
                {
                    do
                    {
                    conn.Open();
                    Console.WriteLine("Country code to search rivers with:");
                    string code = Console.ReadLine();
                    string query1 = "SELECT Name FROM country WHERE country.Code = @country";
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@country", code);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();
                    rdr1.Read();
                    Console.WriteLine("  Rivers in " + rdr1.GetString("Name") + "\n┌" + new string('─', 19) + "┬" + new string('─', 14) + "┐");
                    rdr1.Close();
                    string query = "SELECT DISTINCT river.Name AS River, river.Length AS Length FROM river JOIN geo_river ON river.Name = geo_river.River WHERE geo_river.Country = @code ORDER BY Length DESC;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@code", code);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    double length = 0;
                    while (rdr.Read())
                    {
                        length += rdr.GetDouble("Length");
                        Console.WriteLine(string.Format("{0,-20}", "│ " + rdr.GetString("River")) + "│" + string.Format("{0,15}", rdr.GetDouble("Length").ToString("F") + " km │"));
                    }
                    Console.WriteLine("└" + new string('─', 19) + "┴" + new string('─', 14) + "┘" + "\n" + string.Format("{0,-19}", "  Combined Length:") + string.Format("{0,14}", length.ToString("F") + " km"));
                    conn.Close();
                    Console.WriteLine("\nSearch again? (y/n)");
                    }
                    while (Console.ReadLine().ToLower() == "y");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}