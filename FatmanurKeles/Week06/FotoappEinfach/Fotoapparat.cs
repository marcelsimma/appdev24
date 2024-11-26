using System;

namespace FatmanurKeles.Week06.FotoappEinfach.FotoEinfach
{
    public class Fotoapparat
    {
        private string _model; //Marke zB. Canon
        public string Model
        {
            //liest den Wert einer privaten Variable
            get
            {
                return _model;
            }
            // setzt den Wert einer privaten Variable
            set
            {
                _model = value;
            }
        }

        private double _megapixel;
        public double Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value > 0)
                {
                    _megapixel = value;
                }
                else
                {
                    Console.WriteLine("Megapixel müssen positiv sein.");
                }
            }
        }

        // kürzere Variante mit =>
        private double _focalWidthMin;
        internal double FocalWidthMin
        {
            get => _focalWidthMin;
            set => _focalWidthMin = value;
        }

        private double _focalWidthMax;
        public double FocalWidthMax
        {
            get => _focalWidthMax;
            set => _focalWidthMax = (value > 0 && value > _focalWidthMin) ? value : _focalWidthMax;
        }

        public string Manufacturer;
        // Feld _manufacturer wurde im Hintergrund erstellt

        public double MemoryLeft { get; private set; }
        public int AmountOfPictures;

        // Konstruktor
        public Fotoapparat(string model, double megapixel, double focalWidthMin, double focalWidthMax, string manufacturer, double memoryLeft)
        {
            _model = model;
            _megapixel = megapixel;
            _focalWidthMin = focalWidthMin;
            _focalWidthMax = focalWidthMax;
            Manufacturer = manufacturer;
            MemoryLeft = memoryLeft;
            AmountOfPictures = 0;
        }

        public void TakePhoto()
        {
            // CalculateMemoryForPicture() gibt den restlichen verfügbaren Speicherplatz aus
            double memoryUsage = CalculateMemoryForPicture();

            if (MemoryLeft - memoryUsage > 0)
            {
                Console.WriteLine("Es wird ein Foto gemacht");

                //Anzahl der Fotos steigen
                AmountOfPictures++;

                MemoryLeft -= memoryUsage;
            }
            else
            {
                Console.WriteLine("Kein Speicherplatz!");
            }
        }

        public double CalculateMemoryForPicture()
        {
            //0.3 wegen Angabe
            //Speicherplatz wird berechnet
            return Megapixel * 0.3;
        }

        public override string ToString()
        {
            return

            String.Format(
            @"
            Datenblatt:
            
            Modell: {0}
            Hersteller: {1}
            Megapixel: {2}
            Brennweite Min: {3}
            Brennweite Max: {4}
            Speicherplatz: {5}
            Anzahl der gespeicherten Bilder: {6}
            
            ", _model, Manufacturer, _megapixel, _focalWidthMin, _focalWidthMax, MemoryLeft, AmountOfPictures);

        }
    }
}