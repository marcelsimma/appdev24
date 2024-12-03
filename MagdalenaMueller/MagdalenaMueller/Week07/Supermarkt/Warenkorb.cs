using System;

namespace MagdalenaMueller.Week07
{
    public class Warenkorb
    {
        
        public static void CreateWarenkorb(Dictionary<string,double> warenkorb)
        {
            Dictionary<string, double> produkts = Produkte.ProdukteList(); 

            var r = new Random();

            int addItem = r.Next(1, 11); 

            for (int i = 0; i < addItem; i++)
            {
                int randomIndex = r.Next(0, produkts.Count);

                var product = new List<string>(produkts.Keys)[randomIndex];
                var price = produkts[product];

                if (!warenkorb.ContainsKey(product))
                {
                    warenkorb.Add(product, price);
                }
                else
                {
                    i--;
                }
            }
        }

        public static void ShowWarenkorb(Dictionary<string,double> warenkorb)
        {
            double price = 0;
            Console.WriteLine("\nWarenkorb:");
            foreach (var item in warenkorb)
            {
                Console.WriteLine($"{item.Key}: {item.Value} EUR");
                price += item.Value;
            };
            Console.WriteLine("Kosten: "+ price.ToString("F2") + "EUR");
        }
    }
}