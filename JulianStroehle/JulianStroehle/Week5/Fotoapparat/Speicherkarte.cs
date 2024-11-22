using System;
namespace JulianStroehle.Week5.Fotoapparat
{
    public class Speicherkarte : Hardware, IInv
    {
        public string InvNr { get; set; }
        public double Price { get; set; }
        public double Memory;
        double _memoryMax;
        public int Photos;
        public Speicherkarte(double memory, double memoryMax, string invNr, double price)
        {
            Memory = memory;
            _memoryMax = memoryMax;
            InvNr = invNr;
            Price = price;
        }
        public void GetInvNr()
        {
            Console.WriteLine(string.Format("{0,-15}", InvNr) +"│" + string.Format("{0,10}", Price) + "€");
        }
        public bool CheckMemory()
        {
            return Memory < _memoryMax;
        }
        public override string ToString()
        {
            return string.Format("Verbleibender Speicherplatz: {0}GB\nGespeicherte Bilder: {1}", Math.Round(_memoryMax - Memory, 2), Photos);
        }
    }
}