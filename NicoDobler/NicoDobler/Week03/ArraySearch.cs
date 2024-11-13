using System;
 
namespace NicoDobler.Week03
{
    public class ArraySearch
    {
        public static void Start()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Wert von der Console einlesen
            Console.WriteLine("Gib den zu suchenden Wert ein: ");
            int wert = Convert.ToInt32(Console.ReadLine());
            bool WertGefunden = false; //bool
 
            // Index des Wertes im Array suchen
 
            for (int i = 0; i < array.Length; i++)
            {
                if (wert == array[i])
                {
                   WertGefunden = true;
                    Console.WriteLine($"Der eingegebene Wert {wert} entspricht dem folgenden Index {i}.");
                }
            }
            if (WertGefunden == false)
            {
                Console.WriteLine($"Der eingegebene Wert konnte nicht gefunden werden.");
                Start();
            }
        }
    }
}