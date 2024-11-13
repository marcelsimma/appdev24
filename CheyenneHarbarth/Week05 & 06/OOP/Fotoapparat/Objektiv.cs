using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{

    public class Objektiv
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

        public Objektiv(string manufacterer, string model, double focalwidthmin, double focalwidthmax)
        {
            Manufacterer = manufacterer;
            _model = model;
            _focalwidthmax = focalwidthmax;
            _focalwidthmin = focalwidthmin;
        }
    }
}