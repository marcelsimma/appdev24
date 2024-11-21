namespace BarbaraMarte.Week07.Supermarket;
class Supermarket
{
    private double MaxAmountOfProducts { get; set; }
    private int MaxAmountOfCostumers { get; set; }
    private List<Register> registers = new List<Register>();
    private bool IsOpen { get; set; }
    public Supermarket(double maxAmountOfProducts, int maxAmountOfCostumers, bool isOpen, List<Register> register1)
    {
        MaxAmountOfProducts = maxAmountOfProducts;
        MaxAmountOfCostumers = maxAmountOfCostumers;
        IsOpen = isOpen;
        registers = register1;
    }
    public override string ToString()
    {
        return string.Format(
            $@"
            The supermarket is open: {IsOpen}
            Max Amount of Costumers in the supermarket: {MaxAmountOfCostumers}
            Max Amount of Products in the supermarket: {MaxAmountOfProducts}
            How many registers are open? {registers}
            ");
    }

}