using System;

namespace BerkantAkinci.Week10
{
    public class ZooMain
    {
        public static void Start()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //HeadLine
            Zoo myZoo = new Zoo("Tierparadies Dornbirn", 1864);

            //Liste mit den Gehegen erstellen
            Enclosure Alpenwiese = new Enclosure("Alpenwiese");
            Enclosure Ried = new Enclosure("Ried");
            Enclosure Terrarium = new Enclosure("Terrarium");

            //Liste mit den Gehegen einfügen
            myZoo.AddEnclosure(Alpenwiese);
            myZoo.AddEnclosure(Ried);
            myZoo.AddEnclosure(Terrarium);

            //Liste mit Tieren erstellen
            Animal Rijska = new Animal("Rijska", "Kuh");
            Animal Garmond = new Animal("Garmond", "Storch");
            Animal Hugo = new Animal("Hugo", "Storch");
            Animal Idaxis = new Animal("Idaxis", "Storch");
            Animal Stefan = new Animal("Kalb", "Rind");

            //Liste mit Tieren einfügen
            Alpenwiese.AddAnimal(Rijska);
            Ried.AddAnimal(Garmond);
            Ried.AddAnimal(Hugo);
            Terrarium.AddAnimal(Idaxis);
            Terrarium.AddAnimal(Stefan);

            // Liste mit Tierfutter erstellen
            AnimalFood hay = new AnimalFood("Heu", "kg", 0.3);
            AnimalFood water = new AnimalFood("Wasser", "l", 0.5);
            AnimalFood straw = new AnimalFood("Stroh", "kg", 0.15);
            AnimalFood meat = new AnimalFood("Fleisch", "kg", 5.26);

            Rijska.AddFood(meat, 15);
            Rijska.AddFood(water, 20);
            Garmond.AddFood(straw, 15);
            Garmond.AddFood(water, 15);
            Hugo.AddFood(straw, 25);
            Hugo.AddFood(water, 25);
            Idaxis.AddFood(hay, 20);
            Idaxis.AddFood(water, 25);
            Stefan.AddFood(meat, 25);
            Stefan.AddFood(water, 40);


            // Liste mit Arbeitern erstellen
            ZooWorker stefan = new ZooWorker("Stefan", "05146");
            ZooWorker manuel = new ZooWorker("Manuel", "54856");
            ZooWorker cheyenne = new ZooWorker("Cheyenne", "78515");
            ZooWorker florian = new ZooWorker("Florian", "68541");

            Alpenwiese.AddWorker(stefan);
            Alpenwiese.AddWorker(manuel);
            Alpenwiese.AddWorker(cheyenne);
            Ried.AddWorker(florian);
            Ried.AddWorker(stefan);
            Terrarium.AddWorker(cheyenne);
            Terrarium.AddWorker(florian);
            Terrarium.AddWorker(manuel);


            //Struktur einfügen, wie es ausgeben soll
            myZoo.ZooStructure();

            //Entfernen von Gehege und Tier
            myZoo.RemoveEnclosure(Alpenwiese);
            Alpenwiese.RemoveAnimal(Rijska);

            //Erneute Ausgabe ohne die entfernten Sachen
            System.Console.WriteLine("\nAbbildung nach dem Entfernen vom Gehege:");
            myZoo.ZooStructure();
            System.Console.WriteLine();


            Rijska.PrintFood();
            Garmond.PrintFood();
            Hugo.PrintFood();
            Idaxis.PrintFood();
            Stefan.PrintFood();

            myZoo.PrintAll();




        }
    }
}