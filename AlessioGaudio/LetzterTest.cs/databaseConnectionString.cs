using System;
using MySql.Data.MySqlClient;

namespace AlessioGaudio.Week09
{
    public static class databaseConnectionString
    {
        public static MySqlConnection GetConnection()
        {
            string databaseConnectionString = @"
                server=127.0.0.1;
                uid=root;
                pwd=RamseS1234!;
                database=mondial;
            ";

            return new MySqlConnection(databaseConnectionString);
        }

        public static MySqlDataReader ExecuteQuery(string query)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            return command.ExecuteReader();
        }
    }
}
