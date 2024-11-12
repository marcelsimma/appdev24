using System;

namespace SimonJochum.Week05
{
    public class Camera
    {

        string _Brand;
        string _Model;
        int _BrennweiteMin;
        int _BrennweiteMax;
        double _Megapixel;

        public string Brand
        {
            set => _Brand = value;
        }

        public string Model
        {
            set => _Model = value;
        }

        public double Megapixel
        {
            get => _Megapixel;
            set => _Megapixel = value;
        }

        public int BrennweiteMin
        {
            get => _BrennweiteMin;
            set => _BrennweiteMin = value;
        }

        public int BrennweiteMax
        {
            get => _BrennweiteMax;
            set => _BrennweiteMax = value;
        }

        public string CameraWhoTookPhoto()
        {
            return "Dieses Foto wurde von der Kamera \"" + _Brand + " " + _Model + "\" aufgenommen.";
        }
        public Camera(string brand, string model, int brennweiteMin, int brennweiteMax, double megapixel)
        {
            _Brand = brand;
            _Model = model;
            _BrennweiteMin = brennweiteMin;
            _BrennweiteMax = brennweiteMax;
            _Megapixel = megapixel;
        }
        public Camera(string brand, string model, double megapixel)
        {
            _Brand = brand;
            _Model = model;
            _Megapixel = megapixel;
        }
        public string takePhoto()
        {
            return @"
         ☻    
        /|\ 
        / \ 
        ";
    
        }

        public string takeBiggerPhoto()
        {
            return @"
             _
            (_)
            /|\
           / | \
          /  |  \
            / \
           /   \
           ";
        }

        public override string ToString()
        {
            return string.Format("Das Modell " + _Model + " kommt von " + _Brand + " und hat " + _Megapixel + "\'MP\'"); // mit einer minimalen Brennweite von " + _BrennweiteMin + "mm bis zur maximalen Brennweite von " + _BrennweiteMax + "mm.
        }

        public string GetToString()
        {
            return string.Format("Das Modell " + _Model + " kommt von " + _Brand + " und hat " + _Megapixel + "\'MP\'");
        }

    }
    public class Objektiv
    {
        string _Name;
        int _Brennweite;

        public int Brennweite
        {
            get => _Brennweite;
            set => _Brennweite = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public Objektiv(string name, int brennweite)
        {
            _Name = name;
            _Brennweite = brennweite;
        }

        public override string ToString()
        {
            return string.Format(", mit dem Objektiv {0} welches eine Brennweite von {1}mm hat", _Name, _Brennweite);
        }
    }

    public class Speicherkarte
    {
        string _Name;
        int _SpeicherVolumenInsgesamt;
        int _SpeicherVolumenVerbraucht;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public int SpeicherVolumenInsgesamt
        {
            get => _SpeicherVolumenInsgesamt;
            set => _SpeicherVolumenInsgesamt = value;
        }

        public int SpeicherVolumenVerbraucht
        {
            get => _SpeicherVolumenVerbraucht;
            set => _SpeicherVolumenVerbraucht = value;
        }

        public Speicherkarte(string name, int speicherVolumenInsgesamt, int speicherVolumenVerbraucht)
        {
            _Name = name;
            _SpeicherVolumenInsgesamt = speicherVolumenInsgesamt;
            _SpeicherVolumenVerbraucht = speicherVolumenVerbraucht;
        }

        public override string ToString()
        {
            return string.Format(" und die Speicherkarte von {0} hat eine Größe von {1}GB von denen {2}GB belegt sind.", _Name, _SpeicherVolumenInsgesamt, _SpeicherVolumenVerbraucht);
        }
    }
}