using System;

namespace SimonJochum.Week06.Vehicles
{
    public class Monocycle : Vehicle
    {
        public string AmountPedals {get; set;}

        public Monocycle (string name, string amountTires, string amountPedals)
        {
            Name = name;
            AmountTires = amountTires;
            AmountPedals = amountPedals;
        }

        public override string Drive()
        {
            return base.Drive() + $"Ich habe {AmountTires} Rad und verbrauche dabei kein Kraftstoff.";
        }
    }
}