using System;

namespace FatmanurKeles.Week10.Teil1
{
    public class Futter
    {
        public string Name {get; set;}
        public string Einheit {get; set;}
        public double Einheitspreis {get; set;}
        

        public Futter(string name, string einheit, double einheitspreis)
        {
            Name = name;
            Einheit = einheit;
            Einheitspreis = einheitspreis;
        }
    }
}
