using System;
using System.Numerics;
using System.Security.Cryptography;

namespace CheyenneHarbarth.Week07.Supermarket
{
    internal class ShoppingCart
    {
        internal int MaxCapacity;
        internal int Counter = 0;
        internal double Total;
        internal List<Product> Productitems = new List<Product>();

        internal ShoppingCart(int maxcapacity)
        {
            MaxCapacity = maxcapacity;
        }

        internal void AddProduct(Product p)
        {
            if (Counter < MaxCapacity)
            {
                Productitems.Add(p);
                Counter++;
            }
            else
            {
                Console.WriteLine($"Dein Warenkorb ist voll, gehe zur Kassa!");
            }
        }

        internal void RemoveProduct(Product p)
        {
            Productitems.Remove(p);
            Counter--;
        }

        internal void Sale(double percent)
        {
            Total *= (1 - (percent / 100));
        }

        internal void ContentAndTotal()
        {
            foreach (Product p in Productitems)
            {
                Console.WriteLine($"{p,-15}{p.Price:F2} EUR");
                Total += p.Price;
            }
            Console.WriteLine($"{Total,20} EUR");
        }
    }
}