using System;
using MySql.Data.MySqlClient;

namespace NicoDobler.Week10
{
    public static class ZooSimulation
    {
        private const string ConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Mald4122!;
            database=Itapp1;
        ";

        public static void Start()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string input = "";

                    while (input.ToLower() != "e")
                    {
                        Console.WriteLine(@"
Bitte wählen Sie eine Option:
1 - Tiere und ihre Gehege
2 - Gehege und ihre Zoos
3 - Tierpfleger und ihre Zoos
4 - Tiernahrung
5 - Tiere und ihre Nahrung
6 - Starte die erweiterte Tagessimulation
E - Beenden");

                        Console.Write("\nIhre Auswahl: ");
                        input = Console.ReadLine()?.Trim();

                        if (input == "E")
                        {
                            Console.WriteLine("Programm beendet.");
                            break;
                        }

                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("\nTiere und ihre Gehege:");
                                DisplayResults(connection, @"
                                    SELECT DISTINCT
                                        a.AnimalID AS TierID,
                                        a.Name AS TierName,
                                        c.Name AS KaefigName
                                    FROM Animal a
                                    LEFT JOIN Cage c ON a.EnclosureID = c.EnclosureID;
                                ", ["TierID", "TierName", "KaefigName"]);
                                break;

                            case "2":
                                Console.WriteLine("\nGehege und ihre Zoos:");
                                DisplayResults(connection, @"
                                    SELECT DISTINCT
                                        c.EnclosureID AS GehegeID,
                                        c.Name AS GehegeName,
                                        z.Name AS ZooName
                                    FROM Cage c
                                    LEFT JOIN Zoo z ON c.ZooID = z.ZooID;
                                ", ["GehegeID", "GehegeName", "ZooName"]);
                                break;

                            case "3":
                                Console.WriteLine("\nTierpfleger und ihre Zoos:");
                                DisplayResults(connection, @"
                                    SELECT DISTINCT
                                        k.KeeperID AS PflegerID,
                                        k.Name AS PflegerName,
                                        z.Name AS ZooName
                                    FROM Keeper k
                                    LEFT JOIN Zoo z ON k.ZooID = z.ZooID;
                                ", ["PflegerID", "PflegerName", "ZooName"]);
                                break;

                            case "4":
                                Console.WriteLine("\nTiernahrung:");
                                DisplayResults(connection, @"
                                    SELECT DISTINCT
                                        f.FoodID AS NahrungID,
                                        f.Name AS NahrungName,
                                        f.Unit AS Einheit,
                                        f.UnitPrice AS PreisProEinheit,
                                        f.Amount AS Bestand
                                    FROM AnimalFood f;
                                ", ["NahrungID", "NahrungName", "Einheit", "PreisProEinheit", "Bestand"]);
                                break;

                            case "5":
                                Console.WriteLine("\nTiere und ihre Nahrung:");
                                DisplayResults(connection, @"
                                    SELECT DISTINCT
                                        a.Name AS TierName,
                                        f.Name AS NahrungName
                                    FROM AnimalEatsFood ef
                                    LEFT JOIN Animal a ON ef.AnimalID = a.AnimalID
                                    LEFT JOIN AnimalFood f ON ef.FoodID = f.FoodID;
                                ", ["TierName", "NahrungName"]);
                                break;

                            case "6":
                                Console.WriteLine("\nStarte die erweiterte Tagessimulation...\n");
                                Dictionary<int, List<int>> cageAnimals = LoadAnimalsByCage(connection);

                                foreach (var cage in cageAnimals)
                                {
                                    Console.WriteLine($"Gehege {cage.Key}:");
                                    SimulateCage(cage.Key, cage.Value, connection);
                                }
                                break;

                            default:
                                Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine gültige Option.");
                                break;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Datenbankfehler: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein Fehler ist aufgetreten: " + ex.Message);
                }
            }
        }

        private static void DisplayResults(MySqlConnection connection, string query, string[] columns)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                foreach (string column in columns)
                {
                    Console.Write($"{column,-20}");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', columns.Length * 20));

                while (reader.Read())
                {
                    foreach (string column in columns)
                    {
                        Console.Write($"{reader[column],-20}");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static Dictionary<int, List<int>> LoadAnimalsByCage(MySqlConnection connection)
        {
            string query = "SELECT AnimalID, EnclosureID FROM Animal WHERE Health > 0";
            Dictionary<int, List<int>> cageAnimals = new Dictionary<int, List<int>>();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int animalId = reader.GetInt32("AnimalID");
                        int enclosureId = reader.IsDBNull(reader.GetOrdinal("EnclosureID")) ? 0 : reader.GetInt32("EnclosureID");

                        if (!cageAnimals.ContainsKey(enclosureId))
                        {
                            cageAnimals[enclosureId] = new List<int>();
                        }
                        cageAnimals[enclosureId].Add(animalId);
                    }
                }
            }
            return cageAnimals;
        }

        private static void SimulateCage(int EnclosureID, List<int> animals, MySqlConnection connection)
        {
            Random random = new Random();
            HashSet<int> bittenAnimals = new HashSet<int>();

            foreach (int attackerId in animals)
            {
                if (random.Next(100) < 40)
                {
                    int victimId = animals[random.Next(animals.Count)];
                    if (attackerId != victimId && !bittenAnimals.Contains(victimId))
                    {
                        int biteStrength = GetAnimalAttribute(connection, attackerId, "Bite");
                        int victimHealth = GetAnimalAttribute(connection, victimId, "Health");

                        victimHealth -= biteStrength;
                        UpdateAnimalHealth(connection, victimId, Math.Max(0, victimHealth));

                        Console.WriteLine($"Tier {attackerId} hat Tier {victimId} gebissen! Schaden: {biteStrength}. Gesundheit von Tier {victimId}: {victimHealth}");
                        bittenAnimals.Add(victimId);
                    }
                }
                else 
                {
                    Console.WriteLine($"Tier {attackerId} hat nicht angegriffen.");
                }
            }

            RemoveDeadAnimals(EnclosureID, connection);
        }

        private static int GetAnimalAttribute(MySqlConnection connection, int animalId, string attribute)
        {
            string query = $"SELECT {attribute} FROM Animal WHERE AnimalID = @AnimalID";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AnimalID", animalId);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private static void UpdateAnimalHealth(MySqlConnection connection, int animalId, int newHealth)
        {
            string query = "UPDATE Animal SET Health = @Health WHERE AnimalID = @AnimalID";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Health", newHealth);
                command.Parameters.AddWithValue("@AnimalID", animalId);
                command.ExecuteNonQuery();
            }
        }

        private static void RemoveDeadAnimals(int EnclosureID, MySqlConnection connection)
        {
            string query = "DELETE FROM Animal WHERE Health = 0 AND EnclosureID = @EnclosureID";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EnclosureID", EnclosureID);
                int removed = command.ExecuteNonQuery();
                if (removed > 0)
                {
                    Console.WriteLine($"{removed} tote Tiere wurden aus Gehege {EnclosureID} entfernt.");
                }
            }
        }
    }
}
