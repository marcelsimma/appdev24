
using System.Numerics;

namespace ManuelHartmann.Week03
{
    public class AbscentList
    {
        static int arrayCounter = 0;    // Zahler, wie viele Array Zeilen verwendet werden.
        // Jagged Array 
        static string[][] abscentList = new string[10][];
        // Befuellt das leere Jagged Array. Ohne leere Platzhalter kann auch nichts befuellt werden.
        public static void FillArray()
        {
            for (int i = 0; i < 10; i++)
            {
                abscentList[i] = new string[2]; // Erstellt 10 Zeilen mit 2 Spalten.
            }
        }
      
        static void Start(string[] args)
        {
            BuildMenu();
        }

        public static void BuildMenu()
        {
            FillArray();
            string userAbscent = "";
            string userReason = "";
            bool existAlready = false;
            int counter = 0;
            do
            {
                existAlready = false;   // Muss bei jedem Schleifenstart erneut auf 'false' gesetzt werden.
                PrintAbscentList();
                Console.WriteLine("Hello Sir or Madem, please insert your name, so i can add you to the abscentList.");
                Console.WriteLine(new string('-', 30));
                Console.WriteLine(" Leave loop with: \"exit\".");
                Console.WriteLine(new string('-', 30));
                string tmp = Console.ReadLine();
                userAbscent = tmp.ToLower();
                Console.WriteLine("Furthermore, I'd like to have your abscant reason.");
                userReason = Console.ReadLine();
                counter = abscentList.Length;   // Anzahl Zeilen (Erste Dimension) [0].
                for (int i = 0; i < counter; i++)
                {
                    if (abscentList[i][0] == userAbscent)   // Pruefen, ob der User bereits angelegt wurde.
                    {
                        Console.WriteLine("The User does already exist in the List!");
                        string[] temp = new string[abscentList[i].Length + 1];  // Anzahl Spalten um 1 erhoehen. (Dafuer verwenden wir einen 'temp'.
                        for (int ii = 0;  ii < temp.Length - 1; ii++)   // Anzahl Spalten -1, um die Erweiterung ´nicht zu betrachten.
                        {
                            temp[ii] = abscentList[i][ii];  // Alle bisher bestehenden Spalten ins 'temp' uebernehmen.
                        }
                        temp[temp.Length - 1] = userReason; // Einfuegen der ergaenzung.
                        abscentList[i] = temp;  // Erweiterung zurueck ins Jagged Array nehmen.
                        existAlready = true;    // Eingegebener User exisiert bereits.
                        break;
                    }
                }
                if (existAlready == false)  // Eingegebener User exisiert noch nicht.
                {
                    arrayCounter++; // Es wird eine weitere Zeile verwendet.
                    Console.WriteLine("The User doesn't exist in the List yet!");
                    for (int j = 0; j < abscentList.Length; j++)
                    {
                        if (abscentList[j][0] == null)   // Springt bis zur naechsten Leeren Zelle.
                        {
                            abscentList[j][0] = userAbscent;
                            abscentList[j][1] = userReason;
                            break;
                        }
                    }
                }
            } while (userAbscent != "exit");
            Console.Clear();
            PrintAbscentList();
        }
        // Gibt die gesamte AbscentList aus.
        static void PrintAbscentList()
        {
            Console.Clear();
            Console.WriteLine(" AbscentList ");
            for (int i = 0; i < arrayCounter; i++)
            {
                Console.Write($"Name: {abscentList[i][0]} | Reasons: ");
                for (int j = 1; j < abscentList[i].Length; j++)
                {
                    Console.Write($"{abscentList[i][j]}, ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 16));
            }
        }
    }
}

