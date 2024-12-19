using MySql.Data.MySqlClient;
using System.Reflection.PortableExecutable;

namespace ManuelHartmann.Week09.InsertUpdateDeleteCountry
{
    internal class Program
    {
        // --- Verbindungsinformation ---
        static string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=root;
            database=mondial
            ";
        static void Main(string[] args)
        {
            MenuCases();
        }
        public static void MenuCases()
        {
            string response = "";

            do
            {
                Console.Clear();
                BuildMenu();
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        InsertLanguage();
                        break;
                    case "2":
                        ReadLanguage();
                        break;
                    case "3":
                        UpdateLanguage();
                        break;
                    case "4":
                        DeleteLanguage();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option. Continue by pressing \"enter\".");
                        Console.ReadLine();
                        break;
                }

            } while (response != "exit");
        }
        public static void BuildMenu()
        {
            Console.WriteLine("1. To Creat a new Language.");
            Console.WriteLine("2. To Output specific information to your desired Language.");
            Console.WriteLine("3. To Update a desired language.");
            Console.WriteLine("4. To Delete a desired language");
            Console.WriteLine("Please choose an option by pressing 1, 2, 3, 4 or \"exit\".");
        }
                public static void InsertLanguage()
        {
            // --- UserInput ---
            string[] userInput;
            string respond;
            Console.WriteLine("Insert your desired Language with 'Country.Code', 'Language.Name' and ('Percent') you'd like to add:\n" +
                    "Simply split them by 'space'.");
            respond = Console.ReadLine();
            userInput = respond.Split(' ');
            int userNumber = 0;

            // --- User muss mindestens 'Country.Code' und 'Language.Name' uebergeben haben. ---
            if (userInput.Length < 2)
            {
                Console.WriteLine("Insufficient data provided. Please provide 'Country.Code', 'Language.Name', and ('Percentage').");
                Thread.Sleep(3000);
                return;
            }
            else
            {
                // --- Ueberpruefen, ob der Country.Code aus 1-4 Zeichen besteht. ---
                if (userInput[0].Length < 1 || userInput[0].Length > 4)
                {
                    Console.WriteLine("Invalid Country.Code! It must be between 1 and 4 characters.");
                    Thread.Sleep(3000);
                    return;
                }

                string checkCode = "";

                // --- Ueberpruefen, ob der Country.Code (PK) gueltig ist. (in Country vorkommt) ---
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // --- Datenbank Abfrage erstellen ---
                        string query = @"SELECT DISTINCT country.Code
                                    FROM country
                                    WHERE country.Code = @CountryCode;";

                        // --- Befehl erstellen, der auf der Datenbank ausgeführt werden kann. ---
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // --- Variablen austauschen. ---
                        command.Parameters.AddWithValue("@CountryCode", userInput[0]);

                        // --- Resultate lesen. ---
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // --- Fehler abfangen, wenn es noch kein LanguageCountry gibt. ---
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    checkCode = reader.GetString("Code");
                                }
                            }
                            else
                            {
                                // --- Kein Ergebnis gefunden. ---
                                Console.WriteLine("The specified LanguageName does not exist in the database.");
                                Thread.Sleep(3000);
                                //return; // Methode verlassen, falls der Wert nicht existiert
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error fetching provinces: {ex.Message}");
                    }
                }

                bool entryExists = false;

                // --- Ueberpruefen, ob der Language.Country im zusammenhang von Language.Name (PK) bereits verwendet wird. ---
                // --- Verbindung zur Datenbank erstellen ---
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // --- Kombinierte Abfrage, um zu prüfen, ob der Eintrag bereits existiert ---
                        string query = @"SELECT 1 
                         FROM language 
                         WHERE Country = @LanguageCountry 
                           AND Name = @LanguageName 
                         LIMIT 1;";

                        // --- Befehl erstellen ---
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@LanguageCountry", userInput[0]);
                        command.Parameters.AddWithValue("@LanguageName", userInput[1]);

                        // --- Prüfen, ob ein Ergebnis zurückkommt ---
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            entryExists = reader.HasRows;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Database error: {ex.Message}");
                        Thread.Sleep(4000);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                        Thread.Sleep(4000);
                    }
                }

                if (entryExists)
                {
                    Console.WriteLine("The specified Language entry already exists. Consider updating it instead.");
                    Thread.Sleep(4000);
                    return;
                }


                // --- Insert new Language! ---
                // --- Ueberpruefen, ob der LaenderCode existiert. ---
                if (userInput[0] == checkCode)
                {
                    // --- Erstellung der Verbindung zur Datenbank ---
                    using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            // --- Datenbank Abfrage erstellen ---
                            string query = @"insert into language
                                            SET Country = @LanguageCountry,
                                            Name = @LanguageName,
                                            Percentage = @LanguagePercentage;";

                            // --- Befehl erstellen, der auf der Datenbank ausgeführt werden kann ---
                            MySqlCommand command = new MySqlCommand(query, connection);

                            // --- SQL-Platzhalter austauschen ---
                            command.Parameters.AddWithValue("@LanguageCountry", userInput[0]);
                            command.Parameters.AddWithValue("@LanguageName", userInput[1]);
                            // --- Percentage soll befuellt werden, wenn auch ein gueltiger Wert dafuer mitgegeben wurde. ---
                            if (userInput.Length > 2 && int.TryParse(userInput[2], out userNumber))
                            {
                                command.Parameters.AddWithValue("@LanguagePercentage", userNumber);
                            }
                            else
                            {
                                // ---  NULL, wenn kein gültiger Wert ---
                                command.Parameters.AddWithValue("@LanguagePercentage", DBNull.Value);
                            }
                            // *** Hier ExecuteNonQuery einfügen ***
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Language inserted successfully!");
                            }
                            else
                            {
                                Console.WriteLine("No rows were affected. Please check your input.");
                            }
                            Thread.Sleep(3000);
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine($"Error fetching provinces: {ex.Message}");
                        }
                    }
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("The specified Country.Code or Language.Name does not exist in the database. Please check your input.");
                    Thread.Sleep(3000);
                }
            }
        }

        public static void ReadLanguage()
        {
            // --- UserInput ---
            string[] userInput;
            string respond;
            Console.WriteLine("Insert 'Language.Name': ");
            respond = Console.ReadLine();

            // --- Ueberpruefen, ob der Language.Name (PK) bereits verwendet wird. ---
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    // --- Datenbank Abfrage erstellen. ---
                    string query = @"SELECT *
                                    FROM language
                                    WHERE language.Name = @LanguageName;";

                    // --- Befehl erstellen, der auf der Datenbank ausgeführt werden kann. ---
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // --- Variablen austauschen. ---
                    command.Parameters.AddWithValue("@LanguageName", respond);

                    // --- Resultate lesen. ---
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                    }
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // --- Fehler abfangen, wenn es noch kein LanguageCountry gibt. ---
                        if (reader.HasRows)
                        {
                            Console.Clear();
                            // --- Überschrift ---
                            Console.WriteLine("{0,-14} | {1,-14} | {2,-8}",
                                                 "Country", "Name", "Percentage");
                            // --- Trenner ---
                            Console.WriteLine(new string('-', 45));

                            while (reader.Read())
                            {
                                Console.WriteLine("{0,-14} | {1,-14} | {2,-8}",
                                    reader.GetString("Country"),
                                    reader.GetString("Name"),
                                    reader.GetInt64("Percentage"));
                            }
                            // --- Lesemoeglichkeit ---
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            // --- Kein Ergebnis gefunden. ---
                            Console.WriteLine("There are no results found to your request.");
                            Thread.Sleep(3000);
                            return; // Methode verlassen, falls der Wert nicht existiert
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error fetching provinces: {ex.Message}");
                }
            }
        }

        public static void UpdateLanguage()
        {
            // --- UserInput ---
            string[] userInput;
            string respond;
            Console.WriteLine("Define your specific language by 'Country.Code', 'Language.Name':\n" +
                                "Simply split them by 'space'.");
            respond = Console.ReadLine();
            userInput = respond.Split(' ');


            string[] updateUserInput;
            string updateRespond;
            Console.WriteLine("Insert UPDATE-RESULT 'Country.Code', 'Language.Name' and 'Language.Procentage':\n" +
                                "Simply split them by 'space'.");
            updateRespond = Console.ReadLine();
            updateUserInput = updateRespond.Split(' ');
            int updateUserNumber = 0;

            // --- User muss mindestens 'Country.Code' und 'Language.Name' uebergeben haben. ---
            if (userInput.Length < 2 || updateUserInput.Length < 2)
            {
                Console.WriteLine("Insufficient data provided. Please provide 'Country.Code', 'Language.Name', and ('Percentage').");
                Thread.Sleep(3000);
                return;
            }
            else
            {
                // --- Ueberpruefen, ob der Country.Code aus 1-4 Zeichen besteht. ---
                if (userInput[0].Length < 1 || userInput[0].Length > 4)
                {
                    Console.WriteLine("Invalid Country.Code! It must be between 1 and 4 characters.");
                    Thread.Sleep(3000);
                    return;
                }

                string checkCode = "", checkName = "";


                // --- Ueberpruefen, ob der Country.Code (PK) gueltig ist. (in Country vorkommt) ---
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // --- Check if the original Country.Code and Language.Name exist ---
                        string query = @"SELECT DISTINCT language.Country, language.Name 
                             FROM language 
                             WHERE language.Country = @LanguageCountry AND language.Name = @LanguageName;
                             ";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@LanguageCountry", userInput[0]);
                        command.Parameters.AddWithValue("@LanguageName", userInput[1]);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // --- Fehler abfangen, wenn es noch kein LanguageCountry gibt. ---
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    checkCode = reader.GetString("Country");
                                    checkName = reader.GetString("Name");
                                }
                            }
                            else
                            {
                                //// --- Kein Ergebnis gefunden. ---
                                //Console.WriteLine("The specified LanguageName does not exist in the database.");
                                checkCode = "";
                                checkName = "";
                                //Thread.Sleep(3000);
                                //return; // Methode verlassen, falls der Wert nicht existiert
                            }
                        }

                        if (checkCode != userInput[0] || checkName != userInput[1])
                        {
                            Console.WriteLine("The specified combination of CountryCode and LanguageName does not exist in the database.");
                            Thread.Sleep(5000);
                            return;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Database error: {ex.Message}");
                        return;
                    }
                }
                // --- Ueberpruefen, ob der Language.Name (PK) bereits verwendet wird. ---
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // --- Datenbank Abfrage erstellen. ---
                        string query = @"SELECT DISTINCT language.Name
                                    FROM language
                                    WHERE language.Name = @LanguageName;
                                    ";

                        // --- Befehl erstellen, der auf der Datenbank ausgeführt werden kann. ---
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // --- Variablen austauschen. ---
                        command.Parameters.AddWithValue("@LanguageName", userInput[1]);

                        // --- Resultate lesen. ---
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // --- Fehler abfangen, wenn es noch kein LanguageCountry gibt. ---
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    checkName = reader.GetString("Name");
                                }
                            }
                            else
                            {
                                // --- Kein Ergebnis gefunden. ---
                                Console.WriteLine("The specified LanguageName does not exist in the database.");
                                checkName = "";
                                Thread.Sleep(3000);
                                //return; // Methode verlassen, falls der Wert nicht existiert
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error fetching provinces: {ex.Message}");
                    }
                }
                // --- Insert new Language! ---
                if (userInput[0] == checkCode && userInput[1] == checkName)
                {
                    // --- Erstellung der Verbindung zur Datenbank ---
                    using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                    {
                        try
                        {
                            connection.Open();

                            // --- Datenbank Abfrage erstellen ---
                            string query = @"update language
                                        SET language.Country = @UpdateLanguageCountry,
                                        language.Name = @UpdateLanguageName,
                                        Percentage = @UpdateLanguagePercentage
                                        WHERE language.Country = @LanguageCountry AND language.Name = @LanguageName;
                                        ";

                            // --- Befehl erstellen, der auf der Datenbank ausgeführt werden kann ---
                            MySqlCommand command = new MySqlCommand(query, connection);

                            // --- SQL-Platzhalter austauschen ---
                            command.Parameters.AddWithValue("@LanguageCountry", userInput[0]);
                            command.Parameters.AddWithValue("@LanguageName", userInput[1]);

                            // --- Update ---
                            command.Parameters.AddWithValue("@UpdateLanguageCountry", updateUserInput[0]);
                            command.Parameters.AddWithValue("@UpdateLanguageName", updateUserInput[1]);
                            // Percentage soll befuellt werden, wenn auch ein gueltiger Wert dafuer mitgegeben wurde.
                            if (updateUserInput.Length > 2 && int.TryParse(updateUserInput[2], out updateUserNumber))
                            {
                                command.Parameters.AddWithValue("@UpdateLanguagePercentage", updateUserNumber);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@UpdateLanguagePercentage", DBNull.Value); // NULL, wenn kein gültiger Wert
                            }
                            // *** Hier ExecuteNonQuery einfügen ***
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Language updated successfully!");
                            }
                            else
                            {
                                Console.WriteLine("No rows were affected. Please check your input.");
                            }
                            // --- Lesemoeglichkeit ---
                            Thread.Sleep(3000);
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine($"Error fetching provinces: {ex.Message}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Inserted Country.Code is not legit! Hope you're unable to reproduce yourself...");
                    Thread.Sleep(3000);
                }
            }
        }

        public static void DeleteLanguage()
        {
            // --- UserInput ---
            string[] userInput;
            string respond;
            Console.WriteLine("Insert Language 'Country.Code' and 'Language.Name' you'd like to delete:\n" +
                    "Simply split them by 'space'.");
            respond = Console.ReadLine();
            userInput = respond.Split(' ');

            // --- User muss mindestens 'Country.Code' und 'Language.Name' uebergeben haben. ---
            if (userInput.Length < 2)
            {
                Console.WriteLine("Insufficient data provided. Please provide 'Country.Code', 'Language.Name', and ('Percentage').");
                return;
            }
            else
            {
                // --- Erstellung der Verbindung zur Datenbank ---
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // --- Datenbank Abfrage erstellen ---
                        string query = @"DELETE FROM language
                                    WHERE language.Country = @LanguageCountry 
                                    AND language.Name = @LanguageName
                                    ";

                        // --- Befehl erstellen, der auf der Datenbank ausgeführt werden kann ---
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // --- SQL-Platzhalter austauschen ---
                        command.Parameters.AddWithValue("@LanguageCountry", userInput[0]);
                        command.Parameters.AddWithValue("@LanguageName", userInput[1]);

                        // *** Hier ExecuteNonQuery einfügen ***
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Language deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("No rows were affected. Please check your input.");
                        }
                        Thread.Sleep(3000);
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error fetching provinces: {ex.Message}");
                    }
                }
            }
        }
    }
}
