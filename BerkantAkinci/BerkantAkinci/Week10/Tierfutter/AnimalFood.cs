using System;

namespace BerkantAkinci.Week10
{
    public class AnimalFood
    {
        public string FoodName;
        public string Unit;
        public double UnitPrice;

        public AnimalFood(string foodName, string unit, double unitPrice)
        {
            FoodName = foodName;
            Unit = unit;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return $"{FoodName}, {Unit}, {UnitPrice}";
        }


    }
}