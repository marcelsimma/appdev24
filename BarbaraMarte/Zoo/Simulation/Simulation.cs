using MySql.Data.MySqlClient;


namespace BarbaraMarte.Zoo.Simulation;

class Simulation
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

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    public static void WorkingSchedule()
    {

    }
}