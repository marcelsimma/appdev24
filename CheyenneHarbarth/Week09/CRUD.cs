using System;
using MySql.Data.MySqlClient;

namespace CheyenneHarbarth.Week09.CountriesAndProvinces
{
    public class CountryCodes
    {
        static string DBCS = @"server=127.0.0.1; uid=root; pwd=Abcd1234!; database=mondial";

        static MySqlConnection Connection = new MySqlConnection(DBCS);
        public static void Start()
        {
            using (Connection)
            {
                try
                {
                    Connection.Open();
                    Console.WriteLine("Was möchtest du tun?\n 1 = neue Sprache hinzufügen\n 2 = Sprache suchen und ausgeben\n 3 = vorhandene Sprache bearbeiten\n 4 = vorhandene Sprache löschen");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Create();
                            break;

                        case 2:
                            Read();
                            break;

                        case 3:
                            Update();
                            break;

                        case 4:
                            Delete();
                            break;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
        public static void Create()
        {
            Console.WriteLine("Welche Sprache möchtest du hinzufügen?");
            string Name = Console.ReadLine();
            Console.WriteLine("Zu welchem Land gehört diese Sprache? (nur Kürzel)");
            string Country = Console.ReadLine();
            Console.WriteLine("Wieviel Prozent der Bevölkerung sprechen diese Sprache?");
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
                Console.WriteLine($"Die Sprache {Name} wurde erfolgreich hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Die Sprache konnte nicht hinzugefügt werden!");
            }
        }
        public static void Read()
        {
            Console.WriteLine("Welche Sprache möchtest du suchen?");
            string Name = Console.ReadLine();
            Console.WriteLine("Zu welchem Land gehört die Sprache? (nur Kürzel)");
            string Country = Console.ReadLine();

            string Query = @"SELECT * FROM language WHERE country = @Country AND name = @name";

            MySqlCommand command = new MySqlCommand(Query, Connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Name", Name);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($" {reader.GetString("country")} | {reader.GetString("name")} | {reader.GetFloat("Percentage")}");
                }
            }
        }
        public static void Update()
        {
            Console.WriteLine("Welche Sprache möchtest du bearbeiten?");
            string Name = Console.ReadLine();
            Console.WriteLine("Zu welchem Land gehört diese Sprache? (nur Kürzel)");
            string Country = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Was möchtest du an der Sprache bearbeiten? Land, Sprache oder Prozent?");
                string request = Console.ReadLine();

                if (request == "Land")
                {
                    Console.WriteLine("Wie lautet das neue Landeskürzel?");
                    string newCountry = Console.ReadLine();

                    string QueryOne = "UPDATE language SET country = @country WHERE country = @Country AND name = @Name";

                    MySqlCommand command = new MySqlCommand(QueryOne, Connection);
                    command.Parameters.AddWithValue("@country", newCountry);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@Name", Name);
                    int NewRows = command.ExecuteNonQuery();
                    if (NewRows > 0)
                    {
                        Console.WriteLine($"Die Sprache wurde erfolgreich überarbeitet!");
                    }
                    else
                    {
                        Console.WriteLine("Die Sprache konnte nicht überarbeitet werden!");
                    }
                }
                if (request == "Sprache")
                {
                    Console.WriteLine("Wie lautet der neue Sprachenname?");
                    string newName = Console.ReadLine();

                    string QueryTwo = "UPDATE language SET name = @name WHERE country = @Country AND name = @Name";

                    MySqlCommand command = new MySqlCommand(QueryTwo, Connection);
                    command.Parameters.AddWithValue("@name", newName);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@Name", Name);
                    int NewRows = command.ExecuteNonQuery();
                    if (NewRows > 0)
                    {
                        Console.WriteLine($"Die Sprache wurde erfolgreich überarbeitet!");
                    }
                    else
                    {
                        Console.WriteLine("Die Sprache konnte nicht überarbeitet werden!");
                    }
                }
                if (request == "Prozent")
                {
                    Console.WriteLine("Wie lautet die neue Prozentangabe?");
                    double newPercentage = Convert.ToDouble(Console.ReadLine());

                    string QueryTwo = "UPDATE language SET percentage = @percentage WHERE country = @Country AND name = @Name";

                    MySqlCommand command = new MySqlCommand(QueryTwo, Connection);
                    command.Parameters.AddWithValue("@percentage", newPercentage);
                    command.Parameters.AddWithValue("@Country", Country);
                    command.Parameters.AddWithValue("@Name", Name);
                    int NewRows = command.ExecuteNonQuery();
                    if (NewRows > 0)
                    {
                        Console.WriteLine($"Die Sprache wurde erfolgreich überarbeitet!");
                    }
                    else
                    {
                        Console.WriteLine("Die Sprache konnte nicht überarbeitet werden!");
                    }
                }
                else
                {
                    Console.WriteLine("Gib bitte einen der 3 Begriffe ein!");
                }

            }
        }
        public static void Delete()
        {
            Console.WriteLine("Welche Sprache möchtest du löschen?");
            string Name = Console.ReadLine();
            Console.WriteLine("Zu welchem Land gehört diese Sprache? (nur Kürzel)");
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
                Console.WriteLine($"Die Sprache {Name} wurde erfolgreich gelöscht!");
            }
            else
            {
                Console.WriteLine("Die Sprache konnte nicht gelöscht werden!");
            }
        }
    }
}