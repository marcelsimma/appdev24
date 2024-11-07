using System;
using System.Reflection.Metadata;

namespace AlessioGaudio.Week02
{
    class ArraySearch
    {
        public static void Start()
        {
            int[] intarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] chararray = { 'a', 'b', 'c', 'e', 'f', 'g', 'h', 'j', 'k', 'l' };
            string[] stringarray = { "apfel", "birne", "banane", "kiwi", "pfirsich", "orange,", "pflaume" };

            // Wert von der Console eingeben 
            Console.WriteLine("Gib den zu suchenden Wert ein: ");
            int intwert = Convert.ToInt32(Console.ReadLine());
            char charwert = Convert.ToChar(Console.ReadLine());
            string stringwert = (Console.ReadLine());
            bool WertGefunden = false; //bool 

            // Index des Wertes im Array suchen

            for (int i = 0; i < intarray.Length; i++)
            {
                if (intwert == intarray[i])
                {
                    WertGefunden = true;
                    Console.WriteLine($"Der eingegebene Wert {intwert} entspricht dem folgenden Index {i}.");
                }
            }
            if (WertGefunden != true)
            {
                Console.WriteLine($"Der eingegebene Wert konnte nicht gefunden werden.");
            }

            WertGefunden = false;

            for (int c = 0; c < chararray.Length; c++)
            {
                if (charwert == chararray[c])
                {
                    WertGefunden = true;
                    Console.WriteLine($"Der eingegebene Wert {charwert} entspricht dem folgenden Index {c}.");
                }
            }
            if (WertGefunden != true)
            {
                Console.WriteLine($"Der eingegebene Wert konnte nicht gefunden werden.");
            }

            WertGefunden = false;

            for (int s = 0; s < stringarray.Length; s++)
            {
                if (stringwert == stringarray[s])
                {
                    WertGefunden = true;
                    Console.WriteLine($"Der eingegebene Wert {stringwert} entspricht dem folgenden Index {s}.");
                }
            }
            if (WertGefunden != true)
            {
                Console.WriteLine($"Der eingegebene Wert konnte nicht gefunden werden.");
            }
         }
    }
}

