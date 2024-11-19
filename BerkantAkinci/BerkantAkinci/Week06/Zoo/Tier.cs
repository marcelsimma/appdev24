using System;

namespace BerkantAkinci.Week06.Zoo
{
    public class Tier
    {
        public string _Name;

        public string _Gattung;

        public Tier(string name, string gattung)
        {
            _Name = name;
            _Gattung = gattung;
        }

         public override string ToString()
        {
            return String.Format(_Name + ", " + _Gattung);
        }
    }
}