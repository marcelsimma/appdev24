using System;
using System.Runtime.CompilerServices;

namespace CheyenneHarbarth.Week07.Supermarket
{
    internal class Costumer
    {
        internal string Costumernumber { get; set; }
        internal ShoppingCart shoppingCart;
        internal string PayingMethod;

        internal Costumer(string costumernumber, ShoppingCart shoppingcart, string payingmethod)
        {
            Costumernumber = costumernumber;
            shoppingCart = shoppingcart;
            PayingMethod = payingmethod;
        }

        internal void PayForShoppingCart(Dictionary<Product, int> products)
        {
            //Einkauf anziegen, "Bezahlen", Lagerstände aktualisieren
            shoppingCart.ContentAndTotal();

            Console.WriteLine($"\n Der Kunde {Costumernumber} zahlt {PayingMethod}");
            foreach (Product p in shoppingCart.Productitems)
            {
                products[p] -= 1;
            }
            Console.WriteLine($"Die Lagerstände wurden aktualisiert!");

        }
    }
}