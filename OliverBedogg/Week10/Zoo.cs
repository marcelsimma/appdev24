using System;
using MySql.Data.MySqlClient;


namespace OliverBedogg.Week10
{
    public class Zoo
    {
        private int _id { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name { get; set; }
        public Zoo(string name)
        {
            _name = name;
        }

        public void Create(MySqlConnection connection)
        {
            string query = "INSERT INTO `zoo` (`Name`) VALUES (@name);";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", _name);

            int rows = command.ExecuteNonQuery();
            _id = (int)command.LastInsertedId;

            Console.WriteLine($"Zoo: Anzahl Datensätze hinzugefügt {rows} mit id {_id}");
        }

        public void ReadEnclosures(string databaseConnectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Enclosure WHERE ZooId = " + _id;
                    Console.WriteLine("- Gehege: " + query);
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader readerEnclosure = command.ExecuteReader())
                    {
                        while (readerEnclosure.Read())
                        {
                            string enclosureName = readerEnclosure.GetString("Name");
                            Enclosure enclosure = new Enclosure(enclosureName);

                            Console.WriteLine("- Gehege: " + enclosureName);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write("MySQLConnection Error: " + ex.Message);
                }
            }
        }
    }
}