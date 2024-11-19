using System;

namespace CheyenneHarbarth.Week05.OOP.Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo MeinZoo = new Zoo("Tierparadies Mühlebach", 1864);

            //Gehege erstellen
            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege eissee = new Gehege("Eissee");
            Gehege ried = new Gehege("Ried");
            Gehege nadelwald = new Gehege("Nadelwald");
            Gehege urwald = new Gehege("Urwald");

            MeinZoo.Gehegehinzufügen(alpenwiese);
            MeinZoo.Gehegehinzufügen(eissee);
            MeinZoo.Gehegehinzufügen(ried);
            MeinZoo.Gehegehinzufügen(nadelwald);
            MeinZoo.Gehegehinzufügen(urwald);

            //Gehege befüllen
            Tier tier1 = new Tier("Quitschi", "Murmeltier");
            Tier tier2 = new Tier("Screami", "Murmeltier");
            Tier tier3 = new Tier("Swaddle", "Pinguin");
            Tier tier4 = new Tier("Bambi", "Reh");
            Tier tier5 = new Tier("Herr Nilson", "Totenkopfaffe");

            alpenwiese.TierHinzufügen(tier1);
            alpenwiese.TierHinzufügen(tier2);
            eissee.TierHinzufügen(tier3);
            ried.TierHinzufügen(tier4);
            urwald.TierHinzufügen(tier5);


            MeinZoo.Zoodarstellen();

            Tier tier6 = new Tier("Kanzi", "Bonoboaffe");
            Tier tier7 = new Tier("Coco", "Totenkopfaffe");
            urwald.TierHinzufügen(tier6);
            urwald.TierHinzufügen(tier7);

            Gehege savanne = new Gehege("Savanne");
            MeinZoo.Gehegehinzufügen(savanne);
            Tier tier8 = new Tier("Simba", "Löwe");
            Tier tier9 = new Tier("Nala", "Löwe");
            savanne.TierHinzufügen(tier8);
            savanne.TierHinzufügen(tier9);

            MeinZoo.Zoodarstellen();

        }
    }
}