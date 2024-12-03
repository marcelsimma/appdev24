
namespace ManuelHartmann.Week06.FotoapparatErweitert
{
    public class Speicherkarte : Hardware, IObjekt
    {
        public double MemoryLeft { get; internal set; }
        public int AmountOfPictures;

        public string Inventorynumber { get; }
        public double Price { get; set; }

        public Speicherkarte(string model, string manufacturer, double memoryLeft, string inventoryNumber, 
            double price, string serialnumber)
        {
            Model = model;
            Manufacturer = manufacturer;
            MemoryLeft = memoryLeft;
            Inventorynumber = inventoryNumber;
            Price = price;
            Seriennummer = serialnumber;
        }

        public override string ToString()
        {
            return

            String.Format(
            @"
            Datenblatt Speicherkarte: 
            
            Seriennummber: {0}
            Modell: {1}
            Hersteller: {2}
            verfügbarer Speicherplatz: {3}
            Anzahl der Bilder: {4}

            ", Seriennummer, Model, Manufacturer, MemoryLeft, AmountOfPictures);

        }
    }
}
