using MySql.Data.MySqlClient;

namespace JonasWehinger.JaMan
{
    public class Enclosure
    {
        private MySqlConnection _connection;
        public int EnclosureID;
        public string Name;
        public int ZooID;

        public Enclosure(MySqlConnection connection, string name)
        {
            _connection = connection;
        }

        public void LoadEnclosureByID(int enclosureID)
        {
            string query = "SELECT Name, ZooID FROM Enclosure WHERE EnclosureID = @enclosureID;";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@enclosureID", enclosureID);

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    EnclosureID = enclosureID;
                    Name = reader.GetString("Name");
                    ZooID = reader.GetInt32("ZooID");
                }
            }
        }

        public void CreateEnclosure(string name, int zooID)
        {
            string query = "INSERT INTO Enclosure (Name, ZooID) VALUES (@name, @zooID);";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@zooID", zooID);
            command.ExecuteNonQuery();
            EnclosureID = (int)command.LastInsertedId;
        }
    }
}
