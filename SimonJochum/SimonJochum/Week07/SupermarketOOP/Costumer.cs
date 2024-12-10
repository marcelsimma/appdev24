using System;
using System.Security.Authentication;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class Costumer
    {
        private double _amountCash;
        private bool _hasCreditCard;
        public ShoppingCart @ShoppingCart;
        private bool _hasDiscountCard;

        public Costumer(double amountCash, bool hasCreditCard, ShoppingCart shoppingCart, bool hasDiscountCard)
        {
            _amountCash = amountCash;
            _hasCreditCard = hasCreditCard;
            @ShoppingCart = shoppingCart;
            _hasDiscountCard = hasDiscountCard;
        }

        public void PayWithCreditCard()
        {

        }
        public double PayWithCash()
        {
            double exchange = 0.0;
            return exchange;
        }

        public void GoToCheckOut()
        {
            
        }

    }
}