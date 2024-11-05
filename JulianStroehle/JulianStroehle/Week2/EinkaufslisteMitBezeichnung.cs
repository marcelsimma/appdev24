using System;
namespace JulianStroehle.Week2
{
    public class EinkaufslisteMitBezeichnung
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Sachen wollen Sie einkaufen?");
            int elemente = Convert.ToInt32(Console.ReadLine());
            string?[] Things = new string[elemente];
            string[] strings= new string[elemente];
            string[] ThingsCount = new string[elemente];
            for (int i = 0; i < elemente; i++)
            {
                Console.WriteLine(i + 1 + ". Sache: ");
                Things[i] = Console.ReadLine();
                Console.WriteLine("Anzahl?");
                string? anzahl = Console.ReadLine();
                char[] chars = anzahl.ToCharArray();
                foreach (char c in chars)
                {
                    if (char.IsNumber(c))
                    {
                        ThingsCount[i] += c;
                    }
                }
                string[] s = anzahl.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ');
                foreach (string s2 in s)
                {
                    strings[i] += s2;
                }
            }
            for (int j = 0; j < elemente; j++)
            {
                Console.Write(string.Format("{0,10}", ThingsCount[j]));
                Console.Write(string.Format("{0,-10}", strings[j]));
                Console.Write("\t");
                Console.Write(Things[j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(string.Format("{0,5}", elemente + " Elemente auf der Liste"));
        }
    }
}