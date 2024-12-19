using System;
using System.Collections.Generic;

namespace JonasWehinger.A4
{
    public class Futter
    {
        public string Name { get; set; }
        public string Einheit { get; set; }
        public float Einheitspreis { get; set; }

        public Futter(string name, string einheit, float einheitspreis)
        {
            Name = name;
            Einheit = einheit;
            Einheitspreis = einheitspreis;
        }
    }
}
