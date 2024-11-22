using System;
using FatmanurKeles.Week06.ZOO;

namespace FatmanurKeles.Week06.AufgabeZoo
{
    public class Zoo
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Gruendungsjahr;

        public Gehege Bereich;
        
        public string Place;

        public Zoo(string name, int gruendungsjahr, Gehege bereich, string place)
        {
            _name = name;
            Gruendungsjahr = gruendungsjahr;
            Bereich = bereich;
            Place = place;
        }

        public override string ToString()
        {
            return
            String.Format(
            @"
            Datenblatt Kamera: 
            
            Name: {0}
            Gruendungsjahr: {1}
            Gehege: {2}
            Ort:  {3}

            "
            , _name, Gruendungsjahr, Bereich, Place );
            
        }
        
    }
}