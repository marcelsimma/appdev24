using System;

namespace CheyenneHarbarth.Week05.OOP.Fotoapparat
{
    public interface IObjekt
    {
        public string Inventorynumber { get; }

        public double Price { get; protected set; }
    }
}