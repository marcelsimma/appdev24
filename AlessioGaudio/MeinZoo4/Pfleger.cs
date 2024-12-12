using System;
using System.Collections.Generic;

namespace AlessioGaudio.MeinZoo4
{
    public class Pfleger
    {
        public string Name { get; }
        private List<Gehege4> gehegeListe;

        public Pfleger(string name)
        {
            Name = name;
            gehegeListe = new List<Gehege4>();
        }

        public void GehegeHinzufuegen(Gehege4 gehege)
        {
            gehegeListe.Add(gehege);
        }

        public List<Gehege4> GetGehegeListe()
        {
            return gehegeListe;
        }
    }
}
