using System;

namespace BerkantAkinci.Week06.PKW
{
    // Sub-Klasse von Fahrzeug
    public class Motorrad : Fahrzeug, IVerbraucher
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

        // von Interface vorgegebene Methode
        public void verbrauchProKilometer()
        {
            Console.WriteLine($"Das Motorrad verbraucht x Liter pro Kilometer.");
        }
    }
}