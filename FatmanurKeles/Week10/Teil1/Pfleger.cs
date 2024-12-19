using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Pfleger
    {
        public string Name {get; set;}
        public List<Gehege> GehegePfleger;

        public Pfleger(string name)
        {
            Name = name;
            GehegePfleger = new List<Gehege>();
        }
    }
}