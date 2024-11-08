using System;

namespace SimonJochum.Week05
{
    public class Motorcycle
    {
        string _Motorcycle;
        int _Kilometerstand;
        bool _InBewegung;
        int _Distance;
        string Bewegung = "steht";

        public Motorcycle(string motorcycle, int kilometerstand)
        {
            _Motorcycle = motorcycle;
            _Kilometerstand = kilometerstand;
        }

        public void Fahre(int distance)
        {
            _Distance = distance;
            _Kilometerstand += _Distance;
        }

        public void Faehrt()
        {
            _InBewegung = true;
            if(_InBewegung == true)
            {
                Bewegung = "fährt";
            }
        }
        
        public void Stop()
        {
            _InBewegung = false;
             if(_InBewegung == false)
            {
                Bewegung = "steht";
            }
        }

        public override string ToString()
        {
            
            return string.Format("Das {0} {1} und hat eine Distanz von {2} km zurückgelegt. Der neue Kilometerstand beträgt {3}", _Motorcycle, Bewegung, _Distance, _Kilometerstand);
        }
    }
}