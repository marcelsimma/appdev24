// get MySQL Package: 'dotnet add package MySql.Data --version 9.1.0'

using System.ComponentModel;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;
using Org.BouncyCastle.Ocsp;

namespace ManuelHartmann.Week09.CountriesAndProvinces
{
    public class Start
    {
        public static Dictionary<Country, List<Province>> WorldData = new Dictionary<Country, List<Province>>();
        public static List<string> CountryCodes = new List<string>();
        static void Main(string[] args)
        {
            Country c = null;   // Braucht einen Platzhalter der mitgegeben wird.
            Launch();
            MySql(c);
            OutputWorld();
        }
        public static void Launch()
        {
            // UserInput -> LaenderCodes in Liste schreiben.
            Console.WriteLine("Please insert as many country-codes as you like!\n" +
                "Simply splitt them by 'space'.");
            string respond = Console.ReadLine();
            string[] tmpCode = respond.Split(' ');

            foreach (string code in tmpCode)
            {
                CountryCodes.Add(code.ToUpper());
            }
        }
        /* Zuerst wird der leere Platzhalter uebergeben und dann wird Country durchgefuehrt und 
           gibt das Ergebnis des Konstruktors an die Methode zurueck. */
        public static void MySql(Country country)
        {
            // Verbindungsinformation Datenbank
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=root;
            database=mondial
            ";


            foreach (string code in CountryCodes)
            {
                // Erstellung der Verbindung zur Datenbank
                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                        // Datenbank Abfrage erstellen
                        /* 'country' ist in diesem Fall das Linke im 'left-Join', wobei immer eine Ebene weiter nach Oben
                           gejoint wird. Mit ON wird dann die zu erfuellende Join-Bedinung abgefragt.                         */
                        string query = @"use mondial;
                                    SELECT country.Name, country.Capital, country.Population, encompasses.Continent
                                    FROM 
                                    -- Beziehung country und ismember
                                    country inner join encompasses ON country.Code = encompasses.Country
                                    -- Zusätzliche Filter
                                    WHERE country.Code = @platzhalter
                                    ORDER BY country.Code ASC;
                                    ";

                        // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // Variablen austauschen
                        command.Parameters.AddWithValue("@platzhalter", code);

                        // Resultate lesen
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tmpName = reader.GetString("Name");
                                string tmpContinent = reader.GetString("Continent");
                                string tmpCapital = reader.GetString("Capital");
                                int tmpPopultaion = (int)reader.GetInt64("Population");

                                country = new Country(tmpName, tmpContinent, tmpCapital, tmpPopultaion);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.Write(ex.Message);
                    }
                }

                // Erstellung der Verbindung zur Datenbank
                using (MySqlConnection connection1 = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection1.Open();

                        // Datenbank Abfrage erstellen
                        /* 'country' ist in diesem Fall das Linke im 'left-Join', wobei immer eine Ebene weiter nach Oben
                           gejoint wird. Mit ON wird dann die zu erfuellende Join-Bedinung abgefragt.                         */
                        string query1 = @"use mondial;
                                        SELECT province.Name, province.Capital, province.Population
                                        FROM
                                        -- Beziehung country und ismember
                                        country inner join province ON country.Code = province.Country
                                        -- Zusätzliche Filter
                                        WHERE country.Code = @platzhalter
                                        ORDER BY country.Code ASC;
                                        ";

                        // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                        MySqlCommand command1 = new MySqlCommand(query1, connection1);

                        // Variablen austauschen
                        command1.Parameters.AddWithValue("@platzhalter", code);

                        // Resultate lesen
                        using (MySqlDataReader reader1 = command1.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                string tmpName1 = reader1.GetString("Name");
                                string tmpCapital1 = reader1.GetString("Capital");
                                int tmpPopultaion1 = (int)reader1.GetInt64("Population");

                                Province province = new Province(tmpName1, tmpCapital1, tmpPopultaion1);
                                country.Provinces.Add(province);
                            }
                        }
                    }
                    catch (MySqlException ex1)
                    {
                        Console.Write(ex1.Message);
                    }
                }
                WorldData.Add(country, country.Provinces);
            }
        }
        private static void OutputWorld()
        {
            Console.Clear();
            foreach (var entry in WorldData)
            {
                Country country = entry.Key;
                List<Province> provinces = entry.Value;

                // Country ausgeben.
                Console.WriteLine(country.ToString());

                // Alle Province-Objekte fuers Country ausgeben.
                if (provinces.Count > 0)
                {
                    foreach (Province province in provinces)
                    {
                        Console.WriteLine(province.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("  - No provinces available.");
                }
                Console.WriteLine(new string('-', 40)); // Trenner für bessere Lesbarkeit
            }
        }
    }
}
