using System;

namespace MagdalenaMueller.Week07
{
    public class StartSupermarkt
    {
        public static void Start()
        {
            Dictionary<string,double> warenkorb1 = new Dictionary<string, double>();
            Dictionary<string,double> warenkorb2 = new Dictionary<string, double>();
            Dictionary<string,double> warenkorb3 = new Dictionary<string, double>();

            Warenkorb.CreateWarenkorb(warenkorb1);
            Warenkorb.CreateWarenkorb(warenkorb2);
            Warenkorb.CreateWarenkorb(warenkorb3);

            /*Warenkorb.ShowWarenkorb(warenkorb1);
            Warenkorb.ShowWarenkorb(warenkorb2);
            Warenkorb.ShowWarenkorb(warenkorb3);*/

            Kassen.SellProdukts1(warenkorb1);
        }
    }
}