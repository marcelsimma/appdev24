using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Gehege
    {
        public string GehegeName { get; set; }
        public List<Tier> TierListe;
        public List<Pfleger> PflegerListe;
        public Gehege(string gehegename)
        {
            GehegeName = gehegename;
            TierListe = new List<Tier>();
            PflegerListe = new List<Pfleger>();
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


           public void FuegePfleger(Pfleger pfleger)
        {
            PflegerListe.Add(pfleger);
        }

        public void EntfernePfleger(Pfleger pfleger)
        {
            PflegerListe.Remove(pfleger);
        }
        
        public void PrintPfleger()
        {
            foreach (Pfleger pfleger in PflegerListe)
            {
                Console.WriteLine($"Pfleger: {pfleger.Name}");
            }
        }
    }
}