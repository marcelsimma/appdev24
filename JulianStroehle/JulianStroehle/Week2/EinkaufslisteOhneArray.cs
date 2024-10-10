using System;
namespace JulianStroehle.Week2
{
    public class EinkaufC
    {
        public static void Einkauf()
        {
            string output = "Einkaufsliste:\n\n";
            char addNewItem;
            int items = 0;
            do
            {
                Console.WriteLine("Anzahl?");
                int anzahl = ConsoleInput.IsInt();
                output += $"{anzahl, 6}";
                Console.WriteLine("Einheit? (Stk, kg, l)");
                string? eh = Console.ReadLine();
                output += $"{eh, -5}";
                Console.WriteLine("Bezeichnung?");
                string? bz = Console.ReadLine();
                output += bz + "\n";
                Console.WriteLine("Wollen sie noch etwas hinzufügen? (j/n)");
                addNewItem = Convert.ToChar(Console.ReadLine());
                items++;
            }
            while (addNewItem == 'j');
            Console.WriteLine(output);
            Console.WriteLine(@$"----------------------
Anzahl der Elemente: {items}");
        }
    }
}