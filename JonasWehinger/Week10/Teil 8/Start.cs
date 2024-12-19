using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace JonasWehinger.ZooSimulation
{
    public class simulation
    {
       public static void Simulationstart()
        {
            var connectionString = @"
            server=127.0.0.1;
            uid=root;
            pwd=#Tuma4016!;
            database=zoo";

            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            var gehegeListe = LadeGehegeMitTieren(connection);
            var pflegerListe = new List<Pfleger>
            {
                new Pfleger(1, "Nico", "Qualle"),
                new Pfleger(2, "Lucas", "Hase")
            };

            foreach (var pfleger in pflegerListe)
                foreach (var gehege in gehegeListe)
                    pfleger.KuemmereDichUmGehege(gehege);

            foreach (var pfleger in pflegerListe)
                Console.WriteLine($"{pfleger.Name}'s Lieblingstier ist: {pfleger.Lieblingstier}");
        }

        static List<Gehege> LadeGehegeMitTieren(MySqlConnection conn)
        {
            var gehege = new List<Gehege>();
            using var cmd = new MySqlCommand("SELECT GehegeID, Name FROM Gehege");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                gehege.Add(new Gehege(reader.GetInt32(0), reader.GetString(1)));

            foreach (var g in gehege)
            {
                using var cmdTiere = new MySqlCommand("SELECT TierID, Name, Art FROM Tiere WHERE GehegeID = @id");
                cmdTiere.Parameters.AddWithValue("@id", g.GehegeID);
                using var readerTiere = cmdTiere.ExecuteReader();
                while (readerTiere.Read())
                    g.FuegeTierHinzu(new Tier(readerTiere.GetInt32(0), readerTiere.GetString(1), readerTiere.GetString(2)));
            }
            return gehege;
        }
    }
}
