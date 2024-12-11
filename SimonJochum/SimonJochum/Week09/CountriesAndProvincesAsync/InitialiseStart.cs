using System;
using MySql.Data.MySqlClient;

namespace SimonJochum.Week09.CountriesAndProvincesAsync
{
    public class InitialiseStart
    {
        public static async Task StartAsync()
        {
            // Liest die Verbindungszeichenfolge asynchron aus einer Datei
            string connectionString = await ReadConnectionStringAsync("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt");

            // Kontrollvariable für die Benutzereingabe-Schleife
            bool isRunning = true;

            // Liste von Tasks für asynchrone Abfragen (momentan nicht verwendet, weil wir ProcessCountryAsync direkt starten)
            List<Task<Country2>> countryTasks = new List<Task<Country2>>();

            Console.WriteLine("Bitte gib ein Länderkürzel ein, oder tippe 'Stop' um die Ausgabe zu starten.");

            // Schleife läuft, bis der Benutzer "Stop" eingibt
            while (isRunning)
            {
                // Lese die Eingabe des Benutzers
                string input = Console.ReadLine();
                Console.WriteLine($"Eingabe: {input}");

                if (input.Equals("Stop", StringComparison.OrdinalIgnoreCase))
                {
                    // Beenden der Schleife bei "Stop"
                    isRunning = false;
                }
                else if (!string.IsNullOrWhiteSpace(input))
                {
                    // Wenn ein gültiges Kürzel eingegeben wurde, starte die Verarbeitung asynchron
                    Console.WriteLine($"Starte Abfrage für {input}...");
                    _ = ProcessCountryAsync(input, connectionString); // Starte ohne auf das Ergebnis zu warten, deswegen der '_', da wir auch mit dem Rückgabewert nichts anfangen wollen, da der Wert direkt in der Methode verarbeitet wird
                }
            }

            // Falls wir Tasks in countryTasks gesammelt hätten, warten wir hier auf alle
            Country2[] countries = await Task.WhenAll(countryTasks);

            // Verarbeite die Ergebnisse aus den abgeschlossenen Tasks (aktuell irrelevant, da ProcessCountryAsync direkt arbeitet)
            foreach (var country in countries)
            {
                if (country != null)
                {
                    Console.Write(country.ToString());
                    country.GetPopulation();
                    country.GetProvinces();
                    Console.WriteLine();
                }
            }
        }

        // Hilfsmethode: Verarbeitet ein Länderkürzel, indem es FetchCountryAsync aufruft
        private static async Task ProcessCountryAsync(string countryCode, string connectionString)
        {
            // Holt die Informationen für das angegebene Länderkürzel
            var country = await FetchCountryAsync(countryCode, connectionString);

            // Wenn ein gültiges Land zurückgegeben wurde, zeige die Daten
            if (country != null)
            {
                Console.Write(country.ToString());
                country.GetPopulation();
                country.GetProvinces();
                Console.WriteLine();
            }
            else
            {
                // Falls keine Daten gefunden wurden, informiere den Benutzer
                Console.WriteLine($"Keine Daten für {countryCode} gefunden.");
            }
        }

        // Liest die Verbindungszeichenfolge aus einer Datei asynchron
        private static async Task<string> ReadConnectionStringAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync(); // Asynchrone Dateilesung
            }
        }

        // Ruft die Informationen für ein Land aus der Datenbank ab
        private static async Task<Country2> FetchCountryAsync(string countryCode, string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Öffnet die Verbindung zur Datenbank asynchron
                    await connection.OpenAsync();

                    // Query für die Land-Daten
                    string countryQuery = @$"SELECT 
                                            Name, 
                                            Continent, 
                                            Capital 
                                        FROM 
                                            mondial.country
                                        JOIN
                                            encompasses
                                        ON
                                            country.code = encompasses.country
                                        WHERE 
                                            code = '{countryCode}';";

                    Country2 country = null;

                    // Führt die Land-Query aus
                    using (MySqlCommand command = new MySqlCommand(countryQuery, connection))
                    {
                        using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                        {
                            // Liest die Ergebnisse, falls vorhanden
                            if (await reader.ReadAsync())
                            {
                                // Erstellt ein neues Country2-Objekt mit den abgerufenen Daten
                                string name = reader.GetString("Name");
                                string continent = reader.GetString("Continent");
                                string capital = reader.GetString("Capital");
                                country = new Country2(name, capital, continent);
                            }
                        }
                    }

                    // Wenn das Land existiert, hole auch die Provinz-Daten
                    if (country != null)
                    {
                        string provinceQuery = @$"SELECT 
                                                Name, 
                                                Capital, 
                                                Population 
                                            FROM 
                                                mondial.province 
                                            WHERE 
                                                province.country = '{countryCode}';";

                        // Führt die Provinz-Query aus
                        using (MySqlCommand command = new MySqlCommand(provinceQuery, connection))
                        {
                            using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                            {
                                // Füge jede Provinz zum Land hinzu
                                while (await reader.ReadAsync())
                                {
                                    string name = reader.GetString("Name");
                                    string capital = reader.GetString("Capital");
                                    int population = reader.GetInt32("Population");
                                    Province2 province = new Province2(name, capital, population);
                                    country.AddProvinces(province);
                                }
                            }
                        }
                    }

                    // Rückgabe des Country2-Objekts (oder null, falls keine Daten gefunden wurden)
                    return country;
                }
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung für Datenbankfehler oder andere Ausnahmen
                Console.WriteLine($"Fehler bei der Abfrage für {countryCode}: {ex.Message}");
                return null;
            }
        }
    }
}