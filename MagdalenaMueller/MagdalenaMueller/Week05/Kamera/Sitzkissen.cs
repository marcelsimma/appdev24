using System;

namespace MagdalenaMueller.Week05
{
    public class Sitzkisse : IGegenstand
    {
        public string inventarNumber {get; set;}
        public int costs{get; set;}

        public Sitzkisse(string InventarNumber, int Costs)
        {
            inventarNumber = InventarNumber;
            costs = Costs;
        }

        public string PrintInventarnummer()
        {
            return $"Sitzkissen:";
        }

    }
}