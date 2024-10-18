using System;
using System.Runtime.CompilerServices;

namespace BerkantAkinci.Week03
{

    class EindimensionalesArray
    {

        public static void PrintEinArray()
        {
            SearchInt();
            SearchChar();
            SearchString();
        }

        public static void SearchInt()
        {
            int[] Wert1 = [-1, 12, 88, 68, 52, 47, 36, 48, 95];
            int index = -1;
            int UserInput = 0;

            do
            {
                System.Console.Write("Gebe dein Int ein: ");
                UserInput = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= Wert1.Length - 1; i++)
                {
                    if (UserInput == Wert1[i])
                    {
                        index = i;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Dieser Integer wurde nicht gefunden");
                }
                else
                {
                    Console.WriteLine($"Dieser Integer befindet sich an der Stelle {index}");
                }

            }

            while (index == -1);
        }

        public static void SearchChar()
        {
            string[] Wert2 = ["Hallo", "Warum", "Auto", "Baum", "Blatt"];
            int index = -1;
            string UserInput = " ";

            do
            {
                System.Console.Write("Gebe dein String ein:");
                UserInput = Console.ReadLine();

                index = -1;

                for (int i = 0; i <= Wert2.Length - 1; i++)
                {
                    if (UserInput == Wert2[i])
                    {
                        index = i;
                    }
                }

                if (index == -1)
                {
                    System.Console.WriteLine($"Dieser String wurde nicht gefunden");
                }

                else
                {
                    System.Console.WriteLine($"Dieser String befindet sich an der Stelle {index}");
                }
            }

            while (index == -1);
        }

        public static void SearchString()
        {
            char[] Wert3 = ['P', '4', 'X', 'L', 'K'];
            int index = -1;
            char UserInput = ' ';

            do
            {
                System.Console.Write("Gebe dein Char ein:");
                UserInput = Convert.ToChar(Console.ReadLine());

                index = -1;

                for (int i = 0; i <= Wert3.Length - 1; i++)
                {
                    if (UserInput == Wert3[i])
                    {
                        index = i;
                    }
                }

                if (index == -1)
                {
                    System.Console.WriteLine($"Dieser Char wurde nicht gefunden");
                }

                else
                {
                    System.Console.WriteLine($"Dieser Char befindet sich an der Stelle {index}");
                }
            }
            while (index == -1);
        }
    }
}