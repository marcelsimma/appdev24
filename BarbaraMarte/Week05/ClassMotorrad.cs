using System;
namespace BarbaraMarte.Week05
{

    class Motorcycle
    {
        bool _Drive;
        int _KM;

        public int KM
        {
            get => _KM;
        }
        public bool drive
        {

        }
        public Motorcycle(string motorcycleName, int km)
        {
            _MotorcycleName = motorcycleName;
            _KM = km;
        }
        public override string ToString()
        {
            return string.Format("Motorcycle Name: {0}, KM {2}", _MotorcycleName, _KM);
        }

    }
}