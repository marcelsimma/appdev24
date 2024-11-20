using System;
namespace JulianStroehle.Week5.Fotoapparat
{
    public class Sitzkissen : Hardware, IInv
    {
        int _size;
        string _filling;
        public double Price { get; set; }
        public string InvNr { get; set; }
        public Sitzkissen(string invNr, string filling, int size, double price)
        {
            InvNr = invNr;
            _filling = filling;
            _size = size;
            Price = price;
        }
        public void GetInvNr()
        {
            Console.WriteLine(string.Format("{0,-15}", InvNr) +"│" + string.Format("{0,10}", Price) + "€");
        }
    }
}