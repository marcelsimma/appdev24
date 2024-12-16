using System;
using System.Text.RegularExpressions;

namespace BerkantAkinci.AUebung
{
    public class SwitchLernen
    {
        public static void Start()
        {
            System.Console.Write("Bitte gib deine Note ein: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    System.Console.WriteLine("Du hast ein Sehr Gut.");
                    break;

                case "2":
                    System.Console.WriteLine("Du hast ein Gut.");
                    break;

                case "3":
                    System.Console.WriteLine("Du hast ein Befriedigend.");
                    break;

                case "4":
                    System.Console.WriteLine("Du hast ein Genügend.");
                    break;

                case "5":
                    System.Console.WriteLine("Du hast ein Nicht Genügend.");
                    break;

                case "-":
                    System.Console.WriteLine("Dein Test wurde nicht beurteilt.");
                    break;

                default:
                    System.Console.WriteLine("Dieses Beurteilungssystem existiert nicht in Österreich.");
                    break;
            }
        }
    }
}