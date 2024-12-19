using MySql.Data.MySqlClient;


namespace MarcelSimma.Week10.Kompetenznachweis3
{

    public class CountriesAndRivers
    {

        private static string _code = "A";
        private static Dictionary<string, float> _rivers = new Dictionary<string, float>();

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=Abcd1234!;
            database=mondial
            ";

            float totalLength = 0;

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"
                        SELECT DISTINCT r.Name AS Name, r.Length AS Length FROM river r
                        INNER JOIN geo_river gr ON r.name = gr.river
                        WHERE gr.Country = @code
                        ORDER BY r.Length DESC;
                    ";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", _code);

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Resultate zum Dictionary hinzufügen
                           _rivers.Add(reader.GetString("Name"), reader.GetFloat("Length"));
                           totalLength += reader.GetFloat("Length");
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }

            // formatierte Ausgabe
            Console.WriteLine($"Flüsse in {_code}");

            Console.WriteLine(new string('-', 28));

            foreach (KeyValuePair<string, float> river in _rivers) {
                Console.WriteLine($"{river.Key, -15} {Math.Round(river.Value, 2), 9:F2} km");
            }

            Console.WriteLine(new string('-', 28));

            Console.WriteLine($"Gesamtlänge:    {Math.Round(totalLength, 2), 9:F2} km");
        }
    }
}