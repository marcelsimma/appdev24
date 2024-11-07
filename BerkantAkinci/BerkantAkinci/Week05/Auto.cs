using System;

namespace BerkantAkinci.Week05
{

    public class Auto
    {
        string _Marke;
        string _Farbe;
        int _Baujahr;
        int _Kilometerstand;

        public Auto(string marke, string farbe, int baujahr, int kilometerstand)
        {
            _Marke = marke;
            _Farbe = farbe;
            _Baujahr = baujahr;
            _Kilometerstand = kilometerstand;
        }

        public override string ToString()
        {
            return string.Format($"Marke: {_Marke,-10}, Farbe: {_Farbe,-10}, Baujahr: {_Baujahr,-4}, Kilometerstand: {_Kilometerstand,-6}");
        }
    }
}