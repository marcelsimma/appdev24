using System;
using System.Collections.Generic;

public class Tier3
{
    public string Name { get; set; }
    public string Gattung { get; set; }
    public Dictionary<Futter, double> Futterbedarf { get; set; }

    public Tier3(string name, string gattung)
    {
        Name = name;
        Gattung = gattung;
        Futterbedarf = new Dictionary<Futter, double>();
    }

    public void FutterbedarfHinzufuegen(Futter futter, double menge)
    {
        if (Futterbedarf.ContainsKey(futter))
        {
            Futterbedarf[futter] += menge;
        }
        else
        {
            Futterbedarf[futter] = menge;
        }
    }
}
