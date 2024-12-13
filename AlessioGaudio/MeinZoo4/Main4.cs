using System;

namespace AlessioGaudio.MeinZoo4
{
    public static class Zoo4Main
    {
        public static void los()
        {
            var heu = new Futter4("Heu", "kg", 2.00);
            var wasser = new Futter4("Wasser", "L", 0.05);
            var fleisch = new Futter4("Fleisch", "kg", 8.00);
            var obst = new Futter4("Obst", "kg", 3.50);
            var gemuese = new Futter4("Gemüse", "kg", 2.80);

            var tiger = new Tier4("Shere Khan", "Tiger");
            tiger.FutterbedarfHinzufuegen(fleisch, 5);
            tiger.FutterbedarfHinzufuegen(obst, 2);

            var elefant = new Tier4("Dumbo", "Elefant");
            elefant.FutterbedarfHinzufuegen(heu, 10);
            elefant.FutterbedarfHinzufuegen(wasser, 50);
            elefant.FutterbedarfHinzufuegen(gemuese, 5);

            var pinguin = new Tier4("Pingu", "Pinguin");
            pinguin.FutterbedarfHinzufuegen(fleisch, 2);
            pinguin.FutterbedarfHinzufuegen(wasser, 10);

            var affe = new Tier4("King Louie", "Affe");
            affe.FutterbedarfHinzufuegen(obst, 6);
            affe.FutterbedarfHinzufuegen(gemuese, 3);

            var gehege1 = new Gehege4("Dschungel");
            gehege1.TierHinzufuegen(tiger);
            gehege1.TierHinzufuegen(affe);

            var gehege2 = new Gehege4("Savanne");
            gehege2.TierHinzufuegen(elefant);

            var gehege3 = new Gehege4("Arktis");
            gehege3.TierHinzufuegen(pinguin);

            var pfleger1 = new Pfleger("Anna");
            pfleger1.GehegeHinzufuegen(gehege1);

            var pfleger2 = new Pfleger("Ben");
            pfleger2.GehegeHinzufuegen(gehege2);
            pfleger2.GehegeHinzufuegen(gehege3);

            var zoo = new Zoo4("Tiergarten Dornbirn", 2022);
            zoo.GehegeHinzufuegen(gehege1);
            zoo.GehegeHinzufuegen(gehege2);
            zoo.GehegeHinzufuegen(gehege3);
            zoo.PflegerHinzufuegen(pfleger1);
            zoo.PflegerHinzufuegen(pfleger2);

            zoo.StrukturAusgeben();
            zoo.FutterbedarfBerechnen();
        }
    }
}
