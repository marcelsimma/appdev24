using System;
namespace JulianStroehle.Week6.Zoo
{
    internal class Tier
    {
        internal string Name;
        internal string Art;
        internal int Futterbedarf { get; set; }
        internal Tier(string name, string art)
        {
            Random rd = new Random();
            Name = name;
            Art = art;
            switch (Art)
            {
                case "Kuh": Futterbedarf = rd.Next(16000, 20000); break;
                case "Schaf": Futterbedarf = rd.Next(1500, 3500); break;
                case "Storch": Futterbedarf = rd.Next(500, 700); break;
                case "Elefant": Futterbedarf = rd.Next(150000, 175000); break;
            }
        }
        public override string ToString()
        {
            return Name + ", " + Art;
        }
    }
}