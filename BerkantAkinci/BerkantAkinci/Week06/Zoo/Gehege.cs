using System;

namespace BerkantAkinci.Week06.Zoo
{

    public class Gehege
    {

        private string _name;

        public string _Name
        {
            get => _name;
            set => _name = value;
        }

        public Gehege(string name)
        {
            _name = name;
        }
        
    }
}