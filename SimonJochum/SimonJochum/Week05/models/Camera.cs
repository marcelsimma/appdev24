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
        public string takePhoto()
        {
            return @"
         O  
        /|\ 
        / \ 
        ";
        }

        public override string ToString()
        {
            return string.Format("Das Modell " + _Model + " kommt von " + _Brand + " und hat " + _Megapixel +"\'MP\' mit einer minimalen Brennweite von " + _BrennweiteMin + "mm bis zur maximalen Brennweite von " + _BrennweiteMax + "mm.");
        }
    }
}