using System;

namespace SimonJochum.Week06.Camera
{
    public class Hardware
    {
        public string Model;
        public string Brand;
        public string SerialNumber;



        public virtual string WriteSerialNumber()
        {
            return "Seriennummer: "+ SerialNumber;
        }
    }
}