using System;

namespace OliverBedogg.Week06
{
    // Klasse
    public class Motorrad : Fahrzeug
    {

        public Motorrad(int kmStand) : base(kmStand)
        {
            anzahlRaeder = 2;
        }

        public void fahren(int kilometer)
        {
            Console.WriteLine($"Motorrad fährt auf {anzahlRaeder} Rädern.");
            // z. B. Verbrauch implementieren

            base.fahren(kilometer);
        }

        public override void service()
        {
            Console.WriteLine($"Motorrad-Service");
        }
    }
}