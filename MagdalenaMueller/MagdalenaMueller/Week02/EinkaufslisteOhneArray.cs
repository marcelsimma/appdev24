using System;
using System.Data.SqlTypes;

namespace MagdalenaMueller.Week02
{
    public class EinkaufslisteOhneArray
    {
        public static void EinkaufslisteProgramm()
        {
            Console.WriteLine("Schreibe 3 Sachen auf deine Einkaufsliste:");

            string product1, product2, product3;
            string amount1, amount2, amount3;

            // Eingabe der ersten Sache
            Console.Write("Produkt 1: ");
            product1 = Console.ReadLine();
            Console.Write("Anzahl: ");
            amount1 = Console.ReadLine();
            Console.WriteLine();

            // Eingabe der zweiten Sache
            Console.Write("Produkt 2: ");
            product2 = Console.ReadLine();
            Console.Write("Anzahl: ");
            amount2 = Console.ReadLine();
            Console.WriteLine();

            // Eingabe der dritten Sache
            Console.Write("Produkt 3: ");
            product3 = Console.ReadLine();
            Console.Write("Anzahl: ");
            amount3 = Console.ReadLine();
            Console.WriteLine();

            // Ausgabe der Einkaufsliste
            Console.WriteLine("Deine Einkaufsliste:");
            Console.WriteLine($"{amount1}x {product1}");
            Console.WriteLine($"{amount2}x {product2}");
            Console.WriteLine($"{amount3}x {product3}");
            Console.WriteLine($"---------------------");
            Console.WriteLine($"3 Produkte auf der Liste");
        }
    }
}
