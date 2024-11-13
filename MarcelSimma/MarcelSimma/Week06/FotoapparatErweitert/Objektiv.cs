
namespace MarcelSimma.Week06.FotoapparatErweitert
{
    public class Objektiv : IObjekt
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

        // Attribute
        // Alternativvariante zu Model mit => Operator
        private double _focalWidthMin;
        internal double FocalWidthMin
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



        public string Inventorynumber { get; }
        public double Price { get; set; }

        public Objektiv(string model, string manufacturer, double focalWidthMin, double focalWidthMax, string inventoryNumber, double price)
        {
            _model = model;
            Manufacturer = manufacturer;
            _focalWidthMin = focalWidthMin;
            _focalWidthMax = focalWidthMax;
            Inventorynumber = inventoryNumber;
            Price = price;
        }

        public override string ToString()
        {
            return

            String.Format(
            @"
            Datenblatt Objektiv: 
            
            Modell: {0}
            Hersteller: {1}
            Brennweite Min: {2}
            Brennweite Max: {3}

            ", _model, Manufacturer, _focalWidthMin, _focalWidthMax);

        }

    }
}