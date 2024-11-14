using System;
namespace CheyenneHarbarth.Week05.OOP.FahrzeugVererbung
{
    public class FahrzeugStart
    {
        public static void Launch()
        {
            Auto auto = new Auto(50);
            auto.Fahren();
        }
    }
}