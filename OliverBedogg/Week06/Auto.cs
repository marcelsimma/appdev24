using System;

namespace OliverBedogg.Week06
{
    // Klasse
    public class Auto : Fahrzeug
    {
        public Auto(int kmStand) : base(kmStand)
        {

        }

        // Methoden
        public void fahren()
        {
            Console.WriteLine($"Auto fährt auf {anzahlRaeder} Rädern.");
        }

        public override void service()
        {
            Console.WriteLine($"Auto-Service");
        }
    }
}