using MySql.Data.MySqlClient;

namespace BarbaraMarte.Zoo.Part7
{

    public class ZooStart
    {
        public void Start()
        {
            // init databaseConnection string
            string databaseConnectionString;
            using (StreamReader streamReader = new StreamReader("C:/AttendingList1/SqlId.txt"))
            {
                databaseConnectionString = streamReader.ReadToEnd();
            }

            CreateZoo.CreateDatabase(databaseConnectionString);

        }
    }
}