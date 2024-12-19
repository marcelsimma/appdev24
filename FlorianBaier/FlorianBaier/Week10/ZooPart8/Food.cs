using System;

namespace FlorianBaier.Week10.ZooPart8
{
    internal class Food
    {
        internal string Name;
        internal string Unit;
        internal int Amount;
        internal double PricePerUnit;
        internal int InvoiceNumber;
        internal Food(string name, string unit, int amount, double pricePerUnit, int invoiceNumber)
        {
            Name = name;
            Unit = unit;
            Amount = amount;
            PricePerUnit = pricePerUnit;
            InvoiceNumber = invoiceNumber;
        }
        internal double GetPrice(int count)
        {
            return PricePerUnit * count;
        }
    }
}