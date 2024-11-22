using System;
namespace JulianStroehle.Week7.Supermarket
{
    internal class Customer
    {
        private bool _isMember;
        internal ShoppingCart Cart;
        internal enum PaymentMethod
        {
            Cash,
            Card
        }
        internal int Method;
        internal Customer(ShoppingCart cart, int paymentMethod)
        {
            Cart = cart;
            Method = paymentMethod;
        }
        internal void GetMethod()
        {
            Console.WriteLine((PaymentMethod)Method);
        }
    }
}