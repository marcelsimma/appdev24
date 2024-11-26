using System;
using System.Diagnostics.Metrics;

namespace MagdalenaMueller.Week07
{
    public class Kassen
    {
        static Queue<string> kasse1 = new Queue<string>();
        static Queue<string> kasse2 = new Queue<string>();
        static Queue<string> kasse3 = new Queue<string>();

        static List<string> Zahlungmittel = new List<string>();

        public static void SellProdukts1(Dictionary<string, double> warenkorb)
        {
            Console.Clear();
            
            var r = new Random();
            int kasse = r.Next(1, 2 );

            int counter = 0;

            if (kasse == 1)
            {
                kasse1.Enqueue("|"); 
                counter++;
            }

            double price1 = 0;
            foreach (var item in warenkorb)
            {
                price1 += item.Value;
            }
            foreach (var people in kasse1)
            {
                Console.Write("Kasse1: ");
                Console.Write(people);
            }
            Console.WriteLine();

            Thread.Sleep(1000);
            kasse1.Dequeue();
            Console.Clear();
            Console.WriteLine("Kasse1: " + price1);

            if(counter > 0) {Console.WriteLine("Zahlungsmittel: Barzahlung");}
            else {Console.WriteLine("Zahlungsmittel: Karte");}
            Thread.Sleep(1000);
        }
    }
}