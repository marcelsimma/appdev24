using System;
using MySql.Data.MySqlClient;

namespace FlorianBaier.Week09
{
    public class CRUDChoice
    {
        static string DBCS = "C:/Users/flori/Desktop/DigitalCampus/MySqlZugang.txt";

        static MySqlConnection Connection = new MySqlConnection(DBCS);
        public static void Start()
        {
            using (Connection)
            {
                try
                {
                    Connection.Open();
                    Console.WriteLine("What do you want to do?\n 1 = add/create new language\n 2 = search and read language\n 3 = edit/update existing language\n 4 = delete existing language\n 5 = end program");
                    int input = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        switch (input)
                        {
                            case 1:
                                CRUDMethods.Create();
                                break;

                            case 2:
                                CRUDMethods.Read();
                                break;

                            case 3:
                                CRUDMethods.Update();
                                break;

                            case 4:
                                CRUDMethods.Delete();
                                break;
                            
                            case 5:
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}