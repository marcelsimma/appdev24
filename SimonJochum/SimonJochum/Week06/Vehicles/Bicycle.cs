using System;

namespace SimonJochum.Week06.Vehicles
{
    public class Bicycle : Vehicle
    {
        public string AmountPedals {get; set;}

         public Bicycle (string name, string amountTires, string amountPedals)
        {
            Name = name;
            AmountTires = amountTires;
            AmountPedals = amountPedals;
        }

        public override string Drive()
        {
            return base.Drive() + $"Ich habe {AmountTires} Räder und verbrauche dabei kein Kraftstoff.";
        }
    }
}