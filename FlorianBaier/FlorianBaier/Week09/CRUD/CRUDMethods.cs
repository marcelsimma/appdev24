using System;
using MySql.Data.MySqlClient;

namespace FlorianBaier.Week09
{
    public class CRUDMethods
    {
        static string DBCS = "C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt";

        static MySqlConnection Connection = new MySqlConnection(DBCS);
        public static void Create()
        {
            Console.WriteLine("Which language would you like to add?");
            string Name = Console.ReadLine();
            Console.WriteLine("Which country does this language belong to? (countrycode)");
            string Country = Console.ReadLine();
            Console.WriteLine("What percentage of the population speaks this language?");
            string Percentage = Console.ReadLine();


            string Query = @"
            INSERT INTO languages (Country, Name, Percentage)
            VALUES (@Country, @Name, @Percentage);";

            MySqlCommand command = new MySqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Percentage", Percentage);

            int NewRows = command.ExecuteNonQuery();
            if (NewRows > 0)
            {
                Console.WriteLine($"The language {Name} was added successfully!");
            }
            else
            {
                Console.WriteLine("The language could not be added!");
            }
        }
        public static void Read()
        {
            Console.WriteLine("Which language do you want to search for?");
            string Name = Console.ReadLine();
            Console.WriteLine("Which country does this language belong to? (countrycode)");
            string Country = Console.ReadLine();

            string Query = @"SELECT * FROM language WHERE country = @Country AND name = @name";

            MySqlCommand command = new MySqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Name", Name);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($" {reader.GetString("country")} | {reader.GetString("name")} | {reader.GetFloat("percentage")}");
                }
            }
        }
        public static void Update()
        {
            Console.WriteLine("Which language do you want to edit?");
            string Name = Console.ReadLine();
            Console.WriteLine("Which country does this language belong to? (countrycode)");
            string Country = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("What would you like to edit about the language?? Country, Language or Percent?");
                string request = Console.ReadLine().ToLower();

                if (request == "country")
                {
                    Console.WriteLine("What is the new countrycode?");
                    string newCountry = Console.ReadLine();

                    string QueryOne = "UPDATE language SET country = @country WHERE country = @Country AND name = @Name";

                    MySqlCommand command = new MySqlCommand(QueryOne, Connection);
                    command.Parameters.AddWithValue("@country", newCountry);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@Name", Name);
                    int NewRows = command.ExecuteNonQuery();
                    if (NewRows > 0)
                    {
                        Console.WriteLine($"The language has been successfully revised!");
                    }
                    else
                    {
                        Console.WriteLine("The language could not be revised!");
                    }
                }
                if (request == "language")
                {
                    Console.WriteLine("What is the new language name?");
                    string newName = Console.ReadLine();

                    string QueryTwo = "UPDATE language SET name = @name WHERE country = @Country AND name = @Name";

                    MySqlCommand command = new MySqlCommand(QueryTwo, Connection);
                    command.Parameters.AddWithValue("@name", newName);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@Name", Name);
                    int NewRows = command.ExecuteNonQuery();
                    if (NewRows > 0)
                    {
                        Console.WriteLine($"The language has been successfully revised!");
                    }
                    else
                    {
                        Console.WriteLine("The language could not be revised!");
                    }
                }
                if (request == "percent")
                {
                    Console.WriteLine("What is the new percentage??");
                    double newPercentage = Convert.ToDouble(Console.ReadLine());

                    string QueryTwo = "UPDATE language SET percentage = @percentage WHERE country = @Country AND name = @Name";

                    MySqlCommand command = new MySqlCommand(QueryTwo, Connection);
                    command.Parameters.AddWithValue("@percentage", newPercentage);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@Name", Name);
                    int NewRows = command.ExecuteNonQuery();
                    if (NewRows > 0)
                    {
                        Console.WriteLine($"The language has been successfully revised!");
                    }
                    else
                    {
                        Console.WriteLine("The language could not be revised!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter one of the 3 terms!");
                }

            }
        }
        public static void Delete()
        {
            Console.WriteLine("Which language do you want to delete?");
            string Name = Console.ReadLine();
            Console.WriteLine("Which country does this language belong to? (countrycode)");
            string Country = Console.ReadLine();

            string Query = @"
            DELETE FROM language
            WHERE country = @country AND name = @name";

            MySqlCommand command = new MySqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@country", Country);
            command.Parameters.AddWithValue("@name", Name);

            int NewRows = command.ExecuteNonQuery();
            if (NewRows > 0)
            {
                Console.WriteLine($"The language {Name} was successfully deleted!");
            }
            else
            {
                Console.WriteLine("The language could not be deleted!");
            }
        }
    }
}