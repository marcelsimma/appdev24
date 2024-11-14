namespace BarbaraMarte.Week06.CameraExtended;

public class Objective : IObjekt
{

    private double _focalWidthMin;
    internal double FocalWidthMin
    {
        get => _focalWidthMin;
        set => _focalWidthMin = value;
        // set => _focalWidthMin = (value > 0 && value < _focalWidthMax) ? value : _focalWidthMin;
    }
    private double _focalWidthMax;
    public double FocalWidthMax
    {
        get => _focalWidthMax;
        set => _focalWidthMax = value;
        // Es sollen nur positive Werte geschrieben werden können
        // set => _focalWidthMax = (value > 0 && value > _focalWidthMin) ? value : _focalWidthMax;
    }
    private string _model;
    public string Model
    {
        get => _model;
        set => _model = value;
    }
    public string Manufacturer;
    public string InventoryNumber { get; }
    public double Price { get; set; }


    public Objective(double focalWidthMax, double focalWidthMin, string model, string manufacturer, string inventoryNumber, double price)
    {
        _focalWidthMin = focalWidthMin;
        _focalWidthMax = focalWidthMax;
        _model = model;
        Manufacturer = manufacturer;
        InventoryNumber = inventoryNumber;
        Price = price;
    }
    public override string ToString()
    {
        return

        String.Format(
        @"
            Data sheet: 
            
            Model: {0}
            Manufacturer: {1}
            Brennweite Min.: {2}
            Brennweite Max.: {3}
            ", _model, Manufacturer, _focalWidthMin, _focalWidthMax);

    }

}