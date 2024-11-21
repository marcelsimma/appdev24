using System;

namespace OliverBedogg.Week07
{

    public class PolymorphieMain
    {
        public static void Start()
        {
            // Polymorphie entspricht einer Gemeinsamkeit
            // Objekte vom Datentyp Buch und Elektronik sind beides Produkte,
            // weil sie von der Klasse Produkt erben
            Produkt produkt = new Produkt("Buch ohne Seiten", 10.5);
            Buch buch = new Buch("IT-Handbuch", 39.9, 1416);
            Elektronik iphone = new Elektronik("iPhone", 999, 3.4);

            List<Produkt> produkte = new List<Produkt>();
            produkte.Add(produkt);
            produkte.Add(buch); // Buch und Elektronik sind auch ein Produkt
            produkte.Add(iphone);

            foreach (Produkt prod in produkte)
            {
                Console.WriteLine("Produkte: {0} ist ein Buch {1}", prod._name, prod is Buch);

                if (prod is Elektronik elektronik)
                {
                    Console.WriteLine("Spannung: " + elektronik.spannung);
                }
            }

            // Eindeutigkeit der Objekte
            List<Buch> buecher = new List<Buch>();
            buecher.Add(buch);
            Buch buch2 = new Buch("Handbuch", 39.9, 1200);
            Console.WriteLine("Die Produkte-Liste beinhaltet buch: {0} {1}", buecher.Contains(buch));
            Console.WriteLine("Die Produkte-Liste beinhaltet buch2: {0} {1}", buecher.Contains(buch2));
        }
    }
}