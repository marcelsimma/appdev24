using System;
using MySql.Data.MySqlClient;


namespace OliverBedogg.Week10
{
    public class Enclosure
    {
        private int _id { get; set; }
        public int id
        {
            get { return _id; }
        }
        private string _name { get; set; }
        public Enclosure(string name)
        {
            _name = name;
        }

        public void Create(MySqlConnection connection, int zooId)
        {
            string query = "INSERT INTO `enclosure` (`Name`, `ZooID`) VALUES (@name, @zooId);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", _name);
            command.Parameters.AddWithValue("@zooId", zooId);

            int rows = command.ExecuteNonQuery();

            if (rows > 0)
            {
                _id = (int)command.LastInsertedId;

                Console.WriteLine($"Gehege: Anzahl Datensätze hinzugefügt {rows} mit id {_id}");
            }
        }
    }
}