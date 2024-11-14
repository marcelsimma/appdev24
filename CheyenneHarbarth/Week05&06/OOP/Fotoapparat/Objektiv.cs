using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{

    public class Objektiv : IObjekt
    {
        private double _focalwidthmin;
        public double FocalWidthMin
        {
            get => _focalwidthmin;
            set => _focalwidthmin = value;
        }

        private double _focalwidthmax;
        public double FocalWidthMax
        {
            get => _focalwidthmax;
            set => _focalwidthmax = (value > 0 && value > _focalwidthmin) ? value : _focalwidthmax;
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public string Manufacterer;

        public string Inventorynumber { get; }

        public double Price { get; set; }

        public Objektiv(string manufacterer, string model, double focalwidthmin, double focalwidthmax, string inventorynumber, double price)
        {
            Manufacterer = manufacterer;
            _model = model;
            _focalwidthmax = focalwidthmax;
            _focalwidthmin = focalwidthmin;
            Inventorynumber = inventorynumber;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format(@"
            Datenblatt:

            Hersteller {0}
            Modell: {1}
            Minimale Brennweite: {2}
            Maximale Brennweite: {3}
            ",
            Manufacterer, _model, _focalwidthmin, _focalwidthmax);
        }
    }
}