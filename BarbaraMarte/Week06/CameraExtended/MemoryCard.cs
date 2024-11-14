namespace BarbaraMarte.Week06.CameraExtended;

public class MemoryCard
{

    private string _model;
    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public string Manufacturer { get; set; }
    public double MemoryLeft { get; internal set; }
    public string InventoryNumber { get; }
    public double Price { get; set; }
    public int AmountOfPictures;


    public MemoryCard(string model, string manufacturer, double memoryLeft, string inventoryNumber, double price)
    {
        _model = model;
        Manufacturer = manufacturer;
        MemoryLeft = memoryLeft;
        InventoryNumber = inventoryNumber;
        Price = price;
    }

    public override string ToString()
    {
        return String.Format(@"
            Data sheet: 
            
            Model: {0}
            Manufacturer: {1}
            Inventory number: {2}
            Price: {3}
            Memory left: {4}
            ", _model, Manufacturer, InventoryNumber, Price, MemoryLeft);
    }
}
