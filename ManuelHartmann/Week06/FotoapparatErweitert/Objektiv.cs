
namespace ManuelHartmann.Week06.FotoapparatErweitert
{
    public class Objektiv : Hardware, IObjekt
    {
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
            // () -> Bedingung , if -> ?, wenn true -> 'value', wenn nicht '_focalWidthMax'.
            set => _focalWidthMax = (value > 0 && value > _focalWidthMin) ? value : _focalWidthMax;

            // Exkurs: Verschachtelte Abfragen mit dem Bedingungsoperator
            // set => _focalWidthMax = value > 0 ? value > _focalWidthMin ? value : _focalWidthMin : _focalWidthMin;
            //                      Bedingung 1 ?               wahr 1                 : falsch 1
            //                      Bedingung 1 ? Bedingung 2 ? wahr : falsch          : falsch 1
        }



        public string Inventorynumber { get; }
        public double Price { get; set; }

        public Objektiv(string model, string manufacturer, double focalWidthMin, double focalWidthMax, 
            string inventoryNumber, double price, string serialnumber)
        {
            Model = model;
            Manufacturer = manufacturer;
            _focalWidthMin = focalWidthMin;
            _focalWidthMax = focalWidthMax;
            Inventorynumber = inventoryNumber;
            Price = price;
            Seriennummer = serialnumber;
        }

        public override string ToString()
        {
            return

            String.Format(
            @"
            Datenblatt Objektiv: 
            
            Seriennummer: {0}
            Modell: {1}
            Hersteller: {2}
            Brennweite Min: {3}
            Brennweite Max: {4}

            ", Seriennummer, Model, Manufacturer, _focalWidthMin, _focalWidthMax);

        }

    }
}
