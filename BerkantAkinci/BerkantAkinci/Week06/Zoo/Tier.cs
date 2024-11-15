using System;

namespace BerkantAkinci.Week06.Zoo
{

    public class Tier
    {
        private string _name;
        public string _Name
        {
            get => _name;
            set => _name = value;
        }

        private string _gattung;
        public string _Gattung
        {
            get => _gattung;
            set => _gattung = value;
        }

        public Tier(string name, string gattung)
        {
            _name = name;
            _gattung = gattung;
        }


    }
}