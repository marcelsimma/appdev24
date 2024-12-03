using System;

namespace MagdalenaMueller.Week05
{
    public class Kamera : IGegenstand
    {
        public string inventarNumber {get; set;}
        public int costs {get; set;}
        public string model;
        public string hersteller;
        public static int brennweite;
        public int megapixel;

        public Kamera( string Model, string Hersteller, int Brennweite,int Megapixel,string InventarNumber, int Costs)
        {
            model = Model;
            hersteller = Hersteller;
            brennweite = Brennweite;
            megapixel = Megapixel;
            inventarNumber = InventarNumber;
            costs = Costs;
        }
        public void TakePhoto()
        {
            Console.WriteLine(@"    ______       /------\     ");
            Console.WriteLine(@"____|    |______/        \____");
            Console.WriteLine(@"|                  _____      |");
            Console.WriteLine(@"|                 /     \     |");
            Console.WriteLine(@"|                |       |    |");
            Console.WriteLine(@"|                 \     /     |");
            Console.WriteLine(@"|                   ---       |");
            Console.WriteLine(@"-------------------------------");
        }
        public override string ToString()
        {
            return $"Model: {model} Hersteller: {hersteller} Brennweite: {brennweite} Megapixel: {megapixel}";
        }
        public string PrintInventarnummer()
        {
            return $"Kamera:";
        }
    }
}