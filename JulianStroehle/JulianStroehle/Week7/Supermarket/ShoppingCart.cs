using System;
namespace JulianStroehle.Week7.Supermarket
{
    internal class ShoppingCart
    {
        internal List<Product> Products = new List<Product>();
        internal ShoppingCart()
        {}
        internal string GetPrice()
        {
            return Convert.ToString(Math.Round(Products.Sum(p => p.Price), 2) + "€");
        }
        internal int GetProductCount()
        {
            return Products.Count;
        }
        internal void AddToCart(Product product)
        {
            Products.Add(product);
        }
        internal void RemoveFromCart(string product)
        {
            bool found = false;
            for (int i = 0; i < Products.Count; i++)
            {
                if (product == Products[i].Name)
                {
                    Products.RemoveAt(i);
                    found = true;
                }
            }
            Console.WriteLine("Removed all " + product + "s from your cart.");
            if (!found)
            {
                Console.WriteLine("There is no such product in your cart.");
            }
        }
    }
}