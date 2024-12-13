using System;

namespace AlessioGaudio.Week09
{
    class Zoo2Main
    {
        public static void los()
        {
            Zoo2 zoo = new Zoo2("Tiergarten Dornbirn", 2022);

            Gehege2 gehege1 = new Gehege2("Alpenwiese");
            Gehege2 gehege2 = new Gehege2("Aquarium");
            Gehege2 gehege3 = new Gehege2("Terrarium");

            Tier2 tier1 = new Tier2("Rijska", "Kuh");
            Tier2 tier2 = new Tier2("Garmond", "Storh");
            Tier2 tier3 = new Tier2("Hugo", "Storch");
            Tier2 tier4 = new Tier2("lucy", "Katze");
            Tier2 tier5 = new Tier2("Johnny", "Katze");

            gehege1.TierHinzufuegen(tier1);
            gehege3.TierHinzufuegen(tier2);
            gehege3.TierHinzufuegen(tier3);
            gehege1.TierHinzufuegen(tier4);
            gehege1.TierHinzufuegen(tier5);
    
            zoo.GehegeHinzufuegen(gehege1);
            zoo.GehegeHinzufuegen(gehege2);
            zoo.GehegeHinzufuegen(gehege3);

           
            zoo.StrukturAusgeben();
        }
    }
}
