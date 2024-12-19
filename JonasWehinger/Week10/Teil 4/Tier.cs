using System;
using System.Collections.Generic;

namespace JonasWehinger.A4
{
public class Tier
    {
        public string Name { get; set; }
        public string Rasse { get; set; }
        public Dictionary<string, float> Futterbedarf { get; set; }

        public Tier(string name, string rasse)
        {
            Name = name;
            Rasse = rasse;
            Futterbedarf = new Dictionary<string, float>();
        }

        public void AddFutterbedarf(string futterName, float menge)
        {
            Futterbedarf[futterName] = menge;
        }
    }
}