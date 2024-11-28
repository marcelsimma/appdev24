using System;

namespace BerkantAkinci.Week07.Supermarket
{
    public class Customer
    {
        public string CustomerNumber;
        public string PayMethod;

        public Customer(string customerNumber, string payMethod)
        {
            CustomerNumber = customerNumber;
            PayMethod = payMethod;
        }

        public void Payment()
        {

        }
    }
}