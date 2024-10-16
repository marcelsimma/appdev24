using System;
namespace JulianStroehle.Week2
{
    public class DualDezHexA
    {
        public static void Start()
        {
            do
            {

                // Auswahl Zahlenumrechnungsart
                Console.WriteLine("Dez-Hex, Dez-Dual, Hex-Dez, Hex-Dual, Dual-Dez oder Dual-Hex");
                string? placeholder = Console.ReadLine();
                switch (placeholder)
                {
                    case "Dez-Hex": DezZuHex(); break;
                    case "Hex-Dez": HexZuDez(); break;
                    case "Dez-Dual": DezZuDual(); break;
                    case "Dual-Dez": DualZuDez(); break;
                    case "Hex-Dual": HexZuDual(); break;
                    case "Dual-Hex": DualZuHex(); break;
                }
                Console.WriteLine("Again? (y/n)");
            }
            while (Console.ReadLine() == "y");
        }

        // Hexadezimal zu Dezimal Rechner
        public static void HexZuDez()
        {

            // Nutzereingabe Hexadezimalzahl
            Console.WriteLine("Hexadezimalzahl: ");
            string? Num = Console.ReadLine();

            // Array für Hexzahl
            char[] Chars = Num.ToCharArray();
            Array.Reverse(Chars);
            int Value = 0;

            // Zähler für stelle der Zahl
            for (int i = 0; i < Chars.Length; i++)
            {
                int Mal = 1;
                char k = '0';

                // einzelne chars von der Zahl einlesen und Konvertieren
                switch (Chars[i])
                {
                    case '0': k = (char)0; break;
                    case '1': k = (char)1; break;
                    case '2': k = (char)2; break;
                    case '3': k = (char)3; break;
                    case '4': k = (char)4; break;
                    case '5': k = (char)5; break;
                    case '6': k = (char)6; break;
                    case '7': k = (char)7; break;
                    case '8': k = (char)8; break;
                    case '9': k = (char)9; break;
                    case 'A': k = (char)10; break;
                    case 'B': k = (char)11; break;
                    case 'C': k = (char)12; break;
                    case 'D': k = (char)13; break;
                    case 'E': k = (char)14; break;
                    case 'F': k = (char)15; break;
                }

                // Rechner für die weiteren Stellen der Zahl
                for (int j = 0; j < i; j++)
                {
                    Mal *= 16;
                }
                Value += k * Mal;
            }

            // Ausgabe
            Console.WriteLine(Value);
        }

        // Dezimal zu Hexadezimal Rechner
        public static void DezZuHex()
        {

            // Nutzereingabe Dezimalzahl
            Console.WriteLine("Dezimalzahl: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            char[] Hexnums = new char[Number];
            int counter = 0;
            while (Number != 0)
            {

                // Ausgabe des Restwertes der Division
                if (Number % 16 == 0)
                {
                    Hexnums[counter] = '0';
                }
                else if (Number % 16 == 1)
                {
                    Hexnums[counter] = '1';
                }
                else if (Number % 16 == 2)
                {
                    Hexnums[counter] = '2';
                }
                else if (Number % 16 == 3)
                {
                    Hexnums[counter] = '3';
                }
                else if (Number % 16 == 4)
                {
                    Hexnums[counter] = '4';
                }
                else if (Number % 16 == 5)
                {
                    Hexnums[counter] = '5';
                }
                else if (Number % 16 == 6)
                {
                    Hexnums[counter] = '6';
                }
                else if (Number % 16 == 7)
                {
                    Hexnums[counter] = '7';
                }
                else if (Number % 16 == 8)
                {
                    Hexnums[counter] = '8';
                }
                else if (Number % 16 == 9)
                {
                    Hexnums[counter] = '9';
                }
                else if (Number % 16 == 10)
                {
                    Hexnums[counter] = 'A';
                }
                else if (Number % 16 == 11)
                {
                    Hexnums[counter] = 'B';
                }
                else if (Number % 16 == 12)
                {
                    Hexnums[counter] = 'C';
                }
                else if (Number % 16 == 13)
                {
                    Hexnums[counter] = 'D';
                }
                else if (Number % 16 == 14)
                {
                    Hexnums[counter] = 'E';
                }
                else if (Number % 16 == 15)
                {
                    Hexnums[counter] = 'F';
                }

                // Division der Zahl für weitere Stellen
                Number /= 16;
                counter++;
            }
            Array.Reverse(Hexnums);

            // Ausgabe
            Console.WriteLine(Hexnums);
        }
        public static void DualZuDez()
        {

            // Nutzereingabe Dualzahl
            Console.WriteLine("Dualzahl eingeben: ");
            string? Num = Console.ReadLine();

            //Array erstellen
            char[] Nums = [.. Num];
            Array.Reverse(Nums);
            int placeholder = 0;
            int Ergebnis = 0;

            // Zählerschleife
            for (int i = 0; i < Nums.Length; i++)
            {
                int Mal = 1;

                // Zuweisung Integer
                switch (Nums[i])
                {
                    case '0': placeholder = 0; break;
                    case '1': placeholder = 1; break;
                }

                // Hochrechnung für weitere Stellen
                for (int j = 0; j < i; j++)
                {
                    Mal *= 2;
                }

                // Addition zum Ergebnis
                Ergebnis += placeholder * Mal;
            }

            // Ausgabe
            Console.WriteLine(Ergebnis);
        }
        public static void DezZuDual()
        {

            // Nutzereingabe Dezimalzahl
            Console.WriteLine("Dezimalzahl eingeben: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            // Array erstellt
            char[] Nums = new char[Num];
            int counter = 0;

            // Hochzählende while Schleife
            while (Num != 0)
            {

                // Abfrage Restwert
                if (Num % 2 == 0)
                {
                    Nums[counter] = '0';
                }
                else
                {
                    Nums[counter] = '1';
                }
                counter++;
                Num /= 2;
            }

            // Array umdrehen und ausgeben
            Array.Reverse(Nums);
            Console.WriteLine(Nums);
        }
        public static void DualZuHex()
        {

            // Nutzereingabe Dualzahl
            Console.WriteLine("Dualzahl eingeben: ");
            string? Num = Console.ReadLine();

            //Array erstellen
            char[] Nums = [.. Num];
            Array.Reverse(Nums);
            int placeholder = 0;
            int Ergebnis = 0;

            // Zählerschleife
            for (int i = 0; i < Nums.Length; i++)
            {
                int Mal = 1;

                // Zuweisung Integer
                switch (Nums[i])
                {
                    case '0': placeholder = 0; break;
                    case '1': placeholder = 1; break;
                }

                // Hochrechnung für weitere Stellen
                for (int j = 0; j < i; j++)
                {
                    Mal *= 2;
                }

                // Addition zum Ergebnis
                Ergebnis += placeholder * Mal;
            }

            // Ergebnis umwandlung in Hexadezimal
            int Number = Ergebnis;
            char[] Hexnums = new char[Number];
            int counter = 0;
            while (Number != 0)
            {

                // Ausgabe des Restwertes der Division
                if (Number % 16 == 0)
                {
                    Hexnums[counter] = '0';
                }
                else if (Number % 16 == 1)
                {
                    Hexnums[counter] = '1';
                }
                else if (Number % 16 == 2)
                {
                    Hexnums[counter] = '2';
                }
                else if (Number % 16 == 3)
                {
                    Hexnums[counter] = '3';
                }
                else if (Number % 16 == 4)
                {
                    Hexnums[counter] = '4';
                }
                else if (Number % 16 == 5)
                {
                    Hexnums[counter] = '5';
                }
                else if (Number % 16 == 6)
                {
                    Hexnums[counter] = '6';
                }
                else if (Number % 16 == 7)
                {
                    Hexnums[counter] = '7';
                }
                else if (Number % 16 == 8)
                {
                    Hexnums[counter] = '8';
                }
                else if (Number % 16 == 9)
                {
                    Hexnums[counter] = '9';
                }
                else if (Number % 16 == 10)
                {
                    Hexnums[counter] = 'A';
                }
                else if (Number % 16 == 11)
                {
                    Hexnums[counter] = 'B';
                }
                else if (Number % 16 == 12)
                {
                    Hexnums[counter] = 'C';
                }
                else if (Number % 16 == 13)
                {
                    Hexnums[counter] = 'D';
                }
                else if (Number % 16 == 14)
                {
                    Hexnums[counter] = 'E';
                }
                else if (Number % 16 == 15)
                {
                    Hexnums[counter] = 'F';
                }

                // Division der Zahl für weitere Stellen
                Number /= 16;
                counter++;
            }
            Array.Reverse(Hexnums);

            // Ausgabe
            Console.WriteLine(Hexnums);
        }
        public static void HexZuDual()
        {

            // Nutzereingabe Hexadezimalzahl
            Console.WriteLine("Hexadezimalzahl: ");
            string? Hexnum = Console.ReadLine();

            // Array für Hexzahl
            char[] Chars = Hexnum.ToCharArray();
            Array.Reverse(Chars);
            int Value = 0;

            // Zähler für stelle der Zahl
            for (int i = 0; i < Chars.Length; i++)
            {
                int Mal = 1;
                char k = '0';

                // einzelne chars von der Zahl einlesen und Konvertieren
                switch (Chars[i])
                {
                    case '0': k = (char)0; break;
                    case '1': k = (char)1; break;
                    case '2': k = (char)2; break;
                    case '3': k = (char)3; break;
                    case '4': k = (char)4; break;
                    case '5': k = (char)5; break;
                    case '6': k = (char)6; break;
                    case '7': k = (char)7; break;
                    case '8': k = (char)8; break;
                    case '9': k = (char)9; break;
                    case 'A': k = (char)10; break;
                    case 'B': k = (char)11; break;
                    case 'C': k = (char)12; break;
                    case 'D': k = (char)13; break;
                    case 'E': k = (char)14; break;
                    case 'F': k = (char)15; break;
                }

                // Rechner für die weiteren Stellen der Zahl
                for (int j = 0; j < i; j++)
                {
                    Mal *= 16;
                }
                Value += k * Mal;
            }

            // Value umwandlung in Dual
            int Num = Value;

            // Array erstellt
            char[] Nums = new char[Num];
            int counter = 0;

            // Hochzählende while Schleife
            while (Num != 0)
            {

                // Abfrage Restwert
                if (Num % 2 == 0)
                {
                    Nums[counter] = '0';
                }
                else
                {
                    Nums[counter] = '1';
                }
                counter++;
                Num /= 2;
            }

            // Array umdrehen und ausgeben
            Array.Reverse(Nums);
            Console.WriteLine(Nums);
        }
    }
}