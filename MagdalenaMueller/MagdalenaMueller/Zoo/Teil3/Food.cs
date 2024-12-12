using System;

namespace MagdalenaMueller.Zoo
{
    public class Food
    {
        internal string FoodName;
        internal string Unit;
        internal double PricePerUnit;

        
        public Food(string foodName,string unit,double pricePerUnit)
        {
            FoodName = foodName;
            Unit = unit;
            PricePerUnit = pricePerUnit;
        }
    }
}