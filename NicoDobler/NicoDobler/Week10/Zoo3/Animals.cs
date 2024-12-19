using System;
namespace NicoDobler.Week10{



public class Tier3
{
    public string Name { get; set; }
    public string Gattung { get; set; }
    public Dictionary<Food, double> Futterbedarf { get; set; }

    public Tier3(string name, string gattung)
    {
        Name = name;
        Gattung = gattung;
        Futterbedarf = new Dictionary<Food, double>();
    }

    public void FutterbedarfHinzufuegen(Food futter, double menge)
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
}