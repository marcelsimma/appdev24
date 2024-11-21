using System;

namespace OliverBedogg.Week07
{
    public class Produkt
    {
        public string _name;
        public double _preis;

        public Produkt(string name, double preis)
        {
            _name = name;
            _preis = preis;
        }
    }

    public class Buch : Produkt
    {
        public int _seiten;

        public Buch(string name, double preis, int seiten) : base(name, preis)
        {
            _seiten = seiten;
        }
    }

    public class Elektronik : Produkt
    {
        public double spannung { get; init; }

        public Elektronik(string name, double preis, double spannung) : base(name, preis)
        {
            this.spannung = spannung;
        }
    }
}