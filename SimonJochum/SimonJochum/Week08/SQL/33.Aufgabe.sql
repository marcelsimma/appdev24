--33. DELETE: Großbritannien hat die EU verlassen.
DELETE FROM ismember 
        WHERE 
            Country = 'GB' 
        AND 
            Organization = 'EU';

-- für C#
--  public static void DeleteGB()
--         {
--             using (StreamReader str = new StreamReader("C:/Users/SIJO/Documents/Testaufgaben/connectionstring.txt"))
--             {
--                 string connectionString = str.ReadToEnd();

--                 using (MySqlConnection connection = new MySqlConnection(connectionString))
--                 {
--                     try
--                     {
--                         connection.Open();
--                         Console.WriteLine("Connection established");

--                         string query = @"DELETE FROM ismember 
--                                         WHERE 
--                                             Country = 'GB' 
--                                         AND 
--                                             Organization = 'EU';";

--                         using (MySqlCommand command = new MySqlCommand(query, connection))
--                         {
--                             using (MySqlDataReader reader = command.ExecuteReader())
--                             {
--                                 while (reader.Read())
--                                 {
--                                 }
--                             }
--                         }
--                     }
--                     catch (MySqlException ex)
--                     {
--                         Console.WriteLine($"Fehler: {ex.Message}");
--                     }
--                 }
--             }
--         }
