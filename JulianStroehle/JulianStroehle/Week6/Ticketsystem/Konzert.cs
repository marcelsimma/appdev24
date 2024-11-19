using System;
namespace JulianStroehle.Week6.Ticketsystem
{
    internal class Konzert
    {
        internal enum Name
        {
            Rammstein,
            SkiAggu,
            Metallica,
            Slipknot,
            Raizhell,
            Skorde
        }
        private int _index;
        internal Konzert(int index)
        {
            _index = index;
        }
        public override string ToString()
        {
            return $"{(Name)_index-1}";
        }
    }
}