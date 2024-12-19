using System;
 
namespace JonasWehinger.A3;
 
public class Futter
{
    public string Name { get; set; }
        public float Einheitspreis { get; set; }

        public Futter(string name, float einheitspreis)
        {
            Name = name;
            Einheitspreis = einheitspreis;
    }
}