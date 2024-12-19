using System;
namespace NicoDobler.Week10
{


    public class Food
    {
        public string Name { get; set; }
        public string Einheit { get; set; }
        public double PreisProEinheit { get; set; }

        public Food(string name, string einheit, double preis)
        {
            Name = name;
            Einheit = einheit;
            PreisProEinheit = preis;
        }
    }
}
