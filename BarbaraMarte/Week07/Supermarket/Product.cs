namespace BarbaraMarte.Week07.Supermarket;

class Product
{
    private string ProductName { get; set; }
    private string ProductID { get; set; }
    private double ProductPrice { get; set; }
    private int ProductTax { get; set; }
    private bool IsAvailable { get; set; }
    private bool IsOnSale { get; set; }

    public Product(string productName, string productID, double productPrice, int productTax, bool isAvailable, bool isOnSale)
    {
        ProductName = productName;
        ProductID = productID;
        ProductPrice = productPrice;
        ProductTax = productTax;
        IsAvailable = isAvailable;
        IsOnSale = isOnSale;
    }
    public override string ToString()
    {
        return string.Format($"{ProductName}, ID: {ProductID}, Price: {ProductPrice}, Tax on the product {ProductTax}%, is Available: {IsAvailable}, is on Sale: {IsOnSale} ");
    }
}