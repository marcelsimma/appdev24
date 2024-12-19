using MySql.Data.MySqlClient;

namespace BarbaraMarte.Zoo.InputDatenbank
{
    class ZooMain
    {
        public static void Start()
        {
            using (StreamReader streamReader = new StreamReader("C:/AttendingList1/SqlId.txt"))
            {
                string databaseConnectionString = streamReader.ReadToEnd();

                using (MySqlConnection connection = new MySqlConnection(databaseConnectionString))
                {
                    try
                    {
                        connection.Open();

                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        internal static void CreateZookeeper(string keeper_firs_name, MySqlConnection connection)
        {
            string getZooName = @"SELECT ZooName
            FROM zoo;";

            MySqlCommand getZooNameCommand = new MySqlCommand(getZooName, connection);
            List<string> Zoo = new List<string>();

            using (MySqlDataReader reader = getZooNameCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Zoo.Add(reader.GetString("ZooName"));
                }
            }
            System.Console.WriteLine("In which zoo does the new zoo keeper work?");
            foreach (string zoo in Zoo)
            {
                System.Console.WriteLine(zoo);
            }
            string zooName = Console.ReadLine() ?? "";

            string getEnclosure = @"SELECT Enclosure_ID, ";
        }
    }
}