using System;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class Product : ProductCategory
    {
        public string name {get;}
        public double price {get; set;}
        public string idCode;
        public int tax;
        public int amountInStock;

        public Product(string productName, double productPrice, int amountOfProduct)
        {
            name = productName;
            price = productPrice;
            amountInStock = amountOfProduct;
        }

        public bool IsAvailable()
        {
            if (amountInStock > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}