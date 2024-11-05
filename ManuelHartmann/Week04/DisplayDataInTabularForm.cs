
namespace ManuelHartmann.Week04
{
    public class DisplayDataInTabularForm
    {
        public static void Start()
        {
            //  Daten fuer Tabelle ---------------------------------------------------------------------------------------
            String[] firstName = { "Alfonso", "Beatrix-Eleonor", "Cecil", "Daniel", "Elmar", "Stefan" };
            String[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma", "Arschkriecher" };
            int[] age = { 40, 78, 5, 18, 81, 11 };
            String[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten", "Muntafuner" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f, 9999.123456789f };
            //  -----------------------------------------------------------------------------------------------------------
            
            TabularForm(firstName, lastName, age, place, distanceFromCapital);  //  Methodenaufruf mit Uebergabeparameter.
        }
        //  Erstellt eine Tabelle aus den Uebergabeparameter.
        static void TabularForm(String[] firstname, String[] lastName, int[] age, String[] place, float[] distanceFromCapital)
        {
            //  Definiert den Aufbau des Strings.
            /*  Erklaerung: {0-18} => '0' steht fuer die erste Variable 'FirstName' und '18' + 1 Leerzeichen, dass '|' erst an der Stelle 
                19 geschrieben wird. Da '18' positiv ist, ist die Variable 'FirstName' rechtsbuendig. */
            Console.WriteLine(string.Format("{0,-18} | {1,-18} | {2,-18:N0} | {3,-18} | {4,18:N3}",
                "FirstName", "LastName:", "Age:", "Place:", "DistanceFromCapital:"));
            //  Aufbau einer neuen Variable -> '=' wird '105' mal geschrieben.
            Console.WriteLine(new string('=', 105));

            //  Tabellenaufbau wird fuer jedes Element ausgefuehrt.
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(string.Format("{0,-18} | {1,-18} | {2,-18:N0} | {3,-18} | {4,18:N3}",
                    firstname[i], lastName[i], age[i], place[i], distanceFromCapital[i]));
            }
        }
    }
}

