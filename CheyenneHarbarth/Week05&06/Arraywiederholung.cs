using System;
using CheyenneHarbarth.Week07.Supermarket;

namespace CheyenneHarbarth.Week05
{

    internal class Arraywiederholung
    {
        public static void PrintSortiment()
        {
            Checkout checkout = new Checkout("31614645");
            string[] Sortiment = {
                "Dinkelflocken",
                "Haferflocke",
                "Leinsamen",
                "Joghurt",
                "Zimt",
                "Beeren",
                "Bananen",
                "Erdnüsse",
                "Walnüsse",
                "Orangensaft"
            };

            string[] SortimentNeu = new string[Sortiment.Length + 5];

            Console.WriteLine();
            Console.WriteLine("Altes Sortiment:");

            for (int i = 0; i < Sortiment.Length; i++)
            {
                SortimentNeu[i] = Sortiment[i];
                Console.WriteLine($"{Sortiment[i],20}");
            }

            SortimentNeu[10] = "Eier";
            SortimentNeu[11] = "Paprika";
            SortimentNeu[12] = "Spinat";
            SortimentNeu[13] = "Cottage Cheese";
            SortimentNeu[14] = "Salz";

            Console.WriteLine("Neues Sortiment:");

            for (int i = 0; i < SortimentNeu.Length; i++)
            {
                Console.WriteLine($"{SortimentNeu[i],20}");
            }
        }
    }
}