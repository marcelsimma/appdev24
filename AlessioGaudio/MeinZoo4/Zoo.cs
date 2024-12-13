using System;
using System.Collections.Generic;

namespace AlessioGaudio.MeinZoo4
{
    public class Zoo4
    {
        public string Name { get; }
        public int Gruendungsjahr { get; }
        private List<Gehege4> gehegeListe;
        private List<Pfleger> pflegerListe;

        public Zoo4(string name, int gruendungsjahr)
        {
            Name = name;
            Gruendungsjahr = gruendungsjahr;
            gehegeListe = new List<Gehege4>();
            pflegerListe = new List<Pfleger>();
        }

        public void GehegeHinzufuegen(Gehege4 gehege)
        {
            gehegeListe.Add(gehege);
        }

        public void PflegerHinzufuegen(Pfleger pfleger)
        {
            pflegerListe.Add(pfleger);
        }

        public void StrukturAusgeben()
        {
            Console.WriteLine($"Zoo: {Name}, gegründet {Gruendungsjahr}");
            Console.WriteLine(new string('-', 50));

            foreach (var gehege in gehegeListe)
            {
                Console.WriteLine($"Gehege: {gehege.Name}");
                foreach (var tier in gehege.GetTiere())
                {
                    Console.WriteLine($"    {tier.Name} ({tier.Gattung})");
                }
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Pfleger:");
            foreach (var pfleger in pflegerListe)
            {
                Console.WriteLine($"- {pfleger.Name}:");
                foreach (var gehege in pfleger.GetGehegeListe())
                {
                    Console.WriteLine($"    Zuständig für Gehege: {gehege.Name}");
                }
            }
        }

        public void FutterbedarfBerechnen()
        {
            var gesamtbedarf = new Dictionary<Futter4, double>();
            foreach (var gehege in gehegeListe)
            {
                foreach (var bedarf in gehege.FutterbedarfErmitteln())
                {
                    if (gesamtbedarf.ContainsKey(bedarf.Key))
                    {
                        gesamtbedarf[bedarf.Key] += bedarf.Value;
                    }
                    else
                    {
                        gesamtbedarf[bedarf.Key] = bedarf.Value;
                    }
                }
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Futterbedarf:");
            foreach (var bedarf in gesamtbedarf)
            {
                var futter = bedarf.Key;
                var menge = bedarf.Value;
                var kosten = menge * futter.Einheitspreis;
                Console.WriteLine($"{futter.Name.PadRight(15)} {menge:F2} {futter.Einheit.PadRight(5)} {kosten:F2} €");
            }
        }
    }
}
