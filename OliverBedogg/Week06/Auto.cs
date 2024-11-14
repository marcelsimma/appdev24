using System;

namespace OliverBedogg.Week06
{
    // Sub-Klasse von Fahrzeug
    public class Auto : Fahrzeug, IVerbraucher
    {
        double _tankinhalt;
        double _verbrauchProKilometer; // Liter

        public Auto(int kmStand, double verbrauchProKilometer) : base(kmStand)
        {
            _verbrauchProKilometer = verbrauchProKilometer;
        }

        // Methoden
        public void fahren()
        {
            Console.WriteLine($"Auto fährt auf {anzahlRaeder} Rädern.");
            Console.WriteLine($"Der Kilometerstand zu Beginn ist: {_kmStand} km");
        }

        // von Base-Klasse vorgegebene Methode
        public override void service()
        {
            Console.WriteLine($"Auto-Service");
        }

        // von Interface vorgegebene Methode
        public void verbrauchProKilometer()
        {
            Console.WriteLine($"Das Auto verbraucht {_verbrauchProKilometer} Liter pro Kilometer.");
        }
    }
}