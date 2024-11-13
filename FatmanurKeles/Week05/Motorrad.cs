using System;

namespace FatmanurKeles.Week05
{
    public class Motorrad
    {
        // Attribute werden bestimmt

        int _kmStand;
        bool _inBewegung = false;

        // Konstruktor
        public Motorrad(int kmStand)
        {
            _kmStand = kmStand;
        }

        // Methoden
        public void fahre(int kilometern)
        {
            _kmStand += kilometern;
            _inBewegung = true;

            Console.WriteLine();
        }
    }
}