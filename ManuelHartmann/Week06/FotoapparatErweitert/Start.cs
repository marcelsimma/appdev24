
namespace ManuelHartmann.Week06.FotoapparatErweitert
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
            int countObjects = 0;
            double sumPrices = 0;
            Speicherkarte memory2 = new Speicherkarte("SD Karte", "Samsung", 1000, "ABCD0001", 19.99, "Seriennummber_ABC");
            Objektiv lense2 = new Objektiv("Megaojektiv", "Canon", 50, 200, "ABCD002", 3000, "Seriennummber_SADF");

            Fotoapparat nicon = new Fotoapparat("Nicon 3000x", 30, "Nicon", memory2, lense2, "ABDE003", 2499.99, "Seriennummber_XYZ");

            Console.WriteLine(nicon.ToString());

            nicon.TakePhoto();
            nicon.TakePhoto();

            Console.WriteLine(nicon.ToString());

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

            Console.WriteLine(string.Format("{0, -15} | {1, -20}", "Inventarnummer", "Preis"));
            Console.WriteLine(new string('-', 30));

            foreach (IObjekt gegenstand in inventarliste)
            {
                countObjects++;
                sumPrices += gegenstand.Price;
                Console.WriteLine($"{gegenstand.Inventorynumber,-15} | {gegenstand.Price,-8:F2} EUR");
            }
            Console.WriteLine("Anzahl der Inventargegenstaenden:           " + countObjects);
            Console.WriteLine("Gesamtwert der Inventargegenstaenden: " + sumPrices + " EUR");
        }
        public static int add(int a, int b)
        {
            return a + b;
        }
    }
}
