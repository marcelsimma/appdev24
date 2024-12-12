using System;
using System.Data.Common;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
namespace JulianStroehle.Week9
{
    internal class CRUD
    {
        static StreamReader str = new StreamReader("C:/Users/JUSR/Desktop/-/PW.txt");
        static string databaseConnectionString = $"server=localhost;userid=root;password={str.ReadLine()};database=mondial";
        static MySqlCommand cmd;
        static string query;
        internal static void Start()
        {
            using (MySqlConnection conn = new MySqlConnection(databaseConnectionString))
            {
                conn.Open();
                string input;
                do
                {
                    Console.WriteLine("Task? (insert = i, read = r, update = u, delete = d, exit = e)");
                    input = Console.ReadLine().ToLower();
                    conn.Close();
                    conn.Open();
                    switch (input)
                    {
                        case "i": InsertInto(conn); break;
                        case "r": Read(conn); break;
                        case "u": UpdateData(conn); break;
                        case "d": DeleteData(conn); break;
                        default: break;
                    }
                }
                while (input != "e");
            }
        }
        internal static void InsertInto(MySqlConnection conn)
        {
            Console.WriteLine("Values? (CountryCode, Name, Percentage)");
            string[] values = Console.ReadLine().Split(", ");
            query = $"INSERT INTO language VALUES ('{values[0]}', '{values[1]}', {float.Parse(values[2])})";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Inserted Values");
        }
        internal static void Read(MySqlConnection conn)
        {
            int count = 0;
            Console.WriteLine("Country Code:");
            string input = Console.ReadLine();
            query = $"SELECT * FROM language WHERE Country LIKE @country";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@country", input + "%");
            MySqlDataReader rdr = cmd.ExecuteReader();
            Console.Write("┌" + new string('─', 9) + "┬" + new string('─', 10) + "┬" + new string('─', 35) + "┬" + new string('─', 20) + "┐");
            Console.WriteLine("\n│" + string.Format("{0,-17}", $"\x1b[3m{"  Nr.  "}\x1b[0m") + "│" + string.Format("{0,-18}", "  " + $"\x1b[3m{"Country"}\x1b[0m") + "│" + string.Format("{0,-43}", "  " + $"\x1b[3m{"Name"}\x1b[0m") + "│" + string.Format("{0,-28}", "  " + $"\x1b[3m{"Percentage"}\x1b[0m") + "│");
            Console.Write("├" + new string('─', 9) + "┼" + new string('─', 10) + "┼" + new string('─', 35) + "┼" + new string('─', 20) + "┤");
            while (rdr.Read())
            {
                count++;
                float percentage = rdr.GetFloat("Percentage")/100;
                Console.Write("\n│" + string.Format("{0,-17}", "  " + $"\x1b[1m{count}\x1b[0m") + "│" + string.Format("{0,-18}", "  " + $"\x1b[1m{rdr.GetString("Country")}\x1b[0m") + "│" + string.Format("{0,-43}", "  " + $"\x1b[1m{rdr.GetString("Name")}\x1b[0m") + "│" + string.Format("{0,28}", $"\x1b[1m{percentage:P}\x1b[0m" + "        ") + "│");
                Console.Write("\n├" + new string('─', 9) + "┼" + new string('─', 10) + "┼" + new string('─', 35) + "┼" + new string('─', 20) + "┤");
            }
            Console.WriteLine("\r└" + new string('─', 9) + "┴" + new string('─', 10) + "┴" + new string('─', 35) + "┴" + new string('─', 20) + "┘");
        }
        internal static void UpdateData(MySqlConnection conn)
        {
            Console.WriteLine("Column to update? (Country, Name or Percentage)");
            string col = Console.ReadLine();
            Console.WriteLine("Code of Country where you want to update values?");
            string code = Console.ReadLine();
            Console.WriteLine("Value to Insert?");
            string val = Console.ReadLine();
            query = $"UPDATE language SET {col} = '{val}' WHERE Country = '{code}'";
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Updated Data");
        }
        internal static void DeleteData(MySqlConnection conn)
        {
            bool sure = false;
            Console.WriteLine("Code of Country to delete language from?");
            string country = Console.ReadLine();
            Console.WriteLine("are you sure? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes");
            {
                sure = true;
            }
            if (sure)
            {
                query = $"DELETE FROM language WHERE Country = '{country}'";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Deleted row Successfully.");
            }
        }
    }
}