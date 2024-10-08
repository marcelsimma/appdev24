using System;

namespace AlessioGaudio.Week01
{
    class Rhombus
    {
        private const int or;

        public static void Start()
        {
            Console.WriteLine("Geben Sie den Monat als Zahl (1-12) ein:");
            int monat = int.Parse(Console.ReadLine());

            // Aufruf der Methode if
            string quartalIfElse = BestimmeQuartalMitIfElse(monat);
            Console.WriteLine($"(If-Else) Der Monat gehört zu: {quartalIfElse}");

            // Aufruf der Methode switch
            string quartalSwitchCase = BestimmeQuartalMitSwitch(monat);
            Console.WriteLine($"(Switch-Case) Der Monat gehört zu: {quartalSwitchCase}");
        }

        // If else methode
        static string BestimmeQuartalMitIfElse(int monat)
        {
            if (monat >= 1 && monat <= 3)
            {
                return "Quartal 1:Frühling";
            }
            else if (monat >= 4 && monat <= 6)
            {
                return "Quartal 2:Sommer";
            }
            else if (monat >= 7 && monat <= 9)
            {
                return "Quartal 3:Herbst";
            }
            else if (monat >= 10 && monat <= 12)
            {
                return "Quartal 4:Winter";
            }
            else
            {
                return "Ungültiger Monat";
            }
        }

        // Switch case Methode
        static string BestimmeQuartalMitSwitch(int monat)
        {
            return monat switch
            {
                1 or 2 or 3 => "Quartal 1",
                4 or 5 or 6 => "Quartal 2",
                7 or 8 or 9 => "Quartal 3",
                10 or 11 or 12 => "Quartal 4",
                _ => "Ungültiger Monat",
            };
        }
    }
}
