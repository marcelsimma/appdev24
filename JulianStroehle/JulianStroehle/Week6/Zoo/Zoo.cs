using System;
namespace JulianStroehle.Week6.Zoo
{
    internal class Zoo
    {
        internal string Name;
        internal int Gründungsjahr;
        List<Gehege> Gehege = new List<Gehege>();
        public Zoo(string name, int gründungsjahr, List<Gehege> gehege)
        {
            Name = name;
            Gründungsjahr = gründungsjahr;
            Gehege = gehege;
        }
        public override string ToString()
        {
            return string.Format("Zoo: {0}, gegründet {1}", Name, Gründungsjahr);
        }
    }
}