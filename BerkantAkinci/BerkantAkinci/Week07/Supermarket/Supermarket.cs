using System;

namespace BerkantAkinci.Week07.Supermarket
{
    public class Supermarket
    {
        public string MarketName;
        public DateTime OpeningTimes = new DateTime();
        List<Cashout> CashoutList = new List<Cashout>();
        Dictionary<Product, int> ProductList = new Dictionary<Product, int>();

        public Supermarket(string marketName, DateTime openingTimes)
        {
            MarketName = marketName;
            OpeningTimes = openingTimes;
        }

        public bool MarketIsOpen()
        {
            return true;
        }

        public void OrderProduct()
        {

        }
    }
}