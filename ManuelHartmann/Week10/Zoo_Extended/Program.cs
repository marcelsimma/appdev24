using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ManuelHartmann.Week10.Zoo_Extended
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Launch();
        }
        /*

        1. Grundannahmen definieren und Context abstecken
        Grundannahme: Highend Kamera wo Objektiv und Speicherkarte tauschbar sind. 

        2. Klassendiagramm erstellen mit allen Klassen(, Interfaces, Beziehungen, etc.)

        3. Klassen programmieren
        */



            //{ "7", () => CreateZooWithRelatedEntities(databaseConnectionString) }, // Neue Option

            //Console.WriteLine($"7. To create a Zoo with Keeper and Cage.");



        //public static void CreateZooWithRelatedEntities(string connectionString)
        //{
        //    Console.WriteLine("Geben Sie den Namen des Zoos ein:");
        //    string zooName = Console.ReadLine();

        //    Console.WriteLine("Geben Sie das Gründungsjahr des Zoos ein (YYYY-MM-DD):");
        //    if (!DateTime.TryParse(Console.ReadLine(), out DateTime foundationYear))
        //    {
        //        Console.WriteLine("Ungültiges Datum. Bitte im Format YYYY-MM-DD eingeben.");
        //        return;
        //    }

        //    Console.WriteLine("Geben Sie den Namen des Wärters ein:");
        //    string keeperName = Console.ReadLine();

        //    Console.WriteLine("Geben Sie den Namen des Geheges ein:");
        //    string cageName = Console.ReadLine();

        //    using (var connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        var transaction = connection.BeginTransaction();

        //        try
        //        {
        //            // Zoo einfügen
        //            string insertZooQuery = "INSERT INTO Zoo (Name, FoundationYear) VALUES (@Name, @FoundationYear);";
        //            var zooCommand = new MySqlCommand(insertZooQuery, connection, transaction);
        //            zooCommand.Parameters.AddWithValue("@Name", zooName);
        //            zooCommand.Parameters.AddWithValue("@FoundationYear", foundationYear);
        //            zooCommand.ExecuteNonQuery();
        //            int zooId = (int)zooCommand.LastInsertedId;

        //            // Wärter einfügen
        //            string insertKeeperQuery = "INSERT INTO Keeper (Name, ZooID) VALUES (@Name, @ZooID);";
        //            var keeperCommand = new MySqlCommand(insertKeeperQuery, connection, transaction);
        //            keeperCommand.Parameters.AddWithValue("@Name", keeperName);
        //            keeperCommand.Parameters.AddWithValue("@ZooID", zooId);
        //            keeperCommand.ExecuteNonQuery();
        //            int keeperId = (int)keeperCommand.LastInsertedId;

        //            // Gehege einfügen
        //            string insertCageQuery = "INSERT INTO Cage (Name, ZooID) VALUES (@Name, @ZooID);";
        //            var cageCommand = new MySqlCommand(insertCageQuery, connection, transaction);
        //            cageCommand.Parameters.AddWithValue("@Name", cageName);
        //            cageCommand.Parameters.AddWithValue("@ZooID", zooId);
        //            cageCommand.ExecuteNonQuery();
        //            int cageId = (int)cageCommand.LastInsertedId;

        //            // Transaktion abschließen
        //            transaction.Commit();
        //            Console.WriteLine($"Zoo '{zooName}' mit Wärter '{keeperName}' und Gehege '{cageName}' wurde erfolgreich erstellt!");
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            Console.WriteLine($"Fehler: {ex.Message}");
        //        }
        //    }
        //}


        public static void Launch()
        {
            Zoo zooSchoenbrunnen = new Zoo("ZF1111", "Schoenbrunnen", "1966");

            Keeper stefan = new Keeper("P1234", "Stefan");
            Keeper berkant = new Keeper("P3243", "Berkant");
            Keeper cheyenne = new Keeper("P1232", "Cheyenne");
            Cage deerCage = new Cage("C1234", "DeerCage", "Amazing!");
            Cage bunnyCage = new Cage("C9634", "BunnyCage", "Disgusting");
            Cage wolfCage = new Cage("C4235", "WolfCage", "Marvellous");
            Animal bunny = new Animal("A1234", "Gerhard", "Bunny");
            Animal deer = new Animal("A6344", "Rudolf", "Deer");
            Animal wolf = new Animal("A9763", "Heinrich", "Wolf");
            AnimalFood dryFood = new AnimalFood("AF1234", "DryFood", 5, "kg", 19.99);
            AnimalFood leavesFood = new AnimalFood("AF4523", "Leaves", 800, "g", 4.99);
            AnimalFood steakFood = new AnimalFood("AF7534", "Steak", 8, "kg", 44.99);

            Cage jungleCage = new Cage("C6347", "JungleCage", "tropical");
            Animal blackPanter = new Animal("A4356", "Bruno (KameraMann)", "Black-Panter");
            Animal orangUtan = new Animal("A8624", "Orlovice", "Orang Utan");
            Animal monkey = new Animal("A7345", "Friedolin", "Monkey");
            AnimalFood banana = new AnimalFood("A8764", "Banana", 30, "Stk.", 0.70);
            AnimalFood meatPatties = new AnimalFood("AF2454", "MeatPatties", 100, "Stk.", 2.19); 

            stefan.AddCage(wolfCage);
            berkant.AddCage(bunnyCage);
            cheyenne.AddCage(deerCage);
            stefan.AddCage(jungleCage);
            cheyenne.AddCage(jungleCage);

            deerCage.Animals.Add(deer);
            bunnyCage.Animals.Add(bunny);
            wolfCage.Animals.Add(wolf);
            jungleCage.Animals.Add(monkey);
            jungleCage.Animals.Add(blackPanter);
            jungleCage.Animals.Add(orangUtan);
            
            zooSchoenbrunnen.AddKeeper(stefan);
            zooSchoenbrunnen.AddKeeper(berkant);
            zooSchoenbrunnen.AddKeeper(cheyenne);

            zooSchoenbrunnen.AddCage(deerCage);
            zooSchoenbrunnen.AddCage(bunnyCage);
            zooSchoenbrunnen.AddCage(wolfCage);
            zooSchoenbrunnen.AddCage(jungleCage);

            deer.MenuCard.Add(leavesFood, 2);
            bunny.MenuCard.Add(dryFood, 3);
            wolf.MenuCard.Add(steakFood, 5);
            monkey.MenuCard.Add(banana, 3);
            blackPanter.MenuCard.Add(meatPatties, 8);
            orangUtan.MenuCard.Add(leavesFood, 4);

            zooSchoenbrunnen.FoodDemand.Add(dryFood, 3);
            zooSchoenbrunnen.FoodDemand.Add(leavesFood, 4);
            zooSchoenbrunnen.FoodDemand.Add(steakFood, 2);
            zooSchoenbrunnen.FoodDemand.Add(banana, 200);
            zooSchoenbrunnen.FoodDemand.Add(meatPatties, 1000);

            Console.WriteLine(zooSchoenbrunnen.ToString());
        }
    }
}
