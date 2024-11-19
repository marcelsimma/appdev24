using System;

namespace SimonJochum.Week06.Vehicles
{
    public class Car : Vehicle
    {
        public double FuelUsed {get; set;}

        public Car (string name, string amountTires, double fuelUsed)
        {
            Name = name;
            AmountTires = amountTires;
            FuelUsed = fuelUsed;
        }

        public override string Drive()
        {
            return base.Drive() + $"Ich habe {AmountTires} Räder und verbrauche dabei im Schnitt {FuelUsed}l Benzin auf 100km.";
        }
    }
}