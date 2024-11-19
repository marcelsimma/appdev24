using System;
namespace JulianStroehle.Week5.Fotoapparat
{
    public class Objektiv : Hardware, IInv
    {
        public string InvNr { get; set; }
        public double Price { get; set; }
        public int _zoom;
        public Objektiv(int zoom, string InvNr, double price)
        {
            this.InvNr = InvNr;
            _zoom = zoom;
            Price = price;
        }
        public void GetInvNr()
        {
            Console.WriteLine(string.Format("{0,-15}", InvNr) +"│" + string.Format("{0,10}", Price) + "€");
        }
        public override string ToString()
        {
            return string.Format("Objektiv mit {0} fachem Zoom.", _zoom);
        }
    }
}