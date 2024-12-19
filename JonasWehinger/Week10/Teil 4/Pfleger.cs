using System;
using System.Collections.Generic;

namespace JonasWehinger.A4
{
    public class Pfleger
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Arbeitsbereich { get; set; }
        public List<Tier> Tierpflege { get; set; }

        public Pfleger(string name, int alter, string arbeitsbereich)
        {
            Name = name;
            Alter = alter;
            Arbeitsbereich = arbeitsbereich;
            Tierpflege = new List<Tier>();
        }

        public void FüttereTier(string tierName, Zoo zoo)
        {
            var tier = zoo.Tiere.Find(t => t.Name == tierName);
            if (tier != null)
            {
                Console.WriteLine($"Fütterung von {tier.Name}:");
                foreach (var futter in tier.Futterbedarf)
                {
                    Futter futterArt = zoo.Futterarten[futter.Key];
                    Console.WriteLine($"{futter.Key}: {futter.Value} {futterArt.Einheit} -> {futter.Value * futterArt.Einheitspreis} €");
                }
            }
            else
            {
                Console.WriteLine("Tier nicht gefunden.");
            }
        }

        public void RepariereGehege(Gehege gehege)
        {
            Console.WriteLine($"Pfleger {Name} repariert das Gehege {gehege.Name}.");
        }

        public void PrintPflegerInfo()
        {
            Console.WriteLine($"Pfleger: {Name}, Alter: {Alter}, Arbeitsbereich: {Arbeitsbereich}");
        }
    }
}