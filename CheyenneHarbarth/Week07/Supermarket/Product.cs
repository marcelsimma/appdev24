using System;

namespace CheyenneHarbarth.Week07.Supermarket
{
    internal abstract class Product
    {
        internal required string Productname;
        internal double Price;
        internal double Taxes;
        internal required string Productnumber;
        internal int Recommendedamount { get; }

        internal void Sale(double percent)
        {
            Price *= (1 - (percent / 100));
        }

        internal bool IsProductAvailable(Dictionary<Product, int> products, Product product)
        {
            if (products[product] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Book : Product
    {
        internal string Pagenumbers;
        internal Book(string productname, double price, double taxes, string productnumber, string pagenumbers)
        {
            Productname = productname;
            Price = price;
            Taxes = taxes;
            Productnumber = productnumber;
            Pagenumbers = pagenumbers;
        }
    }

    internal class Clothes : Product
    {
        internal string Size;

        internal Clothes(string productname, double price, double taxes, string productnumber, string size)
        {
            Productname = productname;
            Price = price;
            Taxes = taxes;
            Productnumber = productnumber;
            Size = size;
        }
    }

    internal class Food : Product
    {
        internal DateTime ExpiryDate;

        internal Food(string productname, double price, double taxes, string productnumber, DateTime expirydate)
        {
            Productname = productname;
            Price = price;
            Taxes = taxes;
            Productnumber = productnumber;
            ExpiryDate = expirydate;
        }

        internal bool StillGood()
        {
            if (ExpiryDate > DateTime.Now)
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