using System;
using System.Globalization;
namespace JulianStroehle.Week2
{
    public class DezHexA
    {

        // Hexadezimal zu Dezimal Rechner
        public static void HexZuDez()
        {
            do
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
                Console.WriteLine("Continue? y/n");
            }
            while (Console.ReadLine() == "y");
        }

        // Dezimal zu Hexadezimal Rechner
        public static void DezZuHex()
        {
            do
            {

                // Nutzereingabe Dezimalzahl
                Console.WriteLine("Dezimalzahl: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                char[] Hexnums = new char[Number];
                int counter = 0;
                while (Number != 0)
                {

                    // Ausgabe des Restwertes der Division
                    if (Number%16 == 0)
                    {
                        Hexnums[counter] = '0';
                    }
                    else if (Number%16 == 1)
                    {
                        Hexnums[counter] = '1';
                    }
                    else if (Number%16 == 2)
                    {
                        Hexnums[counter] = '2';
                    }
                    else if (Number%16 == 3)
                    {
                        Hexnums[counter] = '3';
                    }
                    else if (Number%16 == 4)
                    {
                        Hexnums[counter] = '4';
                    }        
                    else if (Number%16 == 5)
                    {
                        Hexnums[counter] = '5';
                    }
                    else if (Number%16 == 6)
                    {
                        Hexnums[counter] = '6';
                    }
                    else if (Number%16 == 7)
                    {
                        Hexnums[counter] = '7';
                    }
                    else if (Number%16 == 8)
                    {
                        Hexnums[counter] = '8';
                    }
                    else if (Number%16 == 9)
                    {
                        Hexnums[counter] = '9';
                    }              
                    else if (Number%16 == 10)
                    {
                        Hexnums[counter] = 'A';
                    }
                    else if (Number%16 == 11)
                    {
                        Hexnums[counter] = 'B';
                    }
                    else if (Number%16 == 12)
                    {
                        Hexnums[counter] = 'C';
                    }
                    else if (Number%16 == 13)
                    {
                        Hexnums[counter] = 'D';
                    }
                    else if (Number%16 == 14)
                    {
                        Hexnums[counter] = 'E';
                    }
                    else if (Number%16 == 15)
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
                Console.WriteLine("Continue? (y/n)");
            }
            while (Console.ReadLine() == "y");
        }
    }
}