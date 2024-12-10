using System;
using MySql.Data.MySqlClient;

namespace MagdalenaMueller.Week09
{
    public class CRUD
    {
        static bool checkedCode;

        static string input = "A";

        static List<string> datavalueslist = Datavalues.FillDataValues();

        static string databaseConnectionString = @"
                        server=127.0.0.1;
                        uid=root;
                        pwd=10GoldeneHunde;
                        database=mondial
                        ";
        public static void Start()
        {
            Read();
        }
        public static void Create(List<string> datavalues)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    for (int i = 0; i < datavalues.Count; i++)
                    {
                        string query = datavalues[i];
                        MySqlCommand command = new MySqlCommand(query, connection);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler Create: " + ex.Message);
            }
        }
        public static void Read()
        {
            if (CheckIfCodeIsValid(input) == true)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Ungültiger country code");
                            return;
                        }

                        string query = "SELECT * FROM language2 where country = @code";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@code", $"{input}");

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.Write(reader.GetString("country") + " ");
                                Console.Write(reader.GetString("name") + " ");
                                Console.WriteLine(reader.GetFloat("percentage"));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Fehler Read: " + ex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("Fehler Read: Ungültiger Länderkürzel");
            }
        }
        public static void Update(string columName, string wert, string primaryKey)
        {

        }
        public static void Delete()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    string query = @"delete from language2;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler Delete: " + ex.Message);
            }
        }

        public static bool CheckIfCodeIsValid(string input)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT COUNT(*) 
                        FROM language, country 
                        WHERE language.country = @code 
                        AND language.country = country.code;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", input);

                    int resultCount = Convert.ToInt32(command.ExecuteScalar());

                    if (resultCount > 0)
                    {
                        checkedCode = true;
                    }
                    else
                    {
                        checkedCode = false;
                    }
                }
            }
            catch (Exception ex)
            {
                checkedCode = false;
            }
            return checkedCode;
        }
    }
}