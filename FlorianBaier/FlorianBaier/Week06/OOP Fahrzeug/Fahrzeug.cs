using System;

namespace FlorianBaier.Week06
{
    public class Fahrzeug
    {
        public int AnzahlRaeder { get; set; }

        // Konstruktor der Basisklasse
        public Fahrzeug(int anzahlRaeder)
        {
            AnzahlRaeder = anzahlRaeder;
        }

        // Eine Methode, die die Anzahl der Räder ausgibt
        public void Print()
        {
            Console.WriteLine($"Dieses Fahrzeug hat {AnzahlRaeder} Räder.");
        }
    }
}