using System;
using System.Collections.Generic;

namespace JonasWehinger.A4
{
public class Gehege
    {
        public string Name { get; set; }
        public List<Tier> TierListe { get; set; }

        public Gehege(string name)
        {
            Name = name;
            TierListe = new List<Tier>();
        }

        public void AddTier(Tier tier)
        {
            TierListe.Add(tier);
        }

        public void RemoveTier(string tierName)
        {
            TierListe.RemoveAll(t => t.Name == tierName);
        }

        public void PrintGehegeStruktur()
        {
            Console.WriteLine($"Gehege: {Name}");
            foreach (var tier in TierListe)
            {
                Console.WriteLine($" - {tier.Name} ({tier.Rasse})");
            }
        }
    }
}