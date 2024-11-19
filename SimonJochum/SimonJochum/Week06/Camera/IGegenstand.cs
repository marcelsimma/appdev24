using System;

namespace SimonJochum.Week06.Camera
{
    public interface IGegenstand
    {
        public string Inventarnummer { get; set; }

        public int Anschaffungswert {get; set;}

        public string PrintInventarnummer();

        public int PrintAnschaffungswert();
    }
}
