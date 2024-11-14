using System;

namespace CheyenneHarbarth.Week05.OOP.Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Gehege gehege1 = new Gehege("Alpenwiese");
            Gehege gehege2 = new Gehege("Eissee");
            Gehege gehege3 = new Gehege("Ried");
            Gehege gehege4 = new Gehege("Nadelwald");
            Gehege gehege5 = new Gehege("Urwald");

            List<Gehege> Zoostruktur = new List<Gehege>();


            Zoostruktur.Add(gehege1);
            Zoostruktur.Add(gehege2);
            Zoostruktur.Add(gehege3);
            Zoostruktur.Add(gehege4);
            Zoostruktur.Add(gehege5);


            Zoo MeinZoo = new Zoo("Tierparadies Mühlebach", 1864);

            Console.WriteLine($"\n|--- Zoo: {MeinZoo._Name}, gegründet {MeinZoo._Gründungsjahr}");
            foreach (Gehege GehegeName in Zoostruktur)
            {
                Console.WriteLine("|    |--- Gehege: " + GehegeName._Name);
            }
        }
    }
}