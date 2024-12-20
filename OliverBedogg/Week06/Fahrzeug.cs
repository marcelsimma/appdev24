using System;

namespace OliverBedogg.Week06
{
    // Abstrakte Klasse
    public abstract class Fahrzeug
    {
        // Attribute
        protected int _kmStand;
        protected int anzahlRaeder = 4;

        // Konstruktor
        public Fahrzeug(int kmStand)
        {
            _kmStand = kmStand;
        }

        // Methoden
        public void fahren(int kilometer)
        {
            // Implementierung der Bewegung
            _kmStand += kilometer;

            Console.WriteLine($"Fahrzeug fährt {kilometer}km.");
        }

        // Abstrakte Methode
        public abstract void service();

        public override string ToString()
        {
            return string.Format("{0} km", _kmStand);
        }
    }
}