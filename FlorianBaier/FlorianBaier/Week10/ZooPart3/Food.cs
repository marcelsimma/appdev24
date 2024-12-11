using System;
using System.Collections.Generic;

namespace FlorianBaier.Week10.ZooPart3
{
    public class Food
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }

        public Food(string name, string unit, double unitPrice)
        {
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
        }
    }
}