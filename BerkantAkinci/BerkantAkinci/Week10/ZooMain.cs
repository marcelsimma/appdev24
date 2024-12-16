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
            Enclosure Mix = new Enclosure("Mix");

            //Liste mit den Gehegen einfügen
            myZoo.AddEnclosure(Alpenwiese);
            myZoo.AddEnclosure(Ried);
            myZoo.AddEnclosure(Terrarium);
            myZoo.AddEnclosure(Mix);

            //Liste mit Tieren erstellen
            Animal Nico = new Animal("Nico", "Kuh");
            Animal Jonas = new Animal("Jonas", "Storch");
            Animal Lucas = new Animal("Lucas", "Storch");
            Animal Alessio = new Animal("Alessio", "Storch");
            Animal Stefan = new Animal("Stefan", "Kalb");
            Animal Florian = new Animal("Florian", "Alpaka");
            Animal Julian = new Animal("Julian", "Bartvogel");
            Animal Manuel = new Animal("Manuel", "Bonobo");
            Animal Simon = new Animal("Simon", "Brillenbär");
            Animal Barbara = new Animal("Barbara", "Flusspferd");
            Animal Cheyenne = new Animal("Cheyenne", "Schwarze Witwe");
            Animal Berkant = new Animal("Berkant", "Bulldoggenameisen");

            //Liste mit Tieren einfügen
            Alpenwiese.AddAnimal(Nico);
            Alpenwiese.AddAnimal(Florian);
            Alpenwiese.AddAnimal(Simon);
            Ried.AddAnimal(Jonas);
            Ried.AddAnimal(Lucas);
            Ried.AddAnimal(Julian);
            Terrarium.AddAnimal(Alessio);
            Terrarium.AddAnimal(Stefan);
            Terrarium.AddAnimal(Manuel);
            Mix.AddAnimal(Barbara);
            Mix.AddAnimal(Cheyenne);
            Mix.AddAnimal(Berkant);

            // Liste mit Tierfutter erstellen
            AnimalFood hay = new AnimalFood("Heu", "kg", 0.3);
            AnimalFood water = new AnimalFood("Wasser", "l", 0.5);
            AnimalFood blood = new AnimalFood("Blut", "l", 0.54);
            AnimalFood straw = new AnimalFood("Stroh", "kg", 0.15);
            AnimalFood meat = new AnimalFood("Fleisch", "kg", 5.26);
            AnimalFood mud = new AnimalFood("Schlamm", "kg", 2.59);
            AnimalFood insect = new AnimalFood("Insekten", "stk", 0.62);
            AnimalFood leaf = new AnimalFood("Blatt", "stk", 0.0);

            Nico.AddFood(meat, 15);
            Nico.AddFood(water, 20);
            Jonas.AddFood(straw, 15);
            Jonas.AddFood(water, 15);
            Lucas.AddFood(straw, 25);
            Lucas.AddFood(water, 25);
            Alessio.AddFood(hay, 20);
            Alessio.AddFood(water, 25);
            Stefan.AddFood(meat, 25);
            Stefan.AddFood(water, 40);
            Florian.AddFood(meat, 40);
            Florian.AddFood(water, 60);
            Julian.AddFood(hay, 0.5);
            Julian.AddFood(water, 2);
            Manuel.AddFood(straw, 10);
            Manuel.AddFood(water, 15);
            Simon.AddFood(hay, 55);
            Simon.AddFood(water, 70);
            Barbara.AddFood(mud, 98);
            Barbara.AddFood(water, 150);
            Cheyenne.AddFood(insect, 12);
            Cheyenne.AddFood(blood, 0.89);
            Berkant.AddFood(leaf, 3);
            Berkant.AddFood(water, 0.6);
            

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
            Mix.AddWorker(florian);
            Mix.AddWorker(stefan);
            Mix.AddWorker(manuel);
            Mix.AddWorker(cheyenne);

            //Struktur einfügen, wie es ausgeben soll
            myZoo.ZooStructure();

            //Entfernen von Gehege und Tier
            myZoo.RemoveEnclosure(Alpenwiese);
            Alpenwiese.RemoveAnimal(Nico);

            //Erneute Ausgabe ohne die entfernten Sachen
            System.Console.WriteLine("\nAbbildung nach dem Entfernen vom Gehege:");
            myZoo.ZooStructure();
            System.Console.WriteLine();

            Florian.PrintFood();
            Julian.PrintFood();
            Manuel.PrintFood();
            Simon.PrintFood();
            Barbara.PrintFood();
            Cheyenne.PrintFood();
            Berkant.PrintFood();
            Nico.PrintFood();
            Jonas.PrintFood();
            Lucas.PrintFood();
            Alessio.PrintFood();
            Stefan.PrintFood();

            myZoo.PrintAll();




        }
    }
}