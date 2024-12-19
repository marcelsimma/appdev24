using MySql.Data.MySqlClient;

namespace JonasWehinger.JaMan
{
    public class Zoo
    {
        private MySqlConnection _connection;
        private string _name;
        private int _foundingYear;
        public Zoo(MySqlConnection connection, string name, int foundingYear)
        {
            _connection = connection;
            _name = name;
            _foundingYear = foundingYear;
            
          
        }

        public void CreateZoo(){

            string query = "INSERT INTO Zoo (Name, FoundingYear) VALUES (@name, @foundingYear);";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", _name);
            command.Parameters.AddWithValue("@foundingYear", _foundingYear);
            command.ExecuteNonQuery();
        }
    }
}
