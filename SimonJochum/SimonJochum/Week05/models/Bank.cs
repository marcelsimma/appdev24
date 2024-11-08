using System;

namespace SimonJochum.Week05
{
    public class Bank
    {
        string _Produkt;
        double _Maximalbetrag;
        double _Anzahlungsbertrag;
        int _Finanzierungsdauer;

        public Bank(string produkt, double maximalbetrag, double anzahlungsbetrag, int finanzierungsdauer)
        {
            _Produkt = produkt;
            _Maximalbetrag = maximalbetrag;
            _Anzahlungsbertrag = anzahlungsbetrag;
            _Finanzierungsdauer = finanzierungsdauer;
        }

        public override string ToString()
        {
            return string.Format("Produkt: {0}, Anzahlungsbetrag: {1}, Finanzierungsdauer: {2}, Maximalbetrag: {3}", _Produkt, _Anzahlungsbertrag, _Finanzierungsdauer, _Maximalbetrag);
        }
    }
}