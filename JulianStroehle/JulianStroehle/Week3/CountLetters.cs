using System;
namespace JulianStroehle.Week3
{
    public class CountLetters
    {
        public static void Start()
        {
            Console.WriteLine("Text eingeben:");
            string Text = Console.ReadLine();
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ä', 'ö', 'ü', 'A', 'B', 'C' , 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ä', 'Ö', 'Ü'};
            int[] counts = new int[58];
            foreach (char c in Text)
            {
                switch (c)
                {
                    case 'a': counts[0]++; break;
                    case 'b': counts[1]++; break;
                    case 'c': counts[2]++; break;
                    case 'd': counts[3]++; break;
                    case 'e': counts[4]++; break;
                    case 'f': counts[5]++; break;
                    case 'g': counts[6]++; break;
                    case 'h': counts[7]++; break;
                    case 'i': counts[8]++; break;
                    case 'j': counts[9]++; break;
                    case 'k': counts[10]++; break;
                    case 'l': counts[11]++; break;
                    case 'm': counts[12]++; break;
                    case 'n': counts[13]++; break;
                    case 'o': counts[14]++; break;
                    case 'p': counts[15]++; break;
                    case 'q': counts[16]++; break;
                    case 'r': counts[17]++; break;
                    case 's': counts[18]++; break;
                    case 't': counts[19]++; break;
                    case 'u': counts[20]++; break;
                    case 'v': counts[21]++; break;
                    case 'w': counts[22]++; break;
                    case 'x': counts[23]++; break;
                    case 'y': counts[24]++; break;
                    case 'z': counts[25]++; break;
                    case 'ä': counts[26]++; break;
                    case 'ö': counts[27]++; break;
                    case 'ü': counts[28]++; break;
                    case 'A': counts[29]++; break;
                    case 'B': counts[30]++; break;
                    case 'C': counts[31]++; break;
                    case 'D': counts[32]++; break;
                    case 'E': counts[33]++; break;
                    case 'F': counts[34]++; break;
                    case 'G': counts[35]++; break;
                    case 'H': counts[36]++; break;
                    case 'I': counts[37]++; break;
                    case 'J': counts[38]++; break;
                    case 'K': counts[39]++; break;
                    case 'L': counts[40]++; break;
                    case 'M': counts[41]++; break;
                    case 'N': counts[42]++; break;
                    case 'O': counts[43]++; break;
                    case 'P': counts[44]++; break;
                    case 'Q': counts[45]++; break;
                    case 'R': counts[46]++; break;
                    case 'S': counts[47]++; break;
                    case 'T': counts[48]++; break;
                    case 'U': counts[49]++; break;
                    case 'V': counts[50]++; break;
                    case 'W': counts[51]++; break;
                    case 'X': counts[52]++; break;
                    case 'Y': counts[53]++; break;
                    case 'Z': counts[54]++; break;
                    case 'Ä': counts[55]++; break;
                    case 'Ö': counts[56]++; break;
                    case 'Ü': counts[57]++; break;
                }
            }
            for (int i = 0; i < counts.Length; i++) 
            {
                if (counts[i] != 0)
                {
                    Console.Write($"Der Buchstabe {letters[i]} ist im Text ");
                    Console.Write(string.Format("{0, 5}", counts[i]));
                    Console.WriteLine(" mal enthalten");

                }
            }
            Console.WriteLine("Gesamte Buchstaben: " + counts.Sum());
        }
    }
}