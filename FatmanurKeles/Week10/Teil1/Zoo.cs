using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace FatmanurKeles.Week10.Teil1
{
    public class Zoo
    {
        public string ZooName { get; set; }
        public string Gruendungsjahr { get; set; }
        public List<Gehege> GehegeListe;
        public List<(string Name, string Einheit, double Einheitspreis, double kosten)> summeFutter = new List<(string Name, string Einheit, double Einheitspreis, double kosten)>();

        public Zoo(string zooname, string gruendungsjahr)
        {
            ZooName = zooname;
            Gruendungsjahr = gruendungsjahr;
            GehegeListe = new List<Gehege>();
        }

        public void FuegeGehege(Gehege gehege)
        {
            GehegeListe.Add(gehege);
        }

        public void EntferneGehege(Gehege gehege)
        {
            GehegeListe.Remove(gehege);
        }

        public void PrintGehege()
        {
            // Zoo
            Console.WriteLine($"\nZooName: {ZooName}: Gründungsjahr {Gruendungsjahr}\n");

            // alle Gehege aus der Liste ausgeben
            foreach (Gehege gehege in GehegeListe)
            {
                Console.WriteLine($"\n|-- Gehege: {gehege.GehegeName}");
                gehege.PrintTier();
                FutterAusgabe();

            }
        }

        public void Futterbedarf()
        {
            var FutterListeAusgabe = new Dictionary<Futter, double>();
            foreach (var gehegeListe in GehegeListe)
            {
                foreach (var tier in gehegeListe.TierListe)
                {
                    foreach (var futter in tier.FutterListe)
                    {
                        if (FutterListeAusgabe.ContainsKey(futter.Key))
                        {
                            FutterListeAusgabe[futter.Key] += futter.Value;
                        }
                        else
                        {
                            FutterListeAusgabe[futter.Key] = futter.Value;
                        }
                    }
                }
            }
            summeFutter.Clear();
            foreach (var eintrag in FutterListeAusgabe)
            {
                Futter futter = eintrag.Key;
                double menge = eintrag.Value;
                double kosten = futter.Einheitspreis * menge;
                summeFutter.Add((futter.Name, futter.Einheit, futter.Einheitspreis, kosten));
            }
        }
        public void FutterAusgabe()
        {
            Futterbedarf();

            Console.WriteLine("\nFutter: ");
            Console.WriteLine("_____________________________________________");
            double kosten = 0;

            foreach (var eintrag in summeFutter)
            {
                //FFEHLER BEI EINTRAG.VALUE / eintrag.Einheitspreis --> AUSBESSERN
                Console.WriteLine($"{eintrag.Name,-12} {eintrag.Einheitspreis,10} {eintrag.Einheit,4} {eintrag.kosten,8} Euro");
                kosten += eintrag.kosten;
            }

            Console.WriteLine("_____________________________________________");
            Console.WriteLine($"Summe: {kosten,25} Euro");

        }
    }
}
