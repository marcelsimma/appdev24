using System;
namespace NicoDobler.Week10
{
    public class Gehege4
    {
        public string Name { get; }
        private List<Tier4> tiere;

        public Gehege4(string name)
        {
            Name = name;
            tiere = new List<Tier4>();
        }

        public void TierHinzufuegen(Tier4 tier)
        {
            tiere.Add(tier);
        }

        public List<Tier4> GetTiere()
        {
            return tiere;
        }

        public Dictionary<Futter4, double> FutterbedarfErmitteln()
        {
            var futterbedarf = new Dictionary<Futter4, double>();
            foreach (var tier in tiere)
            {
                foreach (var bedarf in tier.GetFutterbedarf())
                {
                    if (futterbedarf.ContainsKey(bedarf.Key))
                    {
                        futterbedarf[bedarf.Key] += bedarf.Value;
                    }
                    else
                    {
                        futterbedarf[bedarf.Key] = bedarf.Value;
                    }
                }
            }
            return futterbedarf;
        }
    }
}
