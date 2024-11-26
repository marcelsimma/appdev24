using System;
using System.Runtime.InteropServices;
using BerkantAkinci.Week02;
using BerkantAkinci.Week04;
using Microsoft.VisualBasic;

namespace BerkantAkinci.Week05
{

    class Bankomat
    {

        public static void PrintBakomat()
        {
            double kontostand = 123.45;

            while (true)
            {
                System.Console.WriteLine("Folgende Funktionen stehen zur Verfügung: ");
                System.Console.WriteLine();
                System.Console.WriteLine("a. Geld einzahlen");
                System.Console.WriteLine("b. Geld abheben");
                System.Console.WriteLine("c. Kontostand anzeigen");
                System.Console.WriteLine("d. Beenden");
                System.Console.WriteLine();
                System.Console.WriteLine("Wählen sie eine Funktion durch Eingabe des entsprechenden\nBuchstabens vor der Funktion.");
                char letter = ConsoleInput.PrintNextChar();

                if (letter == 'a')
                {
                    System.Console.WriteLine("Tippe dein Einzahlungsbetrag ein: ");
                    string tmp = Console.ReadLine();

                    if (double.TryParse(tmp, out double tmp1))
                    {
                        System.Console.WriteLine();
                    }

                    else
                    {
                        System.Console.WriteLine("Das war eine ungültige Zahl! \n \nProbiere es nochmal \n");
                    }
                }

                if (letter == 'b')
                {
                    System.Console.WriteLine("Tippe dein Auszahlungsbetrag ein: ");
                    string tmp = Console.ReadLine();

                    if (double.TryParse(tmp, out double tmp2))
                    {
                        if (kontostand < tmp2)
                        {
                            System.Console.WriteLine("Das ist leider nicht möglich.\nKontostand zu gering!");
                        }
                        System.Console.WriteLine();
                    }

                    else
                    {
                        System.Console.WriteLine("Das war eine ungültige Zahl! \n \nProbiere es nochmal \n");
                    }
                }

                if (letter == 'c')
                {
                    System.Console.WriteLine("Dein aktueller Kontostand:");
                    System.Console.WriteLine(kontostand);
                }

                if (letter == 'd')
                {
                    break;
                }

                 else
                {
                    System.Console.WriteLine("Ungültiges Zeichen.\nProbiere es nochmal!");
                }
            }
        }
    }
}



