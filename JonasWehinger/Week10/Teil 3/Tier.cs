using System;
 
namespace JonasWehinger.A3;
 
public class Tier
{
    public string Name { get; set; }
        public Dictionary<string, float> Futterbedarf { get; set; }

        public Tier(string name, Dictionary<string, float> futterbedarf)
        {
            Name = name;
            Futterbedarf = futterbedarf;
        }
    public float BerechneFutterkosten(Dictionary<string, Futter> futterarten)
        {
            float kosten = 0;
            foreach (var futter in Futterbedarf)
            {
                kosten += futter.Value * futterarten[futter.Key].Einheitspreis;
            }
            return kosten;
        }
    }
