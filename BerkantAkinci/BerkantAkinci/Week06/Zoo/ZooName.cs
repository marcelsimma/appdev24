using System;
using System.Reflection.Metadata.Ecma335;

namespace BerkantAkinci.Week06.Zoo
{

    public class ZooName
    {
        private string _name;
        public string _Name
        {
            get => _name;
            set => _name = value;
        }

        private int _gruendungsjahr;
        public int _Gruendungsjahr
        {
            get => _gruendungsjahr;
            set => _gruendungsjahr = value;
        }

        public ZooName(string name, int gruendungsjahr)
        {
            _name = name;
            _gruendungsjahr = gruendungsjahr;
        }
    }
}