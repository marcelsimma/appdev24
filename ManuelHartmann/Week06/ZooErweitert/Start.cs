namespace ManuelHartmann.Week06.ZooErweitert
{
    public class Program
    {
        /*

        1. Grundannahmen definieren und Context abstecken
        Grundannahme: Highend Kamera wo Objektiv und Speicherkarte tauschbar sind. 

        2. Klassendiagramm erstellen mit allen Klassen(, Interfaces, Beziehungen, etc.)

        3. Klassen programmieren
        */

        public static void Launch()
        {
            List<Gehege> gehegesOesterreich = new List<Gehege>();
            List<Tier> tierAlpenwiese = new List<Tier>();
            List<Tier> tierRied = new List<Tier>();
            List<Tier> tierTerrarium = new List<Tier>();
            List<Tier> tierSchoenbrunnen = new List<Tier>();

            Gehege gehegeAlpenwiese = new Gehege("Apenwiese", tierAlpenwiese);
            Gehege gehegeRied = new Gehege("Ried", tierRied);
            Gehege gehegeTerrarium = new Gehege("Terrarium (beheizt)", tierTerrarium);
            Gehege gehegeSchoenbrunnen = new Gehege("Schoenbrunnen", tierSchoenbrunnen);
            Zoo zooDornbirn = new Zoo("Tiergarten Dornbirn", "2022", gehegeAlpenwiese);
            Tier tier1 = new Tier("Alfons", "Kuh");
            Tier tier2 = new Tier("Peter", "Storch");
            Tier tier3 = new Tier("Hugo", "Storch");
            Tier tier4 = new Tier("Idaxis", "Storch");
            Tier tier5 = new Tier("Hannes", "Elefant");
            Tier tier6 = new Tier("Manuel", "Fuchs");
            Tier tier7 = new Tier("Leon", "Loewe");

            gehegesOesterreich.Add(gehegeAlpenwiese);
            gehegesOesterreich.Add(gehegeRied);
            gehegesOesterreich.Add(gehegeTerrarium);
            gehegesOesterreich.Add(gehegeSchoenbrunnen);

            tierAlpenwiese.Add(tier1);
            tierAlpenwiese.Add(tier5);
            tierRied.Add(tier2);
            tierRied.Add(tier3);
            tierRied.Add(tier4);
            tierSchoenbrunnen.Add(tier6);
            tierSchoenbrunnen.Add(tier7);


            Console.WriteLine(zooDornbirn);
            foreach (Gehege geheges in gehegesOesterreich)
            {
                Console.Write(geheges.ToString());
            }
            Console.WriteLine(new string('-', 32));
        }
    }
}
