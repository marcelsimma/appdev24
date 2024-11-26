using System;
namespace JulianStroehle.Week7.Supermarket
{
    internal class Product
    {
        internal string Name;
        internal enum Category
        {
            food,
            household,
            drinks,
            other
        }
        internal DateTime ExpirationDate;
        internal double Price;
        internal bool Sale;
        internal double DiscountInPercent;
        internal int Tax;
        internal Product(string name, int category, DateTime expirationDate, double price, bool sale, double discountInPercent)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Price = price;
            Sale = sale;
            DiscountInPercent = discountInPercent;
            switch ((Category)category)
            {
                case Category.food: Tax = 10; break;
                case Category.drinks: Tax = 10; break;
                default: Tax = 20; break;
            }
        }
        internal double GetPrice()
        {
            return Price;
        }
        internal DateTime GetExpDate()
        {
            return ExpirationDate;
        }
    }
}