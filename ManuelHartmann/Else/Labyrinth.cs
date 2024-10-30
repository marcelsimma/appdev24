
using System.Globalization;

namespace ManuelHartmann.Else
{
    public class Labyrinth
    {   
        // Aufbau des Labyrinth
        public static int[][] lab =
        {
            new int[] {0,0,1,1,1,1,1,1,1,1},

            new int[] {1,0,1,1,1,1,1,1,1,1},

            new int[] {1,0,1,0,0,0,1,1,1,1},

            new int[] {1,0,0,0,1,0,1,1,1,1},

            new int[] {1,0,1,0,1,0,1,1,1,1},

            new int[] {1,1,1,1,1,0,1,1,1,1}
        };
        
        static int rows = lab.Length;      // Anzahl Zeilen 'Y' in (int).
        static int cols = lab[0].Length;   // Anzahl Spalten 'X' in (int).
        static int steps = 0;           // Schritte Zaehler.

        public static void Start()
        {
            // Starte den Weg durch das Labyrinth von (0, 0)
            if (FindExit(0, 0))
            {
                Console.WriteLine("Ausgang gefunden!");
                Console.WriteLine($"Anzahl benoetigter Schritte: {steps}");
            }
            else
            {
                Console.WriteLine("Kein Ausgang gefunden!");
            }
        }
        static bool FindExit(int y, int x)
        {
            // Ausgangspunkt erreicht (letztes Feld)
            if (y == rows || x == cols)
            {
                lab[y][x] = 4; // Markiere den Endpunkt
                PrintLabyrinth();
                return true;
            }

            // Überprüfe, ob die aktuelle Position gültig ist
            if (IsValidMove(y, x))
            {
                // Markiere den aktuellen Schritt
                if (y == rows - 1 || x == cols - 1 && lab[y][x] != 1)
                {
                    lab[x][y] = 4; // Markiere den Endpunkt
                    PrintLabyrinth();
                    return true;
                }
                lab[y][x] = 2;
                steps++;
                PrintLabyrinth();
                Thread.Sleep(400); // Warte 400 ms, um die Animationen besser sichtbar zu machen.

                // Ueberprueft bei jedem moeglichen Schritt, ob er das Ende erreicht hat oder die Richtung moeglich ist.
                if (FindExit(y, x + 1)) // Rechts
                {
                    return true;
                }
                if (FindExit(y + 1, x)) // Unten
                {
                    return true;
                }
                if (FindExit(y, x - 1)) // Links
                {
                    return true;
                }
                if (FindExit(y - 1, x)) // Oben
                {
                    return true;
                }
                
                /* In einer Sackgasse waeren alle Bedingungen 'false', weil er in einem bereits ueberschriebenen Feld steht. ->
                   Zurückgehen, da der Weg nicht erfolgreich war    */
                lab[y][x] = 3;
                //steps--;
            }
            return false;
        }

        static bool IsValidMove(int y, int x)
        {
            // Überprüfe, ob die Position innerhalb des Labyrinths liegt und der Wert 0 ist
            return y >= 0 && y < rows && x >= 0 && x < cols && lab[y][x] == 0;
        }

        static void PrintLabyrinth()
        {
            Console.Clear();
            //Console.WriteLine();
            for (int yy = 0; yy < rows; yy++)
            {
                for (int xx = 0; xx < cols; xx++)
                {
                    if      (lab[yy][xx] == 1)
                        Console.Write("░ "); // Wand
                    else if (lab[yy][xx] == 2)
                        Console.Write("+ "); // Besuchte Zelle
                    else if (lab[yy][xx] == 3)
                        Console.Write("- "); // Zurückgegangen (Sackgasse)
                    else if (lab[yy][xx] == 4)
                        Console.Write("* "); // Ausgangspunkt/Ziel
                    else
                        Console.Write("  "); // Freier Weg
                }
                Console.WriteLine();
            }
        }
    }
}

