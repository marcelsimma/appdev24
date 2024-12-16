using System;
namespace JulianStroehle.Week10
{
    internal class Animal
    {
        internal string Name;
        internal string Type;
        internal int ID;
        internal Dictionary<Food, int> SumFood;
        internal Animal(string name, string type, int id)
        {
            Name = name;
            Type = type;
            ID = id;
            SumFood = new Dictionary<Food, int>();
        }
        internal string GetInfo()
        {
            string returnValue = string.Format("{0} {1}: {2}", ID, Type, Name);
            foreach (Food food in SumFood.Keys)
            {
                returnValue += "\n│        └── " + string.Format("{0, -13}", food.Name) + string.Format("{0,5}", SumFood[food]) + string.Format("{0,-5}", " " + food.Unit) + string.Format("{0,10}", Math.Round(food.GetPrice(SumFood[food]), 2) + " €");
            }
            return returnValue;
        }
    }
}