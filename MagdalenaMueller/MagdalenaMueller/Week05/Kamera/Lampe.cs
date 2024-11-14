using System;

namespace MagdalenaMueller.Week05
{
   public class Lampe : IGegenstand
   {
        public string inventarNumber{get; set;}
        public int costs{get; set;}

        public Lampe(string _inventarNumber, int _costs)
        {
            inventarNumber = _inventarNumber;
            costs = _costs;
        }
        public string PrintInventarnummer()
        {
            return "Lampe: ";
        }
   } 
}