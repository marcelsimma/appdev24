using System;

namespace BerkantAkinci.Week06.Zoo
{
    class Main
    {
        public static void Start()
        {
            //HeadLine
            ZooName meinZoo = new ZooName("Tierparadies Dornbirn", 1864);

            //Liste mit den Gehegen erstellen
            Gehege gehege1 = new Gehege("Alpenwiese");
            Gehege gehege2 = new Gehege("Ried");
            Gehege gehege3 = new Gehege("Terrarium");

            //Liste mit den Gehegen einfügen
            meinZoo.AddGehege(gehege1);
            meinZoo.AddGehege(gehege2);
            meinZoo.AddGehege(gehege3);

            //Liste mit Tieren erstellen
            Tier tier1 = new Tier("Rijska", "Kuh");
            Tier tier2 = new Tier("Garmond", "Storch");
            Tier tier3 = new Tier("Hugo", "Storch");
            Tier tier4 = new Tier("Idaxis", "Storch");

            //Liste mit Tieren einfügen
            gehege1.AddTier(tier1);
            gehege2.AddTier(tier2);
            gehege2.AddTier(tier3);
            gehege2.AddTier(tier4);

            //Struktur einfügen, wie es ausgeben soll
            meinZoo.ZooStruktur();

            //Entfernen von Gehege und Tier
            meinZoo.RemoveGehege(gehege1);
            gehege1.RemoveTier(tier1);

            //Erneute Ausgabe ohne die entfernten Sachen
            System.Console.WriteLine("\nAbbildung nach dem Entfernen vom Gehege:");
            meinZoo.ZooStruktur();
        }
    }
}
