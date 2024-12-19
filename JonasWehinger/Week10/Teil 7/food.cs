using MySql.Data.MySqlClient;

namespace JonasWehinger.JaMan
{
    public class Food
    {
        private MySqlConnection _connection;
        private string _name;
        private string _unit;
        private decimal _unitPrice;
        private string _ean;
        public Food(MySqlConnection connection, string name, string unit, decimal unitPrice, string ean)
        {
            _connection = connection;
            _name = name;
            _unit = unit;
            _unitPrice = unitPrice;
            _ean = ean;

        }
        public void CreateFood()
        {
            string query = "INSERT INTO Food (Name, Unit, UnitPrice, EAN) VALUES (@name, @unit, @unitPrice, @ean);";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", _name);
            command.Parameters.AddWithValue("@unit", _unit);
            command.Parameters.AddWithValue("@unitPrice", _unitPrice);
            command.Parameters.AddWithValue("@ean", _ean);
            command.ExecuteNonQuery();
        }
    }
}
