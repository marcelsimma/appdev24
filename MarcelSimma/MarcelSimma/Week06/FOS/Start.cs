
using System.Diagnostics.Contracts;
using System.Net.NetworkInformation;

namespace MarcelSimma.Week06.FOS
{

    /*

    Fotoapparat : Hardware
    Die Klasse Fotoapparat erweitert die Klasse Hardware
    Die Klasse Fotoapparat erbt von der Klasse Hardware
    Alle Attribute und Methoden aus der Klasse Hardware sind automatisch in der Klasse Fotoapparat auch verfügbar
    
    */

    public class Start
    {

        public static void Launch()
        {

            Speicherkarte s1 = new Speicherkarte("Toshiba 500 gb", "BDSDFE1234", 500);
            Fotoapparat f1 = new Fotoapparat("Sony Megapixel", "ASDF1234", s1);

            int[] intArray = new int[2];
            Fotoapparat[] fotoArray = new Fotoapparat[2];
            fotoArray[0] = f1;

            

            //System.Console.WriteLine(f1.Seriennummer);
            System.Console.WriteLine(f1.Seriennummer);

            System.Console.WriteLine(f1.Speicher.Speicherplatz);
            s1.Speicherplatz = 1000;
            System.Console.WriteLine(f1.Speicher.Speicherplatz);

            int a = 5, b = 7;
            int c = add(a, b);
            System.Console.WriteLine(c);
            a = 50;
            System.Console.WriteLine(c);

            // Ziel: Eine Liste mit allen Inventargegenständen
            // liste[0] = f1;
            // liste[1] = s1;

            IGegenstand[] inventarliste = new IGegenstand[2];

            inventarliste[0] = f1;
            inventarliste[1] = s1;

            foreach(IGegenstand gegenstand in inventarliste) {
                System.Console.WriteLine(gegenstand.PrintInventarnummer());
            }

        }



        public static int add(int a, int b)
        {
            return a + b;
        }
    }
}