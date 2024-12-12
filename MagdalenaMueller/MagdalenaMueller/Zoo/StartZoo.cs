using System;
using Org.BouncyCastle.Crypto.Engines;

namespace MagdalenaMueller.Zoo
{
    public class StartZoo
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Zoo1", "2024");
            //Food erstellen
            Food heu =  new Food("Heu", "kg", 3.50);
            Food trockenfutter = new Food("Trockenfutter", "kg", 5.00);
            Food fisch = new Food("Fisch", "stk", 2.00);
            Food ratte = new Food("Ratte", "stk", 7.00);
            Food fleisch = new Food("Fleisch", "kg", 8.50);

            //Animal erstellen
            Animal lisa = Animal.CreateAnimal("Lisa", "Hase", heu, 1);
            Animal rosa = Animal.CreateAnimal("Rosa", "Hase", heu, 1);
            Animal bob = Animal.CreateAnimal("Bob", "Hase", heu, 1.5);
            Animal rudolf = Animal.CreateAnimal("Rudolf", "Hase", heu, 0.5);

            Animal hans = Animal.CreateAnimal("Hans", "Löwe", fleisch, 5);
            Animal hildegard = Animal.CreateAnimal("Hildegard", "Löwe", fleisch, 3.5);

            Animal lucy = Animal.CreateAnimal("Lucy", "Katze", ratte, 1);
            Animal kathi = Animal.CreateAnimal("Kathi", "Katze", trockenfutter, 1.5);

            Animal roby = Animal.CreateAnimal("Roby", "Robbe", fisch, 22);
            Animal guenter = Animal.CreateAnimal("Günter", "Robbe", fisch, 40);

            //Cage erstellen
            Cage.AddCage("Wiese",zoo);
            Cage.AddCage("Raubkatzen Haus",zoo);
            Cage.AddCage("Robben Gehege",zoo);
            Cage.AddCage("Freilaufend",zoo);

            //Animals zu Cage hinzufügen
            Cage.AddAnimal("Wiese", lisa);
            Cage.AddAnimal("Wiese", rosa);
            Cage.AddAnimal("Wiese", bob);
            Cage.AddAnimal("Wiese", rudolf);

            Cage.AddAnimal("Raubkatzen Haus", hans);
            Cage.AddAnimal("Raubkatzen Haus", hildegard);

            Cage.AddAnimal("Robben Gehege", roby);
            Cage.AddAnimal("Robben Gehege", guenter);

            Cage.AddAnimal("Freilaufend", lucy);
            Cage.AddAnimal("Freilaufend", kathi);


            Zoo.WriteZoo(zoo);
            Zoo.WriteFoodRequirements();
        }
    }
}