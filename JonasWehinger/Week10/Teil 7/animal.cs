using MySql.Data.MySqlClient;

namespace JonasWehinger.JaMan
{
    public class Tier
    {
        private MySqlConnection _connection;
        public int AnimalID;
        public string Name;
        public string Species;

        public Tier(MySqlConnection connection, string name, string species)
        {
            _connection = connection;
         
        }

        public void LoadTierByID(int animalID)
        {
            string query = "SELECT Name, Species, AnimalID FROM animal WHERE AnimalID = @animalID;";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@animalID", animalID);

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    AnimalID = animalID;
                    Name = reader.GetString("Name");
                    Species = reader.GetString("Species");
                }
            }
        }

        public void CreateTier(string name, string species)
        {
            string query = "INSERT INTO animal (Name, Species) VALUES (@name, @species);";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@species", species);
            command.ExecuteNonQuery();
            AnimalID = (int)command.LastInsertedId;
        }
    }
}
