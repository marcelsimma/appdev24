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
        public Speicherkarte(string manufacterer, string model, double memoryLeft, string inventorynumber, double price)
        {
            Manufacterer = manufacterer;
            _model = model;
            MemoryLeft = memoryLeft;
            Inventorynumber = inventorynumber;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format(@"
            Datenblatt:

            Hersteller {0}
            Modell: {1}
            Übriger Speicherplatz: {2} MB
            Anzahl der Bilder: {3}
            ",
            Manufacterer, _model, MemoryLeft, AmountOfPictures);
        }
    }
}