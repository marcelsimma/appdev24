using System;
using System.Collections.Generic;

namespace JonasWehinger.A4
{

class STart
    {
        static void Start()
        {
            Futter futter1 = new Futter("Karotten", "kg", 2.5f);
            Futter futter2 = new Futter("Fleisch", "kg", 5.0f);

            Zoo zoo = new Zoo();
            zoo.AddFutter(futter1);
            zoo.AddFutter(futter2);

            Tier tier1 = new Tier("Tiger", "Raubtier");
            tier1.AddFutterbedarf("Fleisch", 10);
            Tier tier2 = new Tier("Kaninchen", "Nagetiere");
            tier2.AddFutterbedarf("Karotten", 3);

            zoo.AddTier(tier1);
            zoo.AddTier(tier2);

            Gehege gehege1 = new Gehege("Tigergehege");
            gehege1.AddTier(tier1);
            Gehege gehege2 = new Gehege("Kaninchengehege");
            gehege2.AddTier(tier2);

            zoo.AddGehege(gehege1);
            zoo.AddGehege(gehege2);

            Pfleger pfleger = new Pfleger("Jonas", 28, "Raubtierbereich");
            pfleger.Tierpflege.Add(tier1);
            pfleger.Tierpflege.Add(tier2);

            pfleger.PrintPflegerInfo();
            pfleger.FüttereTier("Tiger", zoo);
            pfleger.RepariereGehege(gehege1);

            zoo.BerechneUndGebeFutterbedarfAus();
        }
    }
}