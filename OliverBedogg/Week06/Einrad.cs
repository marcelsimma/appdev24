using System;

namespace OliverBedogg.Week06
{
    // Klasse
    public class Einrad : Fahrzeug
    {
        protected new int anzahlRaeder = 1;

        public Einrad(int kmStand) : base(kmStand)
        {

        }

        // Methoden
        public void fahren()
        {
            Console.WriteLine($"Einrad fährt auf {anzahlRaeder} Rad.");
        }

        public override void service()
        {
            // kein service notwendig
        }
    }
}