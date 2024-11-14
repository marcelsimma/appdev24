using System;

namespace FlorianBaier.Week06
{
    // Klasse Auto erbt von Fahrzeug
    public class Auto : Fahrzeug
    {
        public Auto() : base(4) // Ein Auto hat normalerweise 4 Räder
        {
        }

        public void Fahren()
        {
            Console.WriteLine("Das Auto fährt.");
        }
    }
}