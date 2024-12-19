using System;
namespace NicoDobler.Week10
{
    public class Tier4
    {
        public string Name { get; }
        public string Gattung { get; }
        private Dictionary<Futter4, double> futterbedarf;

        public Tier4(string name, string gattung)
        {
            Name = name;
            Gattung = gattung;
            futterbedarf = new Dictionary<Futter4, double>();
        }

        public void FutterbedarfHinzufuegen(Futter4 futter, double menge)
        {
            if (futterbedarf.ContainsKey(futter))
            {
                futterbedarf[futter] += menge;
            }
            else
            {
                futterbedarf[futter] = menge;
            }
        }

        public Dictionary<Futter4, double> GetFutterbedarf()
        {
            return futterbedarf;
        }
    }
}
