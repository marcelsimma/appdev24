
namespace ManuelHartmann.Week06.FotoapparatErweitert
{
    // Es muss immer zuerst die erbende Klasse 'Hardware' nach dem Punkt kommen (nur eine moeglich), dann die Interfaces.
    // Alle Attribute, welche von einer Klasse geerbt werden, muessen im Konstruktor miteingebaut werden.
    // Alle Attribute & Methoden, welche von einem Interfaces mitgegeben werden, muessen 1zu1 in der Klasse gleich eingefuegt werden.
    public class Fotoapparat : Hardware, IObjekt
    {

        private double _megapixel;
        public double Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                // Ueberpruefen, ob er bekommene Wert groesser 0 ist.
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

        // Klasse mit der Variable 'MemoryCard' erstellen, welche im Konstruktor nun den Uebergabewert zugewissen bekommt.
        public Speicherkarte MemoryCard;

        // Klasse mit der Variable 'Lense' erstellen, welche im Konstruktor nun den Uebergabewert zugewissen bekommt.
        public Objektiv Lense;

        public string Inventorynumber { get; }
        public double Price { get; set; }


        // Konstruktor
        public Fotoapparat(string model, double megapixel, string manufacturer, Speicherkarte memoryCard, 
            Objektiv lense, string inventoryNumber, double price, string serialnumber)
        {
            Model = model;
            _megapixel = megapixel;
            Manufacturer = manufacturer;
            MemoryCard = memoryCard;            // MemoryCard bekommt den Wert zugewissen.
            Lense = lense;                      // MemoryCard bekommt den Wert zugewissen.
            Inventorynumber = inventoryNumber;
            Price = price;
            Seriennummer = serialnumber;
        }

        public void TakePhoto()
        {
            /* restlichen verfügbaren Speicherplatz nach dem Erstellen des Fotos berechnen. ->
               Hierfür verwenden wir die 'CaclulcateMemoryForPicture()' Methode.                */
            double memoryUsage = CaclulcateMemoryForPicture();

            /* Ueber die oben definierte Variable 'MemoryCard' greife ich direkt auf die Klasse Speicherkarte zu und habe somit
               zugriff auf die verschiedenen Attribute der Klasse Speicherkarte.                */
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
            
            Seriennummber: {0}
            Modell: {1}
            Hersteller: {2}
            Megapixel: {3}

            ", Seriennummer, Model, Manufacturer, _megapixel) + MemoryCard.ToString() + Lense.ToString();

        }


    }
}
