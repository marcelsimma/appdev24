
using System.ComponentModel;
using System.Data.Common;

namespace MarcelSimma.Week06.FotoapparatErweitert
{

    public class Fotoapparat : IObjekt
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

        public string Manufacturer;

        public Speicherkarte MemoryCard;

        public Objektiv Lense;

        public string Inventorynumber { get; }
        public double Price { get; set; }


        // Konstruktor
        public Fotoapparat(string model, double megapixel, string manufacturer, Speicherkarte memoryCard, Objektiv lense, string inventoryNumber, double price)
        {
            _model = model;
            _megapixel = megapixel;
            Manufacturer = manufacturer;
            MemoryCard = memoryCard;
            Lense = lense;
            Inventorynumber = inventoryNumber;
            Price = price;
        }

        public void TakePhoto()
        {

            // restlichen verfügbaren Speicherplatz nach dem Erstellen des Fotos berechnen. Hierfür verwenden wir die CaclulcateMemoryForPicture() Methode.

            double memoryUsage = CaclulcateMemoryForPicture();

            if (MemoryCard.MemoryLeft - memoryUsage > 0)
            {
                // schöne Ausgabe
                System.Console.WriteLine("Es wird ein schönes Foto gemacht.");

                // Ein Bild speichern
                MemoryCard.AmountOfPictures++;

                MemoryCard.MemoryLeft -= memoryUsage;
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
            Datenblatt Kamera: 
            
            Modell: {0}
            Hersteller: {1}
            Megapixel: {2}

            ", _model, Manufacturer, _megapixel) + MemoryCard.ToString() + Lense.ToString();

        }


    }
}