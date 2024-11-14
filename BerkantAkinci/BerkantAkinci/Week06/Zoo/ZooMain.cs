using System;

namespace BerkantAkinci.Week06.Zoo
{

    class ZooMain
    {

        public static void Start()
        {
            Gehege gehege1 = new Gehege("Wiese");
            Gehege gehege2 = new Gehege("Eisee");
            Gehege gehege3 = new Gehege("Ried");
            Gehege gehege4 = new Gehege("Nadelwald");
            Gehege gehege5 = new Gehege("Urwald");

            List<Gehege> zooStruktur = [gehege1, gehege2, gehege3, gehege4, gehege5];

            

            ZooName meinZoo = new ZooName("Tierparadies Mühlebach", 1864);

            System.Console.WriteLine($"|----Zoo: {meinZoo._Name}, gegründet {meinZoo._Gruendungsjahr}");

            foreach (Gehege gehegen in zooStruktur)
            {
                System.Console.WriteLine($"|    |----Gehege: {gehegen._Name}");
            }
        }
    }
}