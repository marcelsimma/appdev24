using System;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week09.CRUD
{
    public class Init_Start
    {
        public static void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Was möchtest du machen?\n1. Datensatz erstellen\n2. Datensatz lesen\n3. Datensatz aktualisieren\n4. Datensatz löschen\n5. Programm beenden");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Welches Land möchtest du hinzufügen?");
                        string country = Console.ReadLine();
                        Console.WriteLine($"Welche Sprache wird in {country} gesprochen?");
                        string language = Console.ReadLine();
                        Console.WriteLine($"Wieviel Prozent sprechen {language} in {country}?");
                        double percentage = Convert.ToDouble(Console.ReadLine());
                        Create(country, language, percentage);
                        break;
                    case "2":
                        Console.WriteLine("Welches Land möchtest du anzeigen?");
                        string countryName = Console.ReadLine();
                        Read(countryName);
                        break;
                    case "3":
                        Console.WriteLine("Von welchem Land möchtest du den Eintrag aktualisieren?");
                        string updateCountry = Console.ReadLine();
                        Console.WriteLine($"Welche Sprache möchtest du von {updateCountry} aktualisieren?");
                        string updateLanguage = Console.ReadLine();
                        Console.WriteLine($"Wieviele Menschen (in %) sprechen {updateLanguage} in {updateCountry}?");
                        double updatePercentage = Convert.ToDouble(Console.ReadLine());
                        Update(updateCountry, updateLanguage, updatePercentage);
                        break;
                    case "4":
                        Console.WriteLine("Von welchem Land möchtest du einen Eintrag löschen?");
                        string nameDelete = Console.ReadLine();
                        Console.WriteLine($"Welche Sprache möchtest du von {nameDelete} löschen?");
                        string languageDelete = Console.ReadLine();
                        Delete(nameDelete, languageDelete);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Bitte gib eine gültige Operation ein");
                        break;
                }
            }
        }
        public static void Create(string country, string language, double percentage)
        {
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string countryCode = GetCountryCode(country);
                    string query = @$"INSERT INTO mondial.language VALUES ('{countryCode}', '{language}', {percentage});";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Eintrag wurde erfolgreich hinzugefügt." + countryCode + language + percentage);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }

        public static void Read(string countryName)
        {
            string connectionString = Connect();
            string countryCode = GetCountryCode(countryName);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"SELECT Name, Percentage FROM mondial.language WHERE Country = '{countryCode}';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string languageName = reader.GetString("Name");
                                int percentage = reader.GetInt32("Percentage");
                                Console.WriteLine("Das Land {0} mit dem Kürzel {1} spricht zu {2}% {3}.", countryName, countryCode, percentage, languageName);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }

        public static void Update(string countryName, string languageName, double percentage)
        {
            string connectionString = Connect();
            string countryCode = GetCountryCode(countryName);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"UPDATE mondial.language SET Percentage = {percentage} WHERE Name = '{languageName}' AND  Country = '{countryCode}';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Der Eintrag von {0} wurde aktualisiert.", countryName);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }

        public static void Delete(string countryName, string language)
        {
            string countryCode = GetCountryCode(countryName);
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung zur Datenbank hergestellt.");
                    string query = @$"DELETE FROM mondial.language WHERE Country = '{countryCode}' AND Name = '{language}';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Eintrag gelöscht.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
        }
        //DELETE FROM mondial.language WHERE Country = '{countryCode}' AND Name = '{language}';

        public static string GetCountryCode(string countryName)
        {
            string countryCode = "";
            string connectionString = Connect();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @$"SELECT Code FROM mondial.country WHERE Name = '{countryName}';";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                countryCode = reader.GetString("Code");
                            }
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
            }
            if (countryCode == "")
            {
                return $"Der Code zu {countryName} konnte nicht gefunden werden.";
            }
            else
            {
                return countryCode;
            }
        }

        public static string Connect()
        {
            string connectionString = "";
            using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
            {
                connectionString = str.ReadToEnd();
                return connectionString;
            }
        }
    }
}