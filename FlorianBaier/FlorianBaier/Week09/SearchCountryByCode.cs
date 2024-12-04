using MySql.Data.MySqlClient;

namespace FlorianBaier.Week09
{
    public class SearchCountryByCode
    {
        public static void Start()
        {
            using (StreamReader streamReader = new StreamReader("C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt"))
            {
                string databaseConnectionString = streamReader.ReadToEnd();

            }
        }
    }
}