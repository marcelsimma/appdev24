using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{
    public class Speicherkarte : IObjekt
    {
        public double MemoryLeft { get; set; }

        public int AmountOfPictures;

        public string Manufacterer;

        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public string Inventorynumber { get; }

        public double Price { get; set; }
        public Speicherkarte(string model, string manufacterer, double memoryLeft)
        {
            _model = model;
            Manufacterer = manufacterer;
            MemoryLeft = memoryLeft;
        }
    }
}