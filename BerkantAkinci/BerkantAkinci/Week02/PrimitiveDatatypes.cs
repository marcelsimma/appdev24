using System;

namespace BerkantAkinci.Week02
{
    public class PrimitiveDatatypes
    {
        public static void Start()
        {
            // Deklaration: Erzeugt die Variable
            int number;
            // Initialisierung: Weist der Variable einen Wert zu
            number = 12;
            number = 38;

            // Deklaration und Initialisierung
            int number2 = 33;

            // Konstante: Nicht-änderbare Variable
            const int number3 = 48;
            // number3 = 33;

            // Integer = Ganzzahl
            Console.WriteLine("Integer number:  " + number);
            Console.WriteLine("Integer number2: " + number2);
            Console.WriteLine("Integer number3: " + number3);

            Console.WriteLine($"Zahlenbereich int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Zahlenbereich sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"Zahlenbereich short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine("--------------------");
            // Console.WriteLine($"Zahlenbereich byte   : {byte.MinValue} to {byte.MaxValue}");
            // Console.WriteLine($"Zahlenbereich ushort : {ushort.MinValue} to {ushort.MaxValue}");
            // Console.WriteLine($"Zahlenbereich uint   : {uint.MinValue} to {uint.MaxValue}");
            // Console.WriteLine($"Zahlenbereich ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            // double = Dezimalzahl mit bis zu 15 Kommastellen
            double decimalNumber = 56.3;
            Console.WriteLine("Double decimalNumber:  " + decimalNumber);
            Console.WriteLine("--------------------");

            var variable = 20 / 6.0;
            bool isInt = variable is int;
            bool isDouble = variable is double;
            Console.WriteLine(variable + " isInt:  " + isInt);
            Console.WriteLine(variable + " isDouble:  " + isDouble);
            Console.WriteLine("--------------------");


            // Datentypen
            bool isTrue = number > 3; // Boolean: Speichert true oder false
            char character = 'F'; // Zeichen: einzelnes Zeichen
            string text = "Beispieltext"; // String: Zeichenkette (mehrere Zeichen)
            // weitere: https://www.w3schools.com/cs/cs_data_types.php

            if (isTrue)
            {
                Console.WriteLine("isTrue is true! " + isTrue);
            }

            // TODO:
            // Ergänze float und long und Kommentiere den Unterschied zu double und int
        }
    }
}