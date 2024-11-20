using System;
namespace JulianStroehle.Week5.Fotoapparat
{
    public interface IInv
    {
        public string InvNr { get; set; }
        public double Price { get; set;}
        public void GetInvNr();
    }
}