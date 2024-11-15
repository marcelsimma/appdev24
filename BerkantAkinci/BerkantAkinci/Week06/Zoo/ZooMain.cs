using System;

namespace BerkantAkinci.Week06.Zoo
{

    class ZooMain
    {

        public static void Start()
        {
            Gehege gehege1 = new Gehege("Alpenwiese");
            Gehege gehege2 = new Gehege("Ried");
            Gehege gehege3 = new Gehege("Terrarium");

            Tier tier1 = new Tier("Rijska", "Kuh");
            Tier tier2 = new Tier("Garmond", "Storch");
            Tier tier3 = new Tier("Hugo", "Storch");
            Tier tier4 = new Tier("Idaxis", "Storch");

            List<Gehege> zooStruktur = [gehege1, gehege2, gehege3];
            List<Tier> tierNamen = [tier1, tier2, tier3, tier4];

            ZooName meinZoo = new ZooName("Tierparadies Mühlebach", 1864);

            System.Console.WriteLine($"|----Zoo: {meinZoo._Name}, gegründet {meinZoo._Gruendungsjahr}");

            foreach (Gehege gehegen in zooStruktur)
            {
                System.Console.WriteLine($"|    |----Gehege: {gehegen._Name}");

                if (gehegen == gehege1)
                {
                    System.Console.WriteLine($"|         |---- {tier1._Name}, {tier1._Gattung}");
                }

                if (gehegen == gehege2)
                {
                    System.Console.WriteLine($"|         |---- {tier2._Name}, {tier2._Gattung}");
                    System.Console.WriteLine($"|         |---- {tier3._Name}, {tier3._Gattung}");
                    System.Console.WriteLine($"|         |---- {tier4._Name}, {tier4._Gattung}");
                }

                if (gehegen == gehege3)
                {
                    System.Console.WriteLine($"|         |----(leer)");
                }
            }
        }
    }
}
