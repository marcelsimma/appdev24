using System;
namespace JulianStroehle.Week2
{
    public class DezHexA
    {
        public static void DezHex()
        {
            string YN;
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
            YN = Console.ReadLine();
            }
            while (YN == "y");
        }
        public static void HexDez()
        {
            Console.WriteLine("");
        }
    }
}