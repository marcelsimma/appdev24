using System;
using System.ComponentModel;

namespace CheyenneHarbarth.Week07.Supermarket
{
    internal class Checkout
    {
        internal string Checkoutnumber { get; set; }
        internal Queue<Costumer> CostumersWaiting = new Queue<Costumer>();
        internal bool isopen = false;

        internal Checkout(string _checkoutnumber)
        {
            Checkoutnumber = _checkoutnumber;
        }

        internal void CheckoutOpens(Employee e)
        {
            while (true)
            {
                if (e.Available == true)
                {
                    e.Available = false;
                    isopen = true;
                }
                else
                {
                    Console.WriteLine($"{e.employeename} ist momentan nicht verfügbar, rufe einen anderen Mitarbeiter!\n");

                }
            }
        }
        internal void CheckoutCloses()
        {
            isopen = false;
        }
        internal void AddWaitingCostumer(Costumer c)
        {
            if (isopen == true)
            {
                CostumersWaiting.Enqueue(c);
            }
            else
            {
                Console.WriteLine($"Kassa {Checkoutnumber} hat momentan geschlossen!");
            }
        }
        internal void StartCheckout(Employee e, Dictionary<Product, int> products)
        {
            while (CostumersWaiting.Count > 0)
            {
                foreach (Costumer c in CostumersWaiting)
                {
                    c.PayForShoppingCart(products);
                    e.HandReceipt();
                    CostumersWaiting.Dequeue();
                }
            }
        }
    }
}