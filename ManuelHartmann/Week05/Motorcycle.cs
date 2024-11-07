using System;

namespace ManuelHartmann.Week05
{
    // Klasse
    public class Motorcycle
    {
        // Attribute
        int _MileageSet;
        bool _InMotion = false;

        // Konstruktor
        public Motorcycle(int mileageSet)
        {
            _MileageSet = mileageSet;
        }
        // // getter mit erweiterter Rückgabe des Attributwerts
        // public string MileageSet
        // {
        //     get => "gefahrene Kilometer: " + _MileageSet;
        // }

        // Methoden
        public void fahre(int mileage)
        {
            _MileageSet += mileage;
            _InMotion = true;
            
            Console.WriteLine($"Motorrad fährt {mileage}km/h.");
        }
        public void stop()
        {
            _InMotion = false;
        }
        public string faehrt()
        {
            if (_InMotion)
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
            return string.Format("{0} km", _MileageSet);
        }
    }
}