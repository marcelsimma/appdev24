using System;
using System.Globalization;
namespace JulianStroehle.Week2
{
    public class DezHexA
    {
        public static void DezHex()
        {
            do
            {
                Console.WriteLine("Hexadezimalzahl: ");
                string? Num = Console.ReadLine();
                char[] Chars = Num.ToCharArray();
                Array.Reverse(Chars);
                int Value = 0;
                for (int i = 0; i < Chars.Length; i++)
                {
                    int Mal = 1;
                    char k = '0';
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
                    for (int j = 0; j < i; j++)
                    {
                        Mal *= 16;
                    }
                    Value += k * Mal;
                }
                Console.WriteLine(Value);
                Console.WriteLine("Continue? y/n");
            }
            while (Console.ReadLine() == "y");
        }
        public static void HexDez()
        {
            do
            {
                Console.WriteLine("Dezimalzahl: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                char c;
                char[] Hexnums = new char[Number];
                int counter = 0;

                while (Number != 0)
                {
                    counter++;
                    Number = Number / 16;
                    if (Number == 10)
                    {
                        c = 'A';
                        c = Hexnums[counter];
                    }
                    else if (Number == 11)
                    {
                        c = 'B';
                        c = Hexnums[counter];
                    }
                    else if (Number == 12)
                    {
                        c = 'C';
                        c = Hexnums[counter];
                    }
                    else if (Number == 13)
                    {
                        c = 'D';
                        c = Hexnums[counter];
                    }
                    else if (Number == 14)
                    {
                        c = 'E';
                        c = Hexnums[counter];
                    }
                    else if (Number == 15)
                    {
                        c = 'F';
                        c = Hexnums[counter];
                    }
                    else
                    {
                        Hexnums[counter] = Convert.ToChar(Number % 16);
                    }
                }
                Array.Reverse(Hexnums);
                Console.WriteLine(Hexnums);
                Console.WriteLine("Continue? (y/n)");
            }
            while (Console.ReadLine() == "y");
        }
    }
}