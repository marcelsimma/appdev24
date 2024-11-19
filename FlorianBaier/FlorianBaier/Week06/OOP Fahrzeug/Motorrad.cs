using System;

namespace FlorianBaier.Week06
{
    // Klasse Motorrad erbt von Fahrzeug
    public class Motorrad : Fahrzeug
    {
        public Motorrad() : base(2) // Ein Motorrad hat normalerweise 2 Räder
        {
        }

        public void Fahren()
        {
            Console.WriteLine("Das Motorrad fährt.");
        }
    }
}