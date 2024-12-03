using System;
namespace JulianStroehle.Week7.Supermarket
{
    internal class Register
    {
        internal int Number;
        internal Register(int number)
        {
            Number = number;
        }
        internal void GetMembership()
        {}
        internal void BuyProducts(ShoppingCart shoppingCart)
        {
            shoppingCart.GetPrice();
            shoppingCart.Products.Clear();
        }
    }
}