using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Tier
    {
        public string TierName {get; set;}
        public string Gattung {get; set;}
        public Dictionary<Futter, double> FutterListe {get; set;}
    
        public Tier(string tiername, string gattung)
        {
            TierName = tiername;
            Gattung = gattung;
            FutterListe = new Dictionary<Futter, double>();
        }

        public void FuegeFutter(Futter futter, double menge)
        {
            FutterListe.Add(futter, menge); 
        }

        public void EntferneFutter(Futter futter)
        {
            FutterListe.Remove(futter);
        }

        public double KostenSumme()
        {
            double kosten = 0;
            foreach (var futter in FutterListe)
            {
                kosten += futter.Value * futter.Key.Einheitspreis;
            }
            return kosten;
        }

        public void PrintFutter() 
        {
           // Console.WriteLine("Futterbedarf:");
            //Console.WriteLine(new string('_', 15));

            foreach (var futter in FutterListe)
            {
                Console.WriteLine($"{futter.Key.Name} \t {futter.Key.Einheit} \t{futter.Key.Einheitspreis}");
            }
        }
    }
}