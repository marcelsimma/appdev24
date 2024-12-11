using System;

namespace CheyenneHarbarth.Zoo.Zoostructure
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo MyZoo = new Zoo("Mühlebacher Streichelzoo", 1964);

            Enclosure AlpineMeadow = new Enclosure("Alpenwiese: neutral, offen und hügelig");
            Enclosure Icelake = new Enclosure("Eissee: sehr kalt");
            Enclosure Marsh = new Enclosure("Ried: kalt, matschig");
            Enclosure Forest = new Enclosure("Nadelwald: kalt, dicht bewaldet");
            Enclosure Jungle = new Enclosure("Urwald: warm, dicht bewachsen");

            MyZoo.AddEnclosure(AlpineMeadow);
            MyZoo.AddEnclosure(Icelake);
            MyZoo.AddEnclosure(Marsh);
            MyZoo.AddEnclosure(Forest);
            MyZoo.AddEnclosure(Jungle);

            MyZoo.PrintZoo();
        }
    }
}