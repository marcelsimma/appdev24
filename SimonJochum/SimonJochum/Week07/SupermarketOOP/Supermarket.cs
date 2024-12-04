using System;
using System.Dynamic;

namespace SimonJochum.Week07.SupermarketOOP
{
    public class Supermarket
    {
        public string name;
        public Costumer costumer;
        private List<Checkout> _checkouts = new List<Checkout>();
        private List<Product> _products = new List<Product>();
        private List<Staff> _staff = new List<Staff>();

        public Supermarket(string marketName)
        {
            name = marketName;

        }

        public void AddProductToInventory(Product productToAdd)
        {
            _products.Add(productToAdd);
        }
        public void OpenCheckout(Checkout checkoutToAdd)
        {
            _checkouts.Add(checkoutToAdd);
        }
        public void StaffWhoIsWorking(Staff staffToAdd)
        {
            _staff.Add(staffToAdd);
        }
        public void OpenMarket()
        {
            Console.WriteLine(new string('-', 30) + "\nWir haben geöffnet\n" + new string('-', 30));
        }
        public void CloseMarket()
        {
            Console.WriteLine(new string('-', 30) + "\nWir haben geschlossen. Kommen Sie morgen wieder.\n" + new string('-', 30));
        }
    }
}