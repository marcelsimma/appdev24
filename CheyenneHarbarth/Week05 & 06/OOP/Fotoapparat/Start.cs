using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{
    public class Start
    {
        public static void Launch()             //hier muss "static" stehen, ansonsten kannst du die Methoden von Program.cs aus nicht laufen lassen
        {
            Speicherkarte Memory1 = new Speicherkarte("Sony", "TB600", 1000, "GH5T98", 59.99);
            Objektiv Lense1 = new Objektiv("Sony", "Zoom6000", 80, 300, "J5ED55", 3999.99);

            FotoapparatAdvanced Nikon = new FotoapparatAdvanced("R10", "Canon", 24.2, Lense1, Memory1, "A7B0K41", 5499.99);
            Console.WriteLine(Nikon.ToString());

            Nikon.TakePhoto();
            Nikon.TakePhoto();

            Console.WriteLine(Nikon.MemoryCard);

            IObjekt[] Inventorylist = new IObjekt[3];                       //Da ein Interface wie ein Datentyp aggieren kann, kannst du damit auch Arrays erstellen
                                                                            //Dasselbe geht für Klassen
            Inventorylist[0] = Nikon;
            Inventorylist[1] = Memory1;
            Inventorylist[2] = Lense1;

            Console.WriteLine("Inventarnummer      |      Preis");
            Console.WriteLine("--------------------------------");

            foreach (IObjekt Element in Inventorylist)
            {
                Console.WriteLine($"{Element.Inventorynumber,-20}|{Element.Price,11:F2}");
            }
        }
    }
}