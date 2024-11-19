using System;

namespace MagdalenaMueller.Week05
{
    public class Tisch : IGegenstand
    {
        public string inventarNumber {get; set;}
        public int costs{get; set;}

        public Tisch(string InventarNumber, int Costs)
        {
            inventarNumber = InventarNumber;
            costs = Costs;
        }

        public string PrintInventarnummer()
        {
            return $"Tisch:";
        }

    }
}