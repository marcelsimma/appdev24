using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Gehege
    {
        public string GehegeName { get; set; }
        public List<Tier> TierListe;

        public Gehege(string gehegename)
        {
            GehegeName = gehegename;
            TierListe = new List<Tier>();
        }

        public void FuegeTier(Tier tier)
        {
            TierListe.Add(tier);
        }

        public void EntferneTier(Tier tier)
        {
            TierListe.Remove(tier);
        }

        public void PrintTier()
        {
            foreach (Tier tier in TierListe)
            {
                Console.WriteLine($"  |-- Tier: {tier.TierName}  \tGattung: {tier.Gattung}");
                tier.PrintFutter();      
            }
        }

        public void PrintFutter()
        {
            Console.WriteLine("Futterbedarf für dieses Gehege:");
            foreach (var tier in TierListe)
            {
                tier.PrintFutter();
            }
        }
    }
}