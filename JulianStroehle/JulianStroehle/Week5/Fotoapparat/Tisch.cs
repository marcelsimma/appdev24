using System;
namespace JulianStroehle.Week5.Fotoapparat
{
    public class Tisch : Hardware, IInv
    {
        int _length;
        int _width;
        int _height;
        public double Price { get; set; }
        public string InvNr { get; set; }
        public Tisch(string invNr, int length, int width, int height, double price)
        {
            InvNr = invNr;
            _length = length;
            _width = width;
            _height = height;
            Price = price;
        }
        public void GetInvNr()
        {
            Console.WriteLine(string.Format("{0,-15}", InvNr) +"│" + string.Format("{0,10}", Price) + "€");
        }
    }
}