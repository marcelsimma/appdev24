using System;

namespace AlessioGaudio.MeinZoo3
{
    public static class Zoo3Main
    {
        public static void los()
        {
            var heu = new Futter("Heu", "kg", 2.00);
            var wasser = new Futter("Wasser", "L", 0.05);
            var fleisch = new Futter("Fleisch", "kg", 8.00);
            var obst = new Futter("Obst", "kg", 3.50);
            var gemuese = new Futter("Gemüse", "kg", 2.80);

            var tiger = new Tier3("Shere Khan", "Tiger");
            tiger.FutterbedarfHinzufuegen(fleisch, 5);
            tiger.FutterbedarfHinzufuegen(obst, 2);

            var elefant = new Tier3("Dumbo", "Elefant");
            elefant.FutterbedarfHinzufuegen(heu, 10);
            elefant.FutterbedarfHinzufuegen(wasser, 50);
            elefant.FutterbedarfHinzufuegen(gemuese, 5);

            var pinguin = new Tier3("Pingu", "Pinguin");
            pinguin.FutterbedarfHinzufuegen(fleisch, 2);
            pinguin.FutterbedarfHinzufuegen(wasser, 10);

            var gehege1 = new Gehege3("Dschungel");
            gehege1.TierHinzufuegen(tiger);

            var gehege2 = new Gehege3("Savanne");
            gehege2.TierHinzufuegen(elefant);

            var gehege3 = new Gehege3("Arktis");
            gehege3.TierHinzufuegen(pinguin);

            var zoo = new Zoo3("Tiergarten Dornbirn", 2022);
            zoo.GehegeHinzufuegen(gehege1);
            zoo.GehegeHinzufuegen(gehege2);
            zoo.GehegeHinzufuegen(gehege3);

            zoo.StrukturAusgeben();
            zoo.FutterbedarfBerechnen();
        }
    }
}
