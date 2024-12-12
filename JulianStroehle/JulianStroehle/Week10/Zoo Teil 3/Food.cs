using System;
namespace JulianStroehle.Week10
{
    internal class Food
    {
        internal string Name;
        internal string Unit;
        internal double PricePerUnit;
        internal int InvoiceNumber;
        internal Food(string name, string unit, double pricePerUnit, int invoiceNumber)
        {
            Name = name;
            Unit = unit;
            PricePerUnit = pricePerUnit;
            InvoiceNumber = invoiceNumber;
        }
        internal double GetPrice(int count)
        {
            return PricePerUnit * count;
        }
    }
}