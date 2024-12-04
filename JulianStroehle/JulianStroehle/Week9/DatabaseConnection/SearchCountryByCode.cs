using System;
using MySql.Data.MySqlClient;
namespace JulianStroehle.Week9
{
    internal class SearchCountryByCode
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
                    string query =  "SELECT * FROM country WHERE Code LIKE @code";
                    Console.WriteLine("Country Code: ");
                    string input = Console.ReadLine();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@code", input + "%");
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        bool wrote = false;
                        int count = 1;
                        Console.Write("┌" + new string('─', 6) + "┬" + new string('─', 30) + "┬" + new string('─', 15) + "┬" + new string('─', 15) + "┐");
                        Console.WriteLine("\n│" + string.Format("{0,-6}", "  Nr. ") + "│" + string.Format("{0,-38}", "  " + $"\x1b[3m{"Name"}\x1b[0m") + "│" + string.Format("{0,-23}", "  " + $"\x1b[4m{"Code"}\x1b[0m") + "│" + string.Format("{0,-23}", "  " + $"\x1b[3m{"Population"}\x1b[0m") + "│");
                        Console.Write("├" + new string('─', 6) + "┼" + new string('─', 30) + "┼" + new string('─', 15) + "┼" + new string('─', 15) + "┤");
                        while (rdr.Read())
                        {
                            Console.WriteLine("\n│" + string.Format("{0,6}", count + "  ") + "│" + string.Format("{0,-30}", "  " + rdr.GetString("Name")) + "│" + string.Format("{0,-15}", "  " + rdr.GetString("Code")) + "│" + string.Format("{0,13}", rdr.GetInt32("Population")) + "  │");
                            wrote = true;
                            Console.Write("├" + new string('─', 6) + "┼" + new string('─', 30) + "┼" + new string('─', 15) + "┼" + new string('─', 15) + "┤");
                            count++;
                        }
                        Console.WriteLine("\r└" + new string('─', 6) + "┴" + new string('─', 30) + "┴" + new string('─', 15) + "┴" + new string('─', 15) + "┘");
                        if (!wrote)
                        {
                            Console.WriteLine("Error, no country matches your input");
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