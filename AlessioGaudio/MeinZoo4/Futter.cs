using System;

namespace AlessioGaudio.MeinZoo4
{
    public class Futter4
    {
        public string Name { get; }
        public string Einheit { get; }
        public double Einheitspreis { get; }

        public Futter4(string name, string einheit, double einheitspreis)
        {
            Name = name;
            Einheit = einheit;
            Einheitspreis = einheitspreis;
        }
    }
}
