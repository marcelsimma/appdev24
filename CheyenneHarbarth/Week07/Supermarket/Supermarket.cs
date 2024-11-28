using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace CheyenneHarbarth.Week07.Supermarket
{
    internal class Supermarket              //internal, so können wir innerhalb des Projekts(des Ordners) darauf zugreifen, aber nicht von einem anderen Projekt
    {
        private string title { get; set; }
        private string address { get; set; }
        internal Dictionary<DateTime, DateTime> OpeningHours;
        internal List<Checkout> Checkouts = new List<Checkout>();

        internal Dictionary<Product, int> Products = new Dictionary<Product, int>();

        internal List<Employee> Employees = new List<Employee>();

        internal Supermarket(string _title, string _address, Dictionary<DateTime, DateTime> openinghours)
        {
            title = _title;
            address = _address;
            OpeningHours = openinghours;
        }

        internal void IsSupermarketOpen()
        {
            foreach (KeyValuePair<DateTime, DateTime> timeopen in OpeningHours)
            {
                if ((int)timeopen.Key.DayOfWeek > 0 && (int)timeopen.Key.DayOfWeek < 6)
                {
                    if (timeopen.Value.Hour >= 8 && timeopen.Value.Hour <= 19)
                    {
                        Console.WriteLine($"Der Supermarkt {title} hat geöffnet!");
                    }
                }
                if ((int)timeopen.Key.DayOfWeek == 6)
                {

                }
                else
                {
                    Console.WriteLine($"Der Supermarkt {title} ist geschlossen!");
                }
            }
        }

        internal void WhichCheckoutIsOpen()
        {
            Console.Write("\nFolgende Kassen sind geöffnet: ");
            foreach (Checkout co in Checkouts)
            {
                if (co.isopen == true)
                {
                    Console.Write($"Kassa {co.Checkoutnumber}");
                }
            }
        }

        internal void WhichEmployeeIsOpen()
        {
            Console.Write("\nFolgende Mitarbeiter sind verfügbar: ");
            foreach (Employee e in Employees)
            {
                if (e.Available == true)
                {
                    Console.WriteLine($"{e.employeename}");
                }
            }
        }

        internal void OrderEmptyProducts()
        {
            foreach (Employee e in Employees)
            {
                if (e.Available == true)
                {
                    foreach (Product p in Products.Keys)
                    {
                        if (Products[p] == 0)
                        {
                            Console.WriteLine($"Von {Products.Keys} wurden 10 Stück nachbestellt");
                            Products[p] = p.Recommendedamount;
                        }
                    }
                }
            }
        }
    }
}