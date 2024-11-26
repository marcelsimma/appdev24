using System;

namespace BerkantAkinci.Week07.Supermarket
{
    public class Product
    {
        public double Price;
        public string ProductName;
        public string ProductNumber;

        public Product(double price, string productName, string productNumber)
        {
            Price = price;
            ProductName = productName;
            ProductNumber = productNumber;
        }

        public bool ProductAvailable()
        {
            return true;

        }

        public double ProductSale(double percent)
        {
            return 12;
        }
    }
}