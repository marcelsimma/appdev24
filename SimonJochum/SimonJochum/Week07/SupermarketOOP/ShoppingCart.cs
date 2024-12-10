using System;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class ShoppingCart
    {
        public List<Product> Products = new List<Product>();
        public double totalSum;
        public int amountPieces;

        public ShoppingCart()
        {
        
        }

        public double CalculateCartPrice()
        {
            double value = 0.0;
            foreach (var prod in Products)
            {
                 value += prod.price;
            }
            return value;
        }

        public int AmountProductsInCart()
        { 
            int count = 0;
            foreach(var prod in Products)
            {
               
                count++;
            }
            return count;
        }

        public void AddProduct(Product productToAdd)
        {
            Products.Add(productToAdd);
        }
        public void RemoveProduct(Product toRemove)
        {
            Products.Remove(toRemove);
        }
    }
}