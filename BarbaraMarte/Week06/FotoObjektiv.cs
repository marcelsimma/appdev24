using System;

namespace BarbaraMarte.Week06
{
    class Camera
    {
        double _BrennweiteMin;

        double _BrennweiteMax;
        string? _Producer;
        double _Megapixel;
        string _CameraName;
        public string CameraName
        {
            get => _CameraName;
            set => _CameraName = value;
        }

        public double BrennweiteMin
        {
            get => _BrennweiteMin;
            set => _BrennweiteMin = value;
        }
        public double BrennweiteMax
        {
            get => _BrennweiteMax;
            set => _BrennweiteMax = value;
        }
        public string Producer
        {
            get => _Producer;
            set => _Producer = value;
        }
        public double Megapixel
        {
            get => _Megapixel;
            set => _Megapixel = value;
        }

        public Camera(double brennweiteMin, double brennweiteMax, string producer, double megapixel, string cameraName)
        {
            _BrennweiteMax = brennweiteMax;
            _BrennweiteMin = brennweiteMin;
            _Producer = producer;
            _Megapixel = megapixel;
            _CameraName = cameraName;
        }
        public string TakePhoto()
        {
            return @" 
             /)_/)
            („>.<)
            / > <3           
            
            ";
        }
        public string CameraUseZoom()
        {
            return @"
             /)_/)      (\_(\
            („>.<)      (>.<„)
            / > <3        >< \
            ";
        }

        public override string ToString()
        {
            return string.Format($"Der Produzent der Kamera {_CameraName} ist {_Producer}.  Die Min. Brennweite ist: {_BrennweiteMin}, die Max. Brennweite ist: {_BrennweiteMax}");
        }
    }

    /*
        class Objektiv
        {
            double _BrennweiteMin;

            double _BrennweiteMax;
            string? _Producer;
            double _Megapixel;
            string _CameraName;
            public string CameraName
            {
                get => _CameraName;
                set => _CameraName = value;
            }

            public double BrennweiteMin
            {
                get => _BrennweiteMin;
                set => _BrennweiteMin = value;
            }
            public double BrennweiteMax
            {
                get => _BrennweiteMax;
                set => _BrennweiteMax = value;
            }
            public string Producer
            {
                get => _Producer;
                set => _Producer = value;
            }
            public double Megapixel
            {
                get => _Megapixel;
                set => _Megapixel = value;
            }

            public Camera(double brennweiteMin, double brennweiteMax, string producer, double megapixel, string cameraName)
            {
                _BrennweiteMax = brennweiteMax;
                _BrennweiteMin = brennweiteMin;
                _Producer = producer;
                _Megapixel = megapixel;
                _CameraName = cameraName;
            }
        }*/
    class Speicherkarte
    {

    }
}