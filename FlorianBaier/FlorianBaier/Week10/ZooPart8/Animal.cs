using System;

namespace FlorianBaier.Week10.ZooPart8
{
    internal class Animal: IOutput
    {
        internal string Name;
        internal string Type;
        internal int ID;
        internal int Health;
        internal int Attack;
        internal Dictionary<Food, int> SumFood;
        internal Animal(string name, string type, int id)
        {
            Random rdm = new Random();
            Name = name;
            Type = type;
            ID = id;
            Health = 100;
            Attack = rdm.Next(1, 31);
            SumFood = new Dictionary<Food, int>();
        }
        public string GetInfo()
        {
            string returnValue = string.Format("{0}: {1} - Health: {2}", Type, Name, Health);
            foreach (Food food in SumFood.Keys)
            {
                returnValue += "\n│        └── " + string.Format("{0, -13}", food.Name) + string.Format("{0,5}", SumFood[food]) + string.Format("{0,-5}", " " + food.Unit) + string.Format("{0,10}", Math.Round(food.GetPrice(SumFood[food]), 2) + " €");
            }
            return returnValue;
        }
        public string GetIDs()
        {
            return Convert.ToString(ID);
        }
    }
}