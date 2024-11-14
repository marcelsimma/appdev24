using System;

namespace OliverBedogg.Week05
{
    // Klasse
    public class Motorrad
    {
        // Attribute
        int _kmStand;
        bool _inBewegung = false;

        // Konstruktor
        public Motorrad(int kmStand)
        {
            _kmStand = kmStand;
        }

        // Methoden
        public void fahre(int kilometer)
        {
            _kmStand += kilometer;
            _inBewegung = true;

            Console.WriteLine($"Motorrad fährt {kilometer}km.");
        }
        public void stop()
        {
            _inBewegung = false;
        }
        public string faehrt()
        {
            if (_inBewegung)
            {
                return "Ja";
            }
            else
            {
                return "Nein";
            }
        }

        public override string ToString()
        {
            return string.Format("{0} km", _kmStand);
        }
    }
}