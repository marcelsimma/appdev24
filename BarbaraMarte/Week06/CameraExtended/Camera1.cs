namespace BarbaraMarte.Week06.CameraExtended
{

    public class Camera : IObjekt
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => _model = value;
        }
        private double _megapixel;
        public double Megapixel
        {
            get => _megapixel;
            set => _megapixel = value;
            // set => _megapixel = (value > 0) ? value : _megapixel;
        }

        public string Manufacturer;
        public MemoryCard MemoryCard1;
        public Objective Lense;
        public string InventoryNumber { get; }
        public double Price { get; set; }

        // Constructor
        public Camera(string model, double megapixel, string manufacturer, MemoryCard memoryCard, Objective lense, string inventoryNumber, double price)
        {
            _model = model;
            _megapixel = megapixel;
            Manufacturer = manufacturer;
            MemoryCard1 = memoryCard;
            Lense = lense;
            InventoryNumber = inventoryNumber;
            Price = price;
        }

        public void TakePhoto()
        {
            // restlichen verfügbaren Speicherplatz nach dem Erstellen des Fotos berechnen. Hierfür verwenden wir die CaclulcateMemoryForPicture() Methode.

            double memoryUsage = CalculateMemoryForPicture();

            if (MemoryCard1.MemoryLeft - memoryUsage > 0)
            {
                // schöne Ausgabe
                System.Console.WriteLine(
                    @"
                      /)_/)      (\_(\
                     („>.<)      (>.<„)
                     / > <3        >< \
                    ");
                MemoryCard1.AmountOfPictures++;

                MemoryCard1.MemoryLeft -= memoryUsage;
            }
            else
            {
                Console.WriteLine("Memory space is full!");
            }

        }

        public double CalculateMemoryForPicture()
        {
            return Megapixel * 0.3; // MB/Megapixel
        }

        // nicht static, daher der Instanz bzw. den Instanzen zugeordnet
        public override string ToString()
        {
            return

            String.Format(
            @"
            Data sheet: 
            
            Model: {0}
            Manufacturer: {1}
            Megapixel: {2}
            ", _model, Manufacturer, _megapixel) + MemoryCard1.ToString() + Lense.ToString();

        }


    }
}