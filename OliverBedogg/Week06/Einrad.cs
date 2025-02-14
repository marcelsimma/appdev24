using System;

namespace OliverBedogg.Week06
{
    // Sub-Klasse von Fahrzeug
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