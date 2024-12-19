using System;
namespace NicoDobler.Week10
{



    public class Gehege3
    {
        public string Name { get; set; }
        private List<Tier3> Tiere;
        private Dictionary<Food, double> Futterbedarf;

        public Gehege3(string name)
        {
            Name = name;
            Tiere = new List<Tier3>();
            Futterbedarf = new Dictionary<Food, double>();
        }

        public void TierHinzufuegen(Tier3 tier)
        {
            Tiere.Add(tier);
            BerechneFutterbedarf(tier);
        }

        private void BerechneFutterbedarf(Tier3 tier)
        {
            foreach (var futter in tier.Futterbedarf)
            {
                if (Futterbedarf.ContainsKey(futter.Key))
                {
                    Futterbedarf[futter.Key] += futter.Value;
                }
                else
                {
                    Futterbedarf[futter.Key] = futter.Value;
                }
            }
        }

        public Dictionary<Food, double> FutterbedarfErmitteln()
        {
            return Futterbedarf;
        }

        public void StrukturAusgeben()
        {
            Console.WriteLine($"│   ├── Gehege: {Name}");
            if (Tiere.Count == 0)
            {
                Console.WriteLine("│       ├── (leer)");
            }
            else
            {
                foreach (var tier in Tiere)
                {
                    Console.WriteLine($"│       ├── {tier.Name}, {tier.Gattung}");
                }
            }
        }
    }
}
