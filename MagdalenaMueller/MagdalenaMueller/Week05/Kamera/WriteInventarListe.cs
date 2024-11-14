using System;

namespace MagdalenaMueller.Week05
{
    public class WriteInventarListe
    {
        public static void WriteInventarListeTabelle()
        {
            int logestProductname = 14;
            int logestInventarNumber = 15;
            int logestCosts = 6;

            Kamera k1 = new Kamera("H", "HI", 10, 500, "asdfg", 400);
            Speicherkarte s1 = new Speicherkarte(50, "abc1?", 20);
            Sitzkisse sk1 = new Sitzkisse("oiw523", 90);
            Tisch t1 = new Tisch("ke02.00", 120);
            Lampe l1 = new Lampe("092ka", 130);

            IGegenstand[] inventarListe = new IGegenstand[] { k1, s1, sk1, t1, l1 };
            int costsInventarListe = 0;

            for (int i = 0; i < inventarListe.Length; i++)
            {
                logestProductname = Math.Max(logestProductname, inventarListe[i].PrintInventarnummer().Length);
                logestInventarNumber = Math.Max(logestInventarNumber, inventarListe[i].inventarNumber.Length);
                logestCosts = Math.Max(logestCosts, inventarListe[i].costs.ToString().Length);
                costsInventarListe += inventarListe[i].costs;
            }

            Console.WriteLine("Produkt:".PadRight(logestProductname) + " | " + "Inventar Nummer:".PadRight(logestInventarNumber) + " | " + "Kosten:".PadRight(logestCosts));
            Console.WriteLine(new string('-', logestProductname + logestInventarNumber + logestCosts + 9));

            for (int i = 0; i < inventarListe.Length; i++)
            {
                Console.WriteLine(
                    inventarListe[i].PrintInventarnummer().PadRight(logestProductname) + " | " +
                    inventarListe[i].inventarNumber.PadRight(logestInventarNumber + 1) + " | " +
                    inventarListe[i].costs.ToString().PadRight(logestCosts)
                );
                Console.WriteLine(new string('-', logestProductname + logestInventarNumber + logestCosts + 9));
            }

            Console.WriteLine($"\nAnzahl der Inventargegenstände: {inventarListe.Length}");
            Console.WriteLine($"Gesamtwert der Inventargegenstände: {costsInventarListe}");
        }
    }
}