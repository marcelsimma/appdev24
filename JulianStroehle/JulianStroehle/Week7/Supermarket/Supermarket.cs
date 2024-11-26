using System;
namespace JulianStroehle.Week7.Supermarket
{
    internal class Supermarket
    {
        internal string Name;
        internal bool Open = false;
        internal List<Product> Products;
        internal List<Register> Registers;
        internal List<Customer> Customers;
        internal Supermarket(string name, List<Product> products, List<Register> registers, List<Customer> customers)
        {
            Name = name;
            Products = products;
            Registers = registers;
            Customers = customers;
        }
        internal void OpenMarket()
        {
            Open = true;
        }
        internal void CloseMarket()
        {
            Open = false;
        }
    }
}