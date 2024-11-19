using System;
using System.Text;
namespace JulianStroehle.Week5.Fotoapparat
{
    public class FotoapparatOOP
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double value = 0;
            Speicherkarte speicherkarte = new Speicherkarte(0, 256, "123ABC", 69.99);
            Objektiv objektiv= new Objektiv(5, "124ABC", 120.99);
            Fotoapparat fotoapparat = new Fotoapparat("D-Lux 8", "Leica", 17, speicherkarte, objektiv, "125ABC", 599.99);
            Speicherkarte speicherkarte2 = new Speicherkarte(0, 256, "123ABD", 69.99);
            Objektiv objektiv2= new Objektiv(3, "124ABD", 99.99);
            Fotoapparat fotoapparat2 = new Fotoapparat("D-Lux 7", "Leica", 17, speicherkarte2, objektiv2, "125ABD", 399.99);
            Speicherkarte speicherkarte3 = new Speicherkarte(0, 128, "123ABF", 39.99);
            Objektiv objektiv3= new Objektiv(1, "124ABF", 69.99);
            Fotoapparat fotoapparat3 = new Fotoapparat("D-Lux 6", "Leica", 12.7, speicherkarte3, objektiv3, "125ABF", 199.99);
            Tisch tisch= new Tisch("126ABC", 50, 70, 60, 150.59);
            Tisch tisch2= new Tisch("126ABD", 150, 150, 60, 259.99);
            Tisch tisch3= new Tisch("126ABF", 400, 200, 60, 289.99);
            Sitzkissen sitzkissen= new Sitzkissen("127ABC", "Reis", 150, 29.99);
            Sitzkissen sitzkissen2= new Sitzkissen("127ABD", "Reis", 250, 39.99);
            Sitzkissen sitzkissen3= new Sitzkissen("127ABF", "Reis", 500, 59.99);
            IInv[] inventoryList = {speicherkarte, speicherkarte2, speicherkarte3, objektiv, objektiv2, objektiv3, fotoapparat, fotoapparat2, fotoapparat3, tisch, tisch2, tisch3, sitzkissen, sitzkissen2, sitzkissen3};
            Console.WriteLine(string.Format("{0,-15}", "Inventarnummer") + "│" + string.Format("{0,11}", "Preis") + "\n───────────────┼────────────");
            foreach (IInv inventory in inventoryList)
            {
                inventory.GetInvNr();
                value += inventory.Price;
            }
            Console.WriteLine($"\nAnzahl der Inventargegenstände:\t{inventoryList.Length}\nGesamtwert der Gegenstände:\t{Math.Round(value, 2)} €\n");
            
            do
            {
                speicherkarte.Memory += 0.3/1024*fotoapparat.Megapixel;
                if (speicherkarte.CheckMemory())
                {
                    fotoapparat.takePhoto();
                    speicherkarte.Photos++;
                    Console.WriteLine(fotoapparat + "\n");
                    Console.WriteLine(speicherkarte + "\n");
                }
                else
                {
                    Console.WriteLine("Speicherkarte in der Kamera " + fotoapparat.Model + " voll." + "\n");
                }
                speicherkarte2.Memory += 0.3/1024*fotoapparat2.Megapixel;
                if (speicherkarte2.CheckMemory())
                {
                    fotoapparat2.takePhoto();
                    speicherkarte2.Photos++;
                    Console.WriteLine(fotoapparat2 + "\n");
                    Console.WriteLine(speicherkarte2 + "\n");
                }
                else
                {
                    Console.WriteLine("Speicherkarte in der Kamera " + fotoapparat2.Model + " voll." + "\n");
                }
                speicherkarte3.Memory += 0.3/1024*fotoapparat3.Megapixel;
                if (speicherkarte3.CheckMemory())
                {
                    fotoapparat3.takePhoto();
                    speicherkarte3.Photos++;
                    Console.WriteLine(fotoapparat3 + "\n");
                    Console.WriteLine(speicherkarte3 + "\n");
                }
                else
                {
                    Console.WriteLine("Speicherkarte in der Kamera " + fotoapparat3.Model + " voll." + "\n");
                }
            }
            while (Console.ReadLine() == "");
            
        }
    }
}