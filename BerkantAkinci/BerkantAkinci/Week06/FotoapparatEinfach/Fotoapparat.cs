
using System.ComponentModel;
using System.Data.Common;

namespace BerkantAkinci.Week06.FotoapparatEinfach
{

    public class Fotoapparat
    {

        // In diesen Feld wird der Wert für Modell gespeichert.
        private string _model; // Bsp. Nicon

        // Dieses Attribut verwende ich für die Interaktion mit der Außenwelt.
        public string Model
        {
            get
            {
                // Zugriff kontrollieren: Berechtigung vorhanden (Eingeloggt)?
                return _model;
            }
            set
            {
                // Prüfen, ob der neue Wert gewissen Kriterien entspricht. 
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
                    System.Console.WriteLine("Megapixel müssen positiv sein!");
                }
            }
        }


        // Alternativvariante zu Model mit => Operator
        private double _focalWidthMin;
        public double FocalWidthMin
        {
            get => _focalWidthMin;
            set => _focalWidthMin = value;
            // richtigerweise müsste hier eine Prüfung eingesetzt werden
            // set => _focalWidthMin = (value > 0 && value < _focalWidthMax) ? value : _focalWidthMin;
        }

        private double _focalWidthMax;
        // Alternativvariante zu Megapixel mit => Operator
        public double FocalWidthMax
        {
            get => _focalWidthMax;
            // Es sollen nur positive Werte geschrieben werden können
            set => _focalWidthMax = (value > 0 && value > _focalWidthMin) ? value : _focalWidthMax;

            // Exkurs: Verschachtelte Abfragen mit dem Bedingungsoperator
            // set => _focalWidthMax = value > 0 ? value > _focalWidthMin ? value : _focalWidthMin : _focalWidthMin;
            //                      Bedingung 1 ?               wahr 1                 : falsch 1
            //                      Bedingung 1 ? Bedingung 2 ? wahr : falsch          : falsch 1
        }

        public string Manufacturer;
        // Erzeugt im Hintergrund ein Feld _manufacturer vom Typ string. 

        // Weitere Infos zum Bedingungsoperator: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator

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
            // restlichen verfügbaren Speicherplatz nach dem Erstellen des Fotos berechnen. Hierfür verwenden wir die CaclulcateMemoryForPicture() Methode.

            double memoryUsage = CaclulcateMemoryForPicture();

            if (MemoryLeft - memoryUsage > 0)
            {
                // schöne Ausgabe
                System.Console.WriteLine("Es wird ein schönes Foto gemacht.");

                // Ein Bild speichern
                AmountOfPictures++;

                MemoryLeft -= memoryUsage;
            }
            else
            {
                Console.WriteLine("Speicherplatz ist voll!");
            }

        }

        public double CaclulcateMemoryForPicture()
        {
            // Berechnung Speicherplatzverbrauch laut Angabe.
            return Megapixel * 0.3; // MB/Megapixel
        }

        // nicht static, daher der Instanz bzw. den Instanzen zugeordnet
        public override string ToString()
        {
            return

            String.Format(
            @"
            Datenblatt: 
            
            Modell: {0}
            Hersteller: {1}
            Megapixel: {2}
            Brennweite Min.: {3}
            Brennweite Max.: {4}
            Speicherplatz: {5}
            Anzahl der gespeicherten Bilder: {6}

            ", _model, Manufacturer, _megapixel, _focalWidthMin, _focalWidthMax, MemoryLeft, AmountOfPictures);

        }

    }
}