using System;
namespace JulianStroehle.Week2
{
    public class Einkaufsliste
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Sachen wollen Sie einkaufen?");
            int elemente = Convert.ToInt32(Console.ReadLine());
            string?[] Things = new string[elemente];
            int[] ThingsCount = new int[elemente];
            for (int i = 0; i < elemente; i++)
            {
                Console.WriteLine(i + 1 + ". Sache: ");
                Things[i] = Console.ReadLine();
                Console.WriteLine("Anzahl?");
                ThingsCount[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < elemente; j++)
            {
                Console.Write(string.Format("{0,10}", ThingsCount[j]));
                Console.Write("\t");
                Console.Write(string.Format("{0,-10}", Things[j]));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(string.Format("{0,10}", elemente + " Elemente auf der Liste\n"));
        }
    }
}