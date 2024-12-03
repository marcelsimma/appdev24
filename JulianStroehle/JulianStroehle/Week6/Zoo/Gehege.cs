using System;
namespace JulianStroehle.Week6.Zoo
{
    internal class Gehege
    {
        internal string Name;
        internal List<Tier> Tiere = new List<Tier>();
        public Gehege(string name, List<Tier> tiere)
        {
            Name = name;
            Tiere = tiere;
        }
        public override string ToString()
        {
            return "Gehege: " + Name;
        }
    }
}