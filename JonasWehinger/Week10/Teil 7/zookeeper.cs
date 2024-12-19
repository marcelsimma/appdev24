using MySql.Data.MySqlClient;

namespace JonasWehinger.JaMan
{
    public class Zookeeper
    {
        private MySqlConnection _connection;
        private string _name;
        public Zookeeper(MySqlConnection connection, string name)
        {
            _connection = connection;
            _name = name;
           
        }
    public void CreateZooKeeper()
    {
        string query = "INSERT INTO Zookeeper (Name) VALUES (@name);";
        var command = new MySqlCommand(query, _connection);
        command.Parameters.AddWithValue("@name", _name);
        command.ExecuteNonQuery();
    }
    }
}
