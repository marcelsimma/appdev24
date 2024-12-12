using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ZooManagement
{
    public class ZooManagementSystem
    {
        private const string ConnectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#!;
            database=zoo
        ";

        public static void Main(string[] args)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    InitDatabase(connection);
                    var zoos = ReadAllZoos(connection);
                    foreach (var zoo in zoos)
                    {
                        Console.WriteLine($"Zoo: {zoo.Name}, Gründungsjahr: {zoo.Gruendungsjahr}");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Datenbankfehler: " + ex.Message);
                }
            }
        }

        public static void InitDatabase(MySqlConnection connection)
{
   
    var zooId = CreateZoo(connection, "City Zoo", 1995);

    
    var gehege = CreateGehegeWithZoo(connection, zooId, "Savanne", "Regenwald");

   
    var tiere = CreateTiereInGehege(connection, gehege[0], 
        ("Löwe", "Panthera leo"), 
        ("Elefant", "Loxodonta africana"));

 
    var futter = CreateTierfutterMitBedarf(connection,
        (101, "Fleisch", "kg", 12.50m, tiere[0], 5.0m),
        (102, "Gras", "kg", 1.50m, tiere[1], 20.0m));

    
    var pflegerId = CreatePfleger(connection, "Max", "Großkatzen");
    LinkPflegerToGehege(connection, pflegerId, gehege[0]);
}


private static List<int> CreateGehegeWithZoo(MySqlConnection connection, int zooId, params string[] gehegeNames)
{
    var gehegeIds = new List<int>();
    foreach (var name in gehegeNames)
    {
        var gehegeId = CreateGehege(connection, name);
        LinkGehegeToZoo(connection, zooId, gehegeId);
        gehegeIds.Add(gehegeId);
    }
    return gehegeIds;
}

private static List<int> CreateTiereInGehege(MySqlConnection connection, int gehegeId, params (string Name, string Rasse)[] tiere)
{
    var tierIds = new List<int>();
    foreach (var (name, rasse) in tiere)
    {
        var tierId = CreateTier(connection, name, rasse);
        LinkTierToGehege(connection, gehegeId, tierId);
        tierIds.Add(tierId);
    }
    return tierIds;
}

private static List<int> CreateTierfutterMitBedarf(MySqlConnection connection, params (int FutterId, string Name, string Einheit, decimal Preis, int TierId, decimal Menge)[] futterData)
{
    foreach (var (futterId, name, einheit, preis, tierId, menge) in futterData)
    {
        CreateTierfutter(connection, futterId, name, einheit, preis);
        AddFutterbedarf(connection, tierId, futterId, menge);
    }
    return new List<int>(); 
}


        public static int CreateZoo(MySqlConnection connection, string name, int gruendungsjahr)
        {
            string query = "INSERT INTO Zoo (Name, Gruendungsjahr) VALUES (@name, @gruendungsjahr);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@gruendungsjahr", gruendungsjahr);
            command.ExecuteNonQuery();
            return (int)command.LastInsertedId;
        }

        public static int CreateGehege(MySqlConnection connection, string name)
        {
            string query = "INSERT INTO Gehege (Name) VALUES (@name);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
            return (int)command.LastInsertedId;
        }

        public static void LinkGehegeToZoo(MySqlConnection connection, int zooId, int gehegeId)
        {
            string query = "INSERT INTO Zoo_Gehege (ZooID, GehegeID) VALUES (@zooId, @gehegeId);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@zooId", zooId);
            command.Parameters.AddWithValue("@gehegeId", gehegeId);
            command.ExecuteNonQuery();
        }

        public static int CreateTier(MySqlConnection connection, string name, string rasse)
        {
            string query = "INSERT INTO Tiere (Name, Rasse) VALUES (@name, @rasse);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@rasse", rasse);
            command.ExecuteNonQuery();
            return (int)command.LastInsertedId;
        }

        public static void LinkTierToGehege(MySqlConnection connection, int gehegeId, int tierId)
        {
            string query = "INSERT INTO Gehege_Tier (GehegeID, TierID) VALUES (@gehegeId, @tierId);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@gehegeId", gehegeId);
            command.Parameters.AddWithValue("@tierId", tierId);
            command.ExecuteNonQuery();
        }

        public static void CreateTierfutter(MySqlConnection connection, int futterId, string name, string einheit, decimal preis)
        {
            string query = "INSERT INTO Tierfutter (FutterID, Name, Einheit, Preis) VALUES (@futterId, @name, @einheit, @preis);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@futterId", futterId);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@einheit", einheit);
            command.Parameters.AddWithValue("@preis", preis);
            command.ExecuteNonQuery();
        }

        public static void AddFutterbedarf(MySqlConnection connection, int tierId, int futterId, decimal menge)
        {
            string query = "INSERT INTO Futterbedarf (TierID, FutterID, Menge) VALUES (@tierId, @futterId, @menge);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@tierId", tierId);
            command.Parameters.AddWithValue("@futterId", futterId);
            command.Parameters.AddWithValue("@menge", menge);
            command.ExecuteNonQuery();
        }

        public static int CreatePfleger(MySqlConnection connection, string name, string arbeitsbereich)
        {
            string query = "INSERT INTO Pfleger (Name, Arbeitsbereich) VALUES (@name, @arbeitsbereich);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@arbeitsbereich", arbeitsbereich);
            command.ExecuteNonQuery();
            return (int)command.LastInsertedId;
        }

        public static void LinkPflegerToGehege(MySqlConnection connection, int pflegerId, int gehegeId)
        {
            string query = "INSERT INTO Pfleger_Gehege (PflegerID, GehegeID) VALUES (@pflegerId, @gehegeId);";
            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pflegerId", pflegerId);
            command.Parameters.AddWithValue("@gehegeId", gehegeId);
            command.ExecuteNonQuery();
        }

        public static List<(string Name, int Gruendungsjahr)> ReadAllZoos(MySqlConnection connection)
        {
            string query = "SELECT * FROM Zoo;";
            var command = new MySqlCommand(query, connection);
            var zoos = new List<(string, int)>();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    zoos.Add((reader.GetString("Name"), reader.GetInt32("Gruendungsjahr")));
                }
            }
            return zoos;
        }
    }
}
