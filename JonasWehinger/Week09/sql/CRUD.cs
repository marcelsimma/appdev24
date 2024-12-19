using System;
using MySql.Data.MySqlClient;
 
namespace JonasWehinger.Week09
{
    class CRUD
    {
        private const string ConnectionString = "Server=localhost;Database=language_data;Uid=root;Pwd=your_password;";
 
        public static void Start()
        {
           
                Console.WriteLine("\nWählen Sie eine Aktion aus:\n1. Create\n2. Read\n3. Update\n4. Delete\n5. Exit\nEingabe: ");
                var choice = Console.ReadLine();
 
                switch (choice)
                {
                    case "1":
                        CreateLanguage();
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
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        break;
                }
            }
       
 
        static void CreateLanguage()
        {
            Console.WriteLine("\n--- Neue Sprache erstellen ---");
            Console.Write("Name der Sprache: ");
            string name = Console.ReadLine();
 
            Console.Write("Beschreibung: ");
            string description = Console.ReadLine();
 
            Console.Write("Country Code (z. B. 'US'): ");
            string countryCode = Console.ReadLine();
 
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
 
               
                string countryCheckQuery = "SELECT COUNT(*) FROM countries WHERE code = @code;";
                MySqlCommand countryCmd = new MySqlCommand(countryCheckQuery, conn);
                countryCmd.Parameters.AddWithValue("@code", countryCode);
                int countryExists = Convert.ToInt32(countryCmd.ExecuteScalar());
 
                if (countryExists == 0)
                {
                    Console.WriteLine($"Fehler: Der Country Code '{countryCode}' ist ungültig.");
                    return;
                }
 
               
                string nameCheckQuery = "SELECT COUNT(*) FROM languages WHERE name = @name;";
                MySqlCommand nameCmd = new MySqlCommand(nameCheckQuery, conn);
                nameCmd.Parameters.AddWithValue("@name", name);
                int nameExists = Convert.ToInt32(nameCmd.ExecuteScalar());
 
                if (nameExists > 0)
                {
                    Console.WriteLine($"Fehler: Die Sprache '{name}' existiert bereits.");
                    return;
                }
 
               
                string insertQuery = "INSERT INTO languages (name, description, country_code) VALUES (@name, @description, @countryCode);";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@name", name);
                insertCmd.Parameters.AddWithValue("@description", description);
                insertCmd.Parameters.AddWithValue("@countryCode", countryCode);
                insertCmd.ExecuteNonQuery();
 
                Console.WriteLine("Sprache erfolgreich hinzugefügt.");
            }
        }
 
        static void ReadLanguage()
        {
            Console.WriteLine("\n  Sprache lesen  ");
            Console.Write("ID der Sprache: ");
            int id = int.Parse(Console.ReadLine());
 
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
 
                string query = "SELECT * FROM languages WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
 
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("ID: "+reader.GetString("id"));
                        Console.WriteLine("Name:" + reader.GetString("name"));
                        Console.WriteLine("Beschreibung:" + reader.GetString("Description"));
                        Console.WriteLine("country code:" + reader.GetString("country_code"));
                    }
                    else
                    {
                        Console.WriteLine($"Keine Sprache mit ID {id} gefunden.");
                    }
                }
            }
        }
 
        static void UpdateLanguage()
        {
            Console.WriteLine("\n  Sprache ändern  ");
            Console.Write("ID der Sprache: ");
            int id = int.Parse(Console.ReadLine());
 
            Console.Write("Neue Beschreibung: ");
            string newDescription = Console.ReadLine();
 
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
 
                string query = "UPDATE languages SET description = @description WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@description", newDescription);
                cmd.Parameters.AddWithValue("@id", id);
 
                int rowsAffected = cmd.ExecuteNonQuery();
 
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Beschreibung erfolgreich aktualisiert.");
                }
                else
                {
                    Console.WriteLine($"Keine Sprache mit ID {id} gefunden.");
                }
            }
        }
 
        static void DeleteLanguage()
        {
            Console.WriteLine("\n--- Sprache löschen ---");
            Console.Write("ID der Sprache: ");
            int id = int.Parse(Console.ReadLine());
 
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
 
                string query = "DELETE FROM languages WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
 
                int rowsAffected = cmd.ExecuteNonQuery();
 
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Sprache erfolgreich gelöscht.");
                }
                else
                {
                    Console.WriteLine($"Keine Sprache mit ID {id} gefunden.");
                }
            }
        }
    }
}