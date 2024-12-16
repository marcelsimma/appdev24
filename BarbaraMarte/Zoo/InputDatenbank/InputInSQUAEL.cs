using MySql.Data.MySqlClient;

namespace BarbaraMarte.Zoo.InputDatenbank
{
    class InputSQUALE
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
                        string query = @$" use zoo_database;
                        INSERT INTO zookeeper (keeper_id, keeper_firs_name, keeper_last_name)
                        VALUES(null,'Anna', 'Andersson');
                        ";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        int rows = command.ExecuteNonQuery();
                        int lastInsertedId = (int)command.LastInsertedId;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            };
        }
        public static void AddingZoo()
        {
            /*
                            */
        }
        public static void RemovingZoo()
        {
            /*
                            */
        }
        public static void AddingAnimal()
        {
            /*
            INSERT INTO animal(animal_id, animal_species, animal.animal_name, Enclosure_ID)
            VALUES (null, 'Clown Fish','Nemo',3);
            */
        }
        public static void UpdateAnimalWithId()
        {
            /*
            UPDATE animal SET Enclosure_ID = 2 WHERE Animal_Species = 'Fox';
            */
        }

        public static void RemovingAnimal()
        {
            /*
                            */
        }
        public static void AddingEnclosure()
        {
            /*
                            */
        }
        public static void RemovingEnclosure()
        {
            /*
                            */
        }
        public static void AddingZookeeper()
        {
            /*
            @$" use zoo_database;
                        INSERT INTO zookeeper (keeper_id, keeper_firs_name, keeper_last_name)
                        VALUES(null,' ', ' ');
                        ";
            */
        }
        public static void RemovingZookeeper()
        {
            /*
                            */
        }
        public static void AddingFood()
        {
            /*
                            */
        }
        public static void RemovingFood()
        {
            /*
                            */
        }

    }
}