using System;

namespace MagdalenaMueller.Week08
{
    public class StartProgram
    {
        internal static void Start()
        {
            bool again = true;
            while (again == true)
            {
                Console.WriteLine("(1) Hinzufügen\n(2) Entfernen\n(3) Suchen\n(4) Bibliotheke anzeigen\n(5) Beenden");
                string? task = Console.ReadLine();

                switch (task)
                {
                    case "1":
                        Bibliothek.Add();
                        break;
                    case "2":
                        Bibliothek.Remove();
                        break;
                    case "3":
                        Bibliothek.Search();
                        break;
                    case "4":
                        Bibliothek.Write();
                        break;
                    case "5":
                        again = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}