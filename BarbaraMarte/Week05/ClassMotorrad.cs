using System;
namespace BarbaraMarte.Week05
{

    class Motorcycle
    {
        bool _Drive = false;
        int _kmStand;

        public int KM
        {
            get => _kmStand;
        }
        public Motorcycle(int kmStand)
        {
            _kmStand = kmStand;
        }
        public void Drive(int km)
        {
            _kmStand += km;
            _Drive = true;
            Console.WriteLine("The motorcycle drives " + km + " km");
        }
        public void Stop() 
        {
            _Drive = false;
        }
        public string Drives()
        {
            if (_Drive)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        public override string ToString()
        {
            return string.Format("{0} km" + _kmStand);
        }

    }
}