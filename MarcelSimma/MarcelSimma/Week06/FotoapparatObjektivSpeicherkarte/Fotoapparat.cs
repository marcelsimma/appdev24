using System;

namespace MarcelSimma.Week06.FotoapparatObjektivSpeicherkarte
{

    public class Fotoapparat : Hardware
    {

        public int _minBrennweite;

        public int _MinBrennweite
        {
            get {return _minBrennweite;}
            set => _minBrennweite = value > 20 ? value : 20;
        }

        public int _MaxBrennweite;
        public string _Hersteller { get; }

        public int Megapixel { get; set; }


        public Fotoapparat(string seriennummer, int brennweite, string hersteller) : base(seriennummer)
        {
            _MinBrennweite = brennweite;
            _Hersteller = hersteller;

        }


        public override string ToString()
        {
            return ("Geiler Fotoapparat mit Brennweite + " + _MinBrennweite + " und " + _Hersteller + " und Seriennummer " + Seriennummer);

        }

    }
}