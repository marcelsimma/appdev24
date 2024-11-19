
using System.ComponentModel;

namespace MarcelSimma.Week06.FotoapparatErweitert 
{

    public class Start
    {


        /*

        1. Grundannahmen definieren und Context abstecken
        Grundannahme: Highend Kamera wo Objektiv und Speicherkarte tauschbar sind. 

        2. Klassendiagramm erstellen mit allen Klassen(, Interfaces, Beziehungen, etc.)

        3. Klassen programmieren
        */

        public static void Launch()
        {
            Speicherkarte memory2 = new Speicherkarte("SD Karte", "Samsung", 1000, "ABCD0001", 19.99);
            Objektiv lense2 = new Objektiv("Megaojektiv", "Canon", 50, 200, "ABCD002", 3000);

            Fotoapparat nicon = new Fotoapparat("Nicon 3000x", 30, "Nicon", memory2, lense2, "ABDE003", 2499.99);

            System.Console.WriteLine(nicon.ToString());

            nicon.TakePhoto();
            nicon.TakePhoto();

            System.Console.WriteLine(nicon.ToString());

            Console.WriteLine();
            Console.WriteLine(memory2.ToString());

            // Erklärung Call by Value
            /*
            int a = 5, b = 7;
            int c = add(a, b);
            System.Console.WriteLine(c);
            a += 10;
            System.Console.WriteLine(c);
            */

            IObjekt[] inventarliste = new IObjekt[3];

            inventarliste[0] = nicon;
            inventarliste[1] = memory2;
            inventarliste[2] = lense2;

            System.Console.WriteLine("Inventarnummer      Preis");

            foreach (IObjekt gegenstand in inventarliste) {
                System.Console.WriteLine($"{gegenstand.Inventorynumber, -20}  {gegenstand.Price, 8:F2}");
            }


        }

        public static int add(int a, int b) {
            return a + b;
        }
    }
}