using System;
 
namespace JonasWehinger.A3;
 
public class Zoo
    {
        public Dictionary<string, Futter> Futterarten { get; set; }
        public List<Tier> Tiere { get; set; }

        public Zoo()
        {
            Futterarten = new Dictionary<string, Futter>();
            Tiere = new List<Tier>();
        }

        public void AddFutter(Futter futter)
        {
            Futterarten[futter.Name] = futter;
        }

        public void AddTier(Tier tier)
        {
            Tiere.Add(tier);
        }
    
    public void BerechneUndGebeFutterbedarfAus()
        {
            Console.WriteLine("\nFutterbedarf:");
            Console.WriteLine("----------------------------------");
            float gesamtkosten = 0;

            foreach (var tier in Tiere)
            {
                Console.WriteLine($"Tier: {tier.Name}");
                foreach (var futter in tier.Futterbedarf)
                {
                    float kosten = futter.Value * Futterarten[futter.Key].Einheitspreis;
                    Console.WriteLine($"{futter.Key,-10} {futter.Value,5:0.00} -> {kosten,8:0.00} €");
                    gesamtkosten += kosten;
                }
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Summe: {gesamtkosten:0.00} €");
        }
    }
    
