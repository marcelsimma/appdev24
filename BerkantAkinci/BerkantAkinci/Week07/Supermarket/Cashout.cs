using System;
using System.Runtime.InteropServices.Marshalling;

namespace BerkantAkinci.Week07.Supermarket
{
    public class Cashout
    {
        public string CashoutNumber;
        public bool CashoutIsOpen;
        Queue<Customer> WaitingLine = new Queue<Customer>();

        public Cashout(string cashoutNumber, bool cashoutIsOpen)
        {
            CashoutNumber = cashoutNumber;
            CashoutIsOpen = cashoutIsOpen;
        }

        public void Closes()
        {

        }

        public void Opens()
        {

        }

        public void Sell()
        {

        }

        public void WaitingCustomer()
        {

        }

    }
}