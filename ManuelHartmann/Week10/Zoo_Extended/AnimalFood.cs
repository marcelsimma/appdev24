using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week10.Zoo_Extended
{
    public class AnimalFood
    {
        public string IdAnimalFood { get; private set; }
        public string NameFood { get; private set; }
        public double Amount { get; private set; }
        public string Unit { get; private set; }
        public double UnitPrice { get; private set; }

        public AnimalFood(string idAnimalFood, string nameFood, double amount, string unit, double unitPrice)
        {
            IdAnimalFood = idAnimalFood;
            NameFood = nameFood;
            Amount = amount;
            Unit = unit;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return

            String.Format(
            @"{0, 12} {1, -10} {2, -8}"

            , NameFood, Unit, UnitPrice);
        }
    }
}
