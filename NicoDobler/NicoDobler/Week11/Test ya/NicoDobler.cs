
// get MySQL Package: dotnet add package MySql.Data --version 9.1.0

using System;
using MySql.Data.MySqlClient;


namespace NicoDobler.Week09
{

    public class NicoDobler
    {

        public static void Start()
        {
            // Verbindungsinformation
            string databaseConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Mald4122!;
            database=mondial
            ";

            // Erstellung der Verbindung zur Datenbank
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {

                    connection.Open();

                    // Datenbank Abfrage erstellen
                    string query = @"USE mondial;
SELECT DISTINCT river.name, river.length
FROM province
INNER JOIN country ON country.code = province.country
INNER JOIN geo_river ON geo_river.province = province.name AND geo_river.country = province.country
INNER JOIN river ON river.name = geo_river.river
AND country.code = @code
ORDER BY river.length desc;



";

                    // Befehl erstellen, der auf der Datenbank ausgeführt werden kann
                    MySqlCommand command = new MySqlCommand(query, connection);

                    Console.WriteLine("Länderkürzel: ");
                    string input = Console.ReadLine();
                    // Variablen austauschen
                    command.Parameters.AddWithValue("@code", input);

                    Dictionary<string, string> river = new Dictionary<string, string>();

                    // Resultate lesen
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        Console.Write(reader.GetString("code"));
                        Console.Write(" ");
                        

                        do
                        {
                            river.Add(reader.GetString("name"), reader.GetString("length"));
                        } while (reader.Read());

                        Console.WriteLine("Flüsse in A");
                        Console.WriteLine("-----------------------");

                        foreach (KeyValuePair<string, string> r in river)
                        {

                            Console.Write(" ");
                            Console.Write(r.Key);
                            Console.Write(" ");
                            Console.WriteLine(r.Value);
                        }

                        Console.WriteLine("...");
                        Console.WriteLine("-----------------------");
                    }

                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);

                }
            }

        }
    }
}
