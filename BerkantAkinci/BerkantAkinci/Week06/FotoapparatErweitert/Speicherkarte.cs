
namespace BerkantAkinci.Week06.FotoapparatErwitert
{
    public class Speicherkarte : IObjekt
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

        public string Manufacturer;

        public double MemoryLeft { get; internal set; }
        public int AmountOfPictures;

        public string Inventorynumber { get; }
        public double Price { get; set; }

        public Speicherkarte(string model, string manufacturer, double memoryLeft, string inventoryNumber, double price)
        {
            _model = model;
            Manufacturer = manufacturer;
            MemoryLeft = memoryLeft;
            Inventorynumber = inventoryNumber;
            Price = price;
        }

        public override string ToString()
        {
            return

            String.Format(
            @"
            Datenblatt Speicherkarte: 
            
            Modell: {0}
            Hersteller: {1}
            verfügbarer Speicherplatz: {2}
            Anzahl der Bilder: {3}

            ", _model, Manufacturer, MemoryLeft, AmountOfPictures);

        }
    }
}